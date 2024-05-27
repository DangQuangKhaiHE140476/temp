using Aspose.Cells;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QLHSC07.CORE;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Services.BaseServices;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using QLHSC07.Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static QLHSC07.CORE.Helper.Constant;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class ProjectService : BaseService<long, Project, ProjectDto, ProjectDto, CreateProjectDto, UpdateProjectDto, FilterProjectDto>, IProjectService
    {
        private readonly IRepository<ReceiveType, long> _receiveType;
        private readonly IRepository<RecordsStatus, long> _recordStatus;
        private readonly IRepository<RecordsType, long> _recordType;
        private readonly IRepository<ProjectStatus, long> _projectStatusRepo;
        private readonly ICommuneService _communeRepo;
        private readonly IRepository<ProjectHasCommune, long> _projectHasCommuneRepo;
        private readonly RootFile _rootFile;

        public ProjectService(IRepository<Project, long> repository, IMapper mapper, ILogger<ProjectService> logger, IUnitOfWork unitOfWork, IRepository<ReceiveType, long> receiveType,
            IHttpContextAccessor httpContextAccessor, IRepository<RecordsStatus, long> recordStatus, IRepository<RecordsType, long> recordType, IRepository<ProjectHasCommune, long> projectHasCommuneRepo,
            UserManager<User> userManager, IRepository<ProjectStatus, long> projectStatusRepo, RootFile rootFile, ICommuneService communeRepo) :
            base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        {
            _receiveType = receiveType;
            _recordStatus = recordStatus;
            _recordType = recordType;
            _projectStatusRepo = projectStatusRepo;
            _projectHasCommuneRepo = projectHasCommuneRepo;
            _communeRepo = communeRepo;
            _rootFile = rootFile;
        }

        public override async Task<IQueryable<Project>> QueryFilter()
        {
            var query = _repository.GetAll()
                .Include(x => x.ProjectHasCommunes)
                //.Include(x => x.ConstructionTypes)
                .Include(x => x.Investors)
                .Include(x => x.ProjectGroup)
                .Include(x => x.ProjectStatus)
                .Include(x => x.ProjectType)
                .Include(x => x.Records);

            return query;
        }
        public override async Task<IQueryable<Project>> QueryFilter(FilterProjectDto filter)
        {
            if (!filter.IsDelete.HasValue)
            {
                filter.IsDelete = false;
            }

            var query = _repository.GetAll()
                .Include(x => x.ProjectHasCommunes).ThenInclude(x => x.Commune.District.Province)
                //.Include(x => x.ConstructionTypes)
                .Include(x => x.Investors)
                .Include(x => x.ProjectGroup)
                .Include(x => x.ProjectStatus)
                .Include(x => x.ProjectType)
                .Include(x => x.Records)
                .WhereIf(filter.IsDelete.HasValue, x => x.IsDelete == filter.IsDelete)
                .WhereIf(filter.CommuneId.HasValue, x => x.ProjectHasCommunes.Any(c => c.CommuneId == filter.CommuneId))
                //.WhereIf(filter.ConstructionTypeId.HasValue, x => x.ConstructionTypeId == filter.ConstructionTypeId)
                .WhereIf(filter.DistrictId.HasValue, x => x.ProjectHasCommunes.Any(c => c.Commune.DistrictId == filter.DistrictId))
                .WhereIf(filter.ProvinceId.HasValue, x =>  x.ProjectHasCommunes.Any(c => c.Commune.District.ProvinceId == filter.ProvinceId))
                .WhereIf(filter.ProjectStatusId.HasValue, x => x.ProjectStatusId == filter.ProjectStatusId)
                .WhereIf(filter.ProjectTypeId.HasValue, x => x.ProjectTypeId == filter.ProjectTypeId)
                .WhereIf(!string.IsNullOrEmpty(filter.Keyword), x => x.Name.ToLower().Contains(filter.Keyword.ToLower()) || x.Investors.Name.ToLower().Contains(filter.Keyword.ToLower()))
                .Where(x => !x.IsDelete);

            var SortBy = filter.Sorting;

            if (!string.IsNullOrEmpty(SortBy))
            {
                var SortOrder = SortBy.Substring(SortBy.IndexOf(" "));
                SortBy = SortBy.Substring(0, SortBy.IndexOf(" ")).Trim();
                switch (SortBy)
                {
                    case "ProjectTypeName":
                        SortBy = "ProjectType.Name " + SortOrder;
                        break;
                    case "ProjectGroupName":
                        SortBy = "ProjectGroup.Name " + SortOrder;
                        break;
                    case "ProjectStatusName":
                        SortBy = "ProjectStatus.Name " + SortOrder;
                        break;
                    case "ConstructionTypeName":
                        SortBy = "ConstructionTypes.Name " + SortOrder;
                        break;
                    default:
                        SortBy = filter.Sorting;
                        break;
                }
            }
            else SortBy = "ModifiedDate Desc";

            if (!string.IsNullOrEmpty(SortBy))
                query = query.Sort(SortBy);
            return await Task.FromResult(query);
        }

        public override async Task<ProjectDto> GetById(long id, params Expression<Func<Project, object>>[] includes)
        {
            var receiveTypeDict = await _receiveType.GetAll().ToDictionaryAsync(c => c.Id, c => c.Name);
            var recordStatusDict = await _recordStatus.GetAll().ToDictionaryAsync(c => c.Id, c => c.Name);
            var recordTypeDict = await _recordType.GetAll().ToDictionaryAsync(c => c.Id, c => c.Name);
            var responses = await base.GetById(id, x => x.Investors.Commune.District.Province,
                                                  x => x.ProjectGroup,
                                                  x => x.ProjectStatus,
                                                  x => x.ProjectType,
                                                  x => x.Records,
                                                  x => x.Records,
                                                  x => x.ProjectStatus,
                                                  x => x.ProjectHasCommunes);

            var communeInfo = (responses.ProjectHasCommuneId != null && responses.ProjectHasCommuneId.Any()) ? (await _communeRepo.GetCommuneByIds(responses.ProjectHasCommuneId)).Select(x => new Positions()
            {
                Commune = new PositionKeyValue()
                {
                    Id = x.Id,
                    Value = x.Name   
                },
                District = new PositionKeyValue()
                {
                    Id = x.DistrictId,
                    Value = x.GetDistrictName()
                },
                Province = new PositionKeyValue()
                {
                    Id = x.District.ProvinceId,
                    Value = x.District.GetProvinceName()
                }
            }): null;
            foreach (var record in responses.Records)
            {
                record.ReceiveTypeName = receiveTypeDict.TryGetValue(record.ReceiveTypeId ?? 0, out var receiveName) ? receiveName : "";
                record.RecordsStatuName = recordStatusDict.TryGetValue(record.RecordsStatusId ?? 0, out var recordStatusName) ? recordStatusName : "";
                record.RecordsTypeName = recordTypeDict.TryGetValue(record.RecordsTypeId ?? 0, out var recordsTypeName) ? recordsTypeName : "";
            }
            responses.Positions = communeInfo.ToList();
            return responses;
        }

        public async Task<ResponseItem<bool>> UpdateStatus(long id, long statusId)
        {
            if (id == 0 || statusId == 0)
            {
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = "Không tìm thấy dự án hoặc status để cập nhật",
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };
            }
            /// check exist status in db
            var isStatus = _projectStatusRepo.Find(c => c.Id == statusId);
            if (isStatus == null)
            {
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = "Trạng thái không tồn tại",
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };
            }

            ///find proj in db
            var proj = _repository.Find(c => c.Id == id);
            if (proj == null)
            {
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = "Dự án không tồn tại",
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };

            }

            proj.ProjectStatusId = statusId;
            _repository.Update(proj);
            await _unitOfWork.CompleteAsync();
            return new ResponseItem<bool>
            {
                Result = true
            };
        }

        public async Task<byte[]> Export(FilterProjectDto filter, string fileExtention)
        {
            if (!FileExtentions.FileExtention.Contains(fileExtention))
            {
                _logger.LogError("Format file không hợp lệ", fileExtention);
                return null;
            }
            var dataExport = await (await QueryFilter(filter)).ToListAsync();

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(_rootFile.FileNameProjectTemplate)))
            {
                if (!dataExport.Any()) return excelPackage.GetAsByteArray();
                int index = 4;
                int rowNum = 1;
                var workSheet = excelPackage.Workbook.Worksheets["congtrinh"];
                foreach (var project in dataExport)
                {
                    if (project == null) continue;
                    // write header data for each construction order
                    workSheet.Cells[index, 1].Value = rowNum;
                    workSheet.Cells[index, 2].Value = project.Name;
                    workSheet.Cells[index, 3].Value = project.Investors.Name;
                    workSheet.Cells[index, 4].Value = MappingAddressDetail(project);
                    workSheet.Cells[index, 5].Value = project?.ProjectType?.Name;
                    workSheet.Cells[index, 6].Value = project?.ProjectStatus?.Name;
                    index++;
                    rowNum++;
                }
                workSheet.Cells[workSheet.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.General;
                workSheet.Cells[workSheet.Dimension.Address].Style.VerticalAlignment = ExcelVerticalAlignment.Bottom;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[$"B2:B{index}"].AutoFitColumns();
                workSheet.Cells[$"C2:C{index}"].AutoFitColumns();
                workSheet.Cells[$"D2:D{index}"].AutoFitColumns();
                workSheet.Cells[$"E2:E{index}"].AutoFitColumns();
                workSheet.Cells[$"F2:F{index}"].AutoFitColumns();

                if (fileExtention.Equals("PDF", StringComparison.OrdinalIgnoreCase))
                {
                    return await Task.FromResult(SaveAsPdf(new MemoryStream(excelPackage.GetAsByteArray())));
                }
                return await Task.FromResult(excelPackage.GetAsByteArray());
            }
        }

        private byte[] SaveAsPdf(MemoryStream stream)
        {
            if (stream == null)
            {
                _logger.LogWarning("Stream không thể là null");
                return stream.ToArray();
            }
            var workbook = new Aspose.Cells.Workbook(stream);
            var worksheet = workbook.Worksheets[0];
            // Setting the number of pages to which the length of the worksheet will be spanned
            worksheet.PageSetup.FitToPagesTall = 1;
            worksheet.PageSetup.FitToPagesWide = 1;
            worksheet.AutoFitRows();
            Aspose.Cells.PageSetup pageSetup = worksheet.PageSetup;
            // Check for license and apply if exists
            // Setting current date and current time at the centeral section of the header
            // and changing the font of the header
            pageSetup.SetHeader(1, "&\"Times New Roman,Bold\"Công trình");
            pageSetup.Orientation = PageOrientationType.Landscape;
            pageSetup.PaperSize = PaperSizeType.PaperA4;
            pageSetup.CenterHorizontally = true;

            // Setting the number of pages to which t
            //Convert to bytes array
            MemoryStream memorystream = new MemoryStream();
            workbook.Save(memorystream, SaveFormat.Pdf);
            //Get bytes
            var bytes = memorystream.ToArray();
            memorystream.Dispose();
            memorystream.Close();

            return bytes;
        }

        private string MappingAddressDetail(Project project)
        {
            var projectHas = project.ProjectHasCommunes.ToList();
            var addr = new List<string>();
            if (projectHas.Any())
            {
                projectHas.ForEach(x =>
               {
                   string[] addressDetailArray = new string[]
                   {
                       x?.Commune?.Name,
                       x?.Commune?.GetDistrictName(),
                       x?.Commune?.District.GetProvinceName()
                   };
                   if (addressDetailArray.Any())
                   {
                       addr.Add(string.Join(", ", addressDetailArray.Where(c => !string.IsNullOrEmpty(c))));
                   }
               });
            }
             return string.Join("/ ", addr);
        }

        public Dictionary<string, long> GetProjectDictionary(List<string> projectName)
        {
            return _repository.GetAll().Where(x => projectName.Contains(x.Name)).ToDictionary(x => x.Name, x => x.Id);
        }

        public async Task<ResponseItem<bool>> CreateProject(CreateProjectDto request, string createUser)
        {
            try
            {
                if (request == null)
                {
                    return new ResponseItem<bool>
                    {
                        Result = false,
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.RequestInvalid,
                            ErrorType = ErrorTypeConstant.InvalidRequest
                        },
                    };
                }
                var result = await base.CreateReturnId(request);

                if (result == null)
                {
                    return new ResponseItem<bool>
                    {
                        Result = false,
                        Err = 2,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = StringMessage.ErrorMessages.DataWrong,
                            ErrorType = ErrorTypeConstant.InvalidRequest
                        },
                    };
                }
                await _unitOfWork.CompleteAsync();

                var projectHasCommune = new List<ProjectHasCommune>();
                if (request.CommuneIds != null && request.CommuneIds.Any())
                {
                    request.CommuneIds.ForEach(x => projectHasCommune.Add(new ProjectHasCommune()
                    {
                        CommuneId = x,
                        ProjectId = result,
                        CreatedBy = createUser,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = createUser,
                        ModifiedDate = DateTime.Now
                    }));
                }

                _projectHasCommuneRepo.InsertMulti(projectHasCommune);
                _logger.LogInformation($"Tạo mới thành công InvestorId = {result}");
                await _unitOfWork.CompleteAsync();

                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(StringMessage.ErrorMessages.ProcessError, ex);
                return new ResponseItem<bool>
                {
                    Result = false,
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.InvalidRequest
                    },
                };
            }
        }

        public async Task<ResponseItem<bool>> UpdateProject(UpdateProjectDto request, string createUser)
        {
            try
            {
                await base.Update(request);
                var projectHasCommunes = _projectHasCommuneRepo.GetAll().Where(x => x.ProjectId == request.Id).ToList();
                _projectHasCommuneRepo.DeleteMulti(projectHasCommunes);
                await _unitOfWork.CompleteAsync();
                
                var projectHasCommune = new List<ProjectHasCommune>();
                if (request.CommuneIds != null && request.CommuneIds.Any())
                {
                    request.CommuneIds.ForEach(x => projectHasCommune.Add(new ProjectHasCommune()
                    {
                        CommuneId = x,
                        ProjectId = request.Id,
                        CreatedBy = createUser,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = createUser,
                        ModifiedDate = DateTime.Now
                    }));
                }

                _projectHasCommuneRepo.InsertMulti(projectHasCommune);
                _logger.LogInformation($"Cập nhật project thành công = {request.Id}");
                await _unitOfWork.CompleteAsync();

                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(StringMessage.ErrorMessages.ProcessError, ex);
                return new ResponseItem<bool>
                {
                    Result = false,
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ProcessError,
                        ErrorType = ErrorTypeConstant.InvalidRequest
                    },
                };
            }
        }

    }
}
