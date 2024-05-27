using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.Helper;
using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.SecurityMatrix;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.SecurityMatrix;
using QLHSC07.Model.User;
using QLHSC07.Services.Interfaces;

namespace QLHSC07.Services.Implements
{
    public class SecurityMatrixService : ISecurityMatrixService
    {
        private readonly ISecurityMatrixRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<SecurityMatrixService> _logger;
        private readonly IActionRepository _actionRepository;
        private readonly IScreenRepository _screenRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public SecurityMatrixService(ILogger<SecurityMatrixService> logger, IUnitOfWork unitOfWork, ISecurityMatrixRepository repository, IActionRepository actionRepository, IScreenRepository screenRepository,
            UserManager<User> userManager, IMapper mapper)
        {
            _repository = repository;
            _actionRepository = actionRepository;
            _screenRepository = screenRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<ICollection<ScreenDto>> GetListScreen(string userId)
        {
            var user = _userManager.Users.Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
                .Where(u => u.Id == userId).Select(e => new CurrentUserDto
                {
                    Id = e.Id,
                    UserName = e.UserName,
                    Email = e.Email,
                    FullName = e.FullName,
                    UserType = e.UserType,
                    Roles = e.UserRoles.Select(c => new RoleDto
                    {
                        Id = c.Role.Id,
                        Code = c.Role.Code
                    }).ToList()
                }).FirstOrDefault();

            if (user == null) return null;

            var roleAdmin = user.Roles.Any(x => x.Code == RoleHelper.Admin);

            var roles = user.Roles.Select(x => x.Id);
            var query = _repository.GetAll().Include(x => x.Screen.Parent)
                .WhereIf(!roleAdmin, x => roles.Contains(x.RoleId))
                .Select(x => x.Screen)
                .Distinct()
                .ToList().OrderBy(x => x.Order);
            var response = _mapper.Map<ICollection<ScreenDto>>(query);
            var parent = response.Where(x=>x.Parent!=null).Select(x => x.Parent).Distinct().Union(response.Where(x => x.Parent == null && x.Code != null)).OrderBy(x=>x.Order);
            foreach (var item in parent)
            {
                var childrent = response.Where(x => x.ParentId == item.Id).ToList();
                item.Childrent = childrent;
            }

            return parent.ToList();
        }

        public List<ActionLookupDto> GetActionLookup()
        {
            return _actionRepository.Query(x => x.Id > 0).Select(x => new ActionLookupDto
            {
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }

        public List<ScreenLookupDto> GetScreenLookup()
        {
            return _screenRepository.Query(x => x.Id > 0 && x.Code!=null && x.Code!="").OrderBy(x=>x.Order).Select(x => new ScreenLookupDto
            {
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }

        public IPagedList<SecurityMatrixListViewDto> GetListSecurityMatrix(int pageIndex, int pageSize, string sortExpression, string roleName,
            string screenName)
        {
            var data = _repository.GetAll()
                .Include(e => e.Screen)
                .Include(e => e.Action)
                .Include(e => e.Role).GroupBy(x => new
                {
                    x.Id,
                    x.RoleId,
                    RoleName = x.Role.Name,
                    ScreenName = x.Screen.Name,
                    x.ScreenId
                });
            var filterParams = MapParams(roleName, screenName);

            var rs = data.Select(x => new SecurityMatrixListViewDto
            {
                Id = x.Key.Id,
                ScreenId = x.Key.ScreenId,
                RoleId = x.Key.RoleId,
                RoleName = x.Key.RoleName,
                ScreenName = x.Key.ScreenName,
                Actions = _repository.GetAll().Include(securityMatrix => securityMatrix.Action).Where(e => e.Id == x.Key.Id).Select(e => new ActionLookupDto
                {
                    Id = e.Action.Id,
                    Name = e.Action.Name
                }).ToList()
            }).ToList();
            return rs.FilteredData(filterParams).AsQueryable().Sort(sortExpression ?? "RoleName asc").ToPagedList(pageIndex, pageSize);
        }

        public List<ScreenViewDto> GetDetailSecurityMatrix(string RoleId)
        {
            var listScreen = _repository.Query(x => x.RoleId == RoleId).Include(x=>x.Screen).Select(x=> new ScreenViewDto
            {
                ScreenId = x.ScreenId,
                ScreenName = x.Screen.Name
            });
            var screen = listScreen.Distinct().ToList();
            foreach (var entry in screen)
            {
                var listAction = _repository.Query(x => x.ScreenId == entry.ScreenId && x.RoleId == RoleId).Select(x => new ActionViewDto
                {
                    ActionId = x.ActionId,
                    ActionName = x.Action.Name
                }).ToList();
                entry.Actions = listAction;
            }
            return screen;
        }

        public bool CreateSecurityMatrix(CreateSecurityMatrixDto model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                if (!model.Screens.Any())
                {
                    return false;
                }

                foreach (var entry in from screen in model.Screens
                                      from action in screen.Actions
                                      select new SecurityMatrix
                                      {
                                          RoleId = model.RoleId,
                                          ScreenId = screen.ScreenId,
                                          ActionId = action.ActionId
                                      })
                {
                    _repository.Insert(entry);
                }
                dbTransaction.Commit();
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public bool UpdateSecurityMatrix(CreateSecurityMatrixDto model)
        {
            using var dbTransaction = _unitOfWork.BeginTransaction();
            try
            {
                var deleted = _repository.Query(x => x.RoleId == model.RoleId).ToList();
                if (!model.Screens.Any())
                {
                    _repository.DeleteMulti(deleted);
                    dbTransaction.Commit();
                    _unitOfWork.Complete();
                    return true;
                }

                _repository.DeleteMulti(deleted);
                foreach (var screen in model.Screens)
                {
                    var listActions = screen.Actions.Distinct().ToList();
                    foreach (var action in listActions)
                    {
                        var entry = new SecurityMatrix
                        {
                            RoleId =  model.RoleId,
                            ScreenId = screen.ScreenId,
                            ActionId = action.ActionId
                        };
                        _repository.Insert(entry);
                    }
                }
                dbTransaction.Commit();
                _unitOfWork.Complete();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return false;
            }
        }

        public bool CheckPermission(string roleName, string actionName, string screenName)
        {
            return _repository.CheckPermission(roleName, actionName, screenName);
        }

        #region Private

        private List<FilterExtensions.FilterParams> MapParams(string roleName, string screenName)
        {
            var filterParams = new List<FilterExtensions.FilterParams>();
            if (!string.IsNullOrEmpty(roleName))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "RoleName",
                    FilterValue = roleName
                });
            if (!string.IsNullOrEmpty(screenName))
                filterParams.Add(new FilterExtensions.FilterParams()
                {
                    ColumnName = "ScreenName",
                    FilterValue = screenName
                });
            return filterParams;
        }

        #endregion
    }
}
