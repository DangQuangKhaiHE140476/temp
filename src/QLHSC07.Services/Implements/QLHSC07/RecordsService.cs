using Aspose.Cells;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QLHSC07.CORE;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using QLHSC07.Model.QLHSC07_Dtos.RecordsFiles;
using QLHSC07.Model.User;
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
    public class RecordsService : BaseService<long, Records, RecordsDto, RecordsDto, CreateRecordsDto, UpdateRecordsDto, FilterRecordsDto>, IRecordsService
    {
        private readonly RootFile _rootFile;
        private readonly IRepository<RecordsFile, long> _recordsFile;
        private readonly IRepository<RecordsStatus, long> _recordsStatusRepo;
        private readonly IRepository<Project, long> _projectRepo;
        private readonly IRepository<PC07Local, long> _pcLocal07;
        private readonly IRepository<Flatline, long> _flatlineRepo;
        private readonly IRepository<ProjectHasCommune, long> _projectHasCummnuneRepo;
        private readonly ICommuneService _communeService;
        private readonly IDocumentUploadService _iDocumentUploadService;
        private readonly IFileService _fileService;

        public RecordsService(IRepository<Records, long> repository, IMapper mapper, ILogger<RecordsService> logger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, IRepository<RecordsFile, long> recordsFile,
            IDocumentUploadService iDocumentUploadService, IFileService fileService, IRepository<Project, long> projectRepo,
            IRepository<RecordsStatus, long> recordsStatusRepo, RootFile rootFile, IRepository<PC07Local, long> pcLocal07, ICommuneService communeService,
            IRepository<Flatline, long> flatlineRepo, IRepository<ProjectHasCommune, long> projectHasCommuneRepo) : base(repository, mapper, logger, unitOfWork, httpContextAccessor, userManager)
        {
            _recordsFile = recordsFile;
            _iDocumentUploadService = iDocumentUploadService;
            _recordsStatusRepo = recordsStatusRepo;
            _fileService = fileService;
            _projectRepo = projectRepo;
            _pcLocal07 = pcLocal07;
            _flatlineRepo = flatlineRepo;
            _communeService = communeService;
            _projectHasCummnuneRepo = projectHasCommuneRepo;
            _rootFile = rootFile;
        }


        public override async Task<IPagedList<RecordsDto>> GetAll(FilterRecordsDto filter)
        {
            try
            {
                if (filter.PageIndex == 0) filter.PageIndex = Constant.DefaultPageIndex;
                if (filter.PageSize == 0) filter.PageSize = Constant.DefaultPageSize;
                var query = (await QueryFilter(filter));
                var response = query.ToPagedList(filter.PageIndex, filter.PageSize);
                var result = response.Map<RecordsDto, Records>(_mapper);
                if (result.Items.Any())
                {
                    result.Items.ToList().ForEach(
                        x => x.ProjectsAddress = string.IsNullOrEmpty(x.ProjectsAddress) ? ConcatAddressPositionString(x.Positions) : x.ProjectsAddress);
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return null;
            }
        }

        public override async Task<IQueryable<Records>> QueryFilter()
        {
            var query = _repository.GetAll()
                .Include(x => x.Projects.ProjectGroup)
                .Include(x => x.Projects.ProjectStatus)
                .Include(x => x.Projects.ProjectType)
                .Include(x => x.Projects.Investors)
                .Include(x => x.Projects.ProjectHasCommunes)
                .Include(x => x.RecordsStatus)
                .Include(x => x.RecordsTypes)
                .Include(x => x.ReceiveTypes)
                .Include(x => x.PC07Receive)
                .Include(x => x.PC07Manage.Province)
                .Include(x => x.DocumentAnsType)
                .Include(x => x.RecordsFiles).ThenInclude(c => c.DocumentUpload)
                .Include(x => x.RecordsFiles).ThenInclude(c => c.FileTypeAttachment)
                .Where(x => !x.IsDelete);

            return query;
        }
        public override async Task<IQueryable<Records>> QueryFilter(FilterRecordsDto filter)
        {
            if (!filter.IsDelete.HasValue)
            {
                filter.IsDelete = false;
            }
            List<long> projectIds=new List<long>();
            if (filter.ProvinceId.HasValue)
                projectIds = _projectHasCummnuneRepo.GetAll().Include(x => x.Commune.District).Where(x => x.Commune.District.ProvinceId == filter.ProvinceId).Select(x => x.ProjectId).ToList();
            
            var query = _repository.GetAll()
                .Include(x => x.Projects.ProjectGroup)
                .Include(x => x.Projects.ProjectStatus)
                .Include(x => x.Projects.ProjectType)
                .Include(x => x.Projects.Investors)
                .Include(x => x.Projects.ProjectHasCommunes).ThenInclude(x => x.Commune.District.Province)
                //.Include(x => x.Projects.Commune.District.Province)
                .Include(x => x.RecordsStatus)
                .Include(x => x.RecordsTypes)
                .Include(x => x.ReceiveTypes)
                .Include(x => x.PC07Receive)
                .Include(x => x.PC07Manage.Province)
                .Include(x => x.DocumentAnsType)
                .Include(x => x.RecordsFiles).ThenInclude(c => c.DocumentUpload)
                .Include(x => x.RecordsFiles).ThenInclude(c => c.FileTypeAttachment)
                .WhereIf(filter.ProjectId.HasValue, x => x.ProjectId == filter.ProjectId)
                .WhereIf(filter.IsDelete.HasValue, x => x.IsDelete == filter.IsDelete)
                .WhereIf(filter.RecordsTypeId.HasValue, x => x.RecordsTypeId == filter.RecordsTypeId)
                .WhereIf(!string.IsNullOrEmpty(filter.ReceiveUserName), x => x.ReceiveUserName == filter.ReceiveUserName)
                .WhereIf(filter.PC07ReceiveId.HasValue, x => x.PC07ReceiveId == filter.PC07ReceiveId)
                .WhereIf(filter.PC07ManageId.HasValue, x => x.PC07ManageId == filter.PC07ManageId)
                .WhereIf(filter.FromDate.HasValue, x => x.ReceiveDate >= filter.FromDate)
                .WhereIf(filter.ToDate.HasValue, x => x.ReceiveDate <= filter.ToDate)
                .WhereIf(filter.RecordsStatusId.HasValue, x => x.RecordsStatusId == filter.RecordsStatusId)
                .WhereIf(filter.DocumentAnsTypeId.HasValue, x => x.DocumentAnsTypeId == filter.DocumentAnsTypeId)
                //.WhereIf(filter.ProvinceId.HasValue, x => x.PC07Manage.ProvinceId == filter.ProvinceId)
                .WhereIf(filter.ProvinceId.HasValue, x => projectIds.Contains(x.ProjectId.Value))
                .WhereIf(!string.IsNullOrEmpty(filter.ProjectName), x => x.Projects.Name.ToLower().Contains(filter.ProjectName.ToLower()))
                .WhereIf(filter.IsNewProject.HasValue, x => x.IsNewProject == filter.IsNewProject)
                .WhereIf(!string.IsNullOrEmpty(filter.Keyword), x => x.RecordNum.ToLower().Contains(filter.Keyword) 
                            || x.ReturnDocNumb.ToLower().Contains(filter.Keyword.ToLower())
                            || x.Projects.Name.ToLower().Contains(filter.Keyword.ToLower())
                            || x.Projects.Investors.Name.ToLower().Contains(filter.Keyword.ToLower()))
                .WhereIf(filter.ProjectTypeId.HasValue, x=>x.Projects.ProjectTypeId==filter.ProjectTypeId)
                .Where(x => (!x.IsDelete));

            var SortBy = filter.Sorting;

            if (!string.IsNullOrEmpty(SortBy))
            {
                var SortOrder = SortBy.Substring(SortBy.IndexOf(" "));
                SortBy = SortBy.Substring(0, SortBy.IndexOf(" ")).Trim();
                switch (SortBy)
                {
                    case "ProjectsName":
                        SortBy = "Projects.Name " + SortOrder;
                        break;
                    case "RecordsStatusName":
                        SortBy = "RecordsStatus.Name " + SortOrder;
                        break;
                    case "RecordsTypesName":
                        SortBy = "RecordsTypes.Name " + SortOrder;
                        break;
                    case "ReceiveTypesName":
                        SortBy = "ReceiveTypes.Name " + SortOrder;
                        break;
                    case "PC07ReceiveName":
                        SortBy = "PC07Receive.Name " + SortOrder;
                        break;
                    case "PC07ManageName":
                        SortBy = "PC07Manage.Name " + SortOrder;
                        break;
                    default:
                        SortBy = filter.Sorting;
                        break;
                }
            }
            else SortBy = "ModifiedDate Desc";

            if (!string.IsNullOrEmpty(SortBy))
                query = query.Sort(SortBy);
            return query;
            //return await Task.FromResult(query);
        }

        public override async Task<RecordsDto> GetById(long id, params Expression<Func<Records, object>>[] includes)
        {
            if (includes == null || includes.Length == 0)
            {
                var response = await base.GetById(id, x => x.Projects.ProjectGroup,
                x => x.Projects.ProjectStatus,
                x => x.Projects.ProjectType,
                x => x.Projects.Investors,
                x => x.Projects.ProjectHasCommunes,
                x => x.RecordsStatus,
                x => x.RecordsTypes,
                x => x.ReceiveTypes,
                x => x.PC07Receive,
                x => x.PC07Manage.Province,
                x => x.DocumentAnsType,
                x => x.RecordsFiles);

                if (response == null) return null;

                response.RecordsFiles = _mapper.Map<List<RecordsFile>, List<RecordsFileDto>>(_recordsFile.GetAll().Include(c => c.FileTypeAttachment)
                                        .Include(c => c.DocumentUpload).Where(c => response.RecordsFiles.Select(d => d.Id).Contains(c.Id)).ToList());


                ///get detail for project position
                var communeInfo = (response.ProjectCommuneIds != null && response.ProjectCommuneIds.Any()) ? (await _communeService.GetCommuneByIds(response.ProjectCommuneIds)).Select(x => new Positions()
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
                }) : null;

                response.Positions = communeInfo?.ToList();
                if (string.IsNullOrEmpty(response.ProjectsAddress))
                {
                    response.ProjectsAddress = ConcatAddressPositionString(communeInfo.ToList());
                }
                return response;
            }

            return await base.GetById(id, includes);
        }
        private string ConcatAddressPositionString(List<Positions> positions)
        {
            if (!positions.Any()) return null;
            var addrs = new List<string>();
            var pos = positions.Where(x => x.Commune.Id != 0)
                                    .Select(x => new
                                    {
                                        Comm = x.Commune.Value,
                                        Dist = x.District.Value,
                                        Prov = x.Province.Value
                                    }).ToList();
            if (!pos.Any()) return null;
            pos.ForEach(x => addrs.Add(string.Join(", ", new List<string>() { x.Comm, x.Dist, x.Prov }.Where(x => !string.IsNullOrEmpty(x)))));
            return string.Join(" - ", addrs.ToList());
        }

        public async Task<ResponseItem<bool>> CreateRecord(CreateRecordsDto request,
            string uploadFolderPath,
            CurrentUserDto user)
        {
            using var trans = _unitOfWork.BeginTransaction();
            try
            {
                var proj = await CreateOrUpdateProjectRecord(request.Project, user?.Email);
                if (proj == null)
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = "Thông tin dự án không hợp lệ",
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }
                var recordEntity = await Create(request, proj);
                var fileRecord = await SaveRecordFiles(request.RecordFile, user);
                if (fileRecord != null)
                {
                    recordEntity.RecordsFiles = fileRecord;
                }

                recordEntity.Projects = proj.Projects;
                recordEntity.IsNewProject = proj.IsNewProject;
                await _repository.InsertAsync(recordEntity);
                await _unitOfWork.CompleteAsync();

                ///insert project has commune
                var projectHasCommune = new List<ProjectHasCommune>();
                if (request.Project?.CommuneIds != null && request.Project.CommuneIds.Any())
                {
                    request.Project.CommuneIds.ForEach(x => projectHasCommune.Add(new ProjectHasCommune()
                    {
                        CommuneId = x,
                        ProjectId = proj.Projects.Id,
                        CreatedBy = user.UserName,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = user.UserName,
                        ModifiedDate = DateTime.Now
                    }));
                }

                _projectHasCummnuneRepo.InsertMulti(projectHasCommune);
                ///save to flatline
                await _unitOfWork.CompleteAsync();
                await SaveToFlatline(recordEntity, user?.Email, ModifyEnum.INSERT.ToString());
                await trans.CommitAsync();
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Đã xảy ra lỗi trog quá trình xử lý", ex);
                await trans.RollbackAsync();
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = "Đã xảy ra lỗi trog quá trình xử lý",
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };
            }
        }

        public async Task<ResponseItem<bool>> UpdateRecord(UpdateRecordsDto request,
            string uploadFolderPath,
            CurrentUserDto user)
        {
            var record = _repository.GetAll().FirstOrDefault(c => !c.IsDelete && c.Id == request.Id);
            if (record == null)
            {
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = "Không tìm thấy hồ sơ này",
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };
            }
            using var trans = _unitOfWork.BeginTransaction();
            try
            {
                var files = await _recordsFile.GetAll().Where(c => c.RecordsId == record.Id).ToListAsync();
                if (files.Any())
                {
                    _recordsFile.DeleteMulti(files);
                }

                var proj = await CreateOrUpdateProjectRecord(request.Project, user.Email);
                if (proj == null)
                {
                    return new ResponseItem<bool>
                    {
                        Err = 1,
                        ResponseError = new ResponseErrorData
                        {
                            ErrorMessage = "Thông tin dự án không hợp lệ",
                            ErrorType = ErrorTypeConstant.ErrorProcess
                        },
                        Result = false
                    };
                }

                var recordEntity = _mapper.Map<UpdateRecordsDto, Records>(request, record);
                var fileDict = await SaveRecordFiles(request.RecordFile, user);
                recordEntity.Projects = proj.Projects;
                recordEntity.RecordsFiles = fileDict;
                recordEntity.IsNewProject = proj.IsNewProject;
                _repository.Update(recordEntity);

                ///add project has commune
                if (proj?.IsNewProject == true)
                {
                    var projectHasCommunes = _projectHasCummnuneRepo.GetAll().Where(x => x.ProjectId == request.Id).ToList();
                    _projectHasCummnuneRepo.DeleteMulti(projectHasCommunes);
                    await _unitOfWork.CompleteAsync();

                    var projectHasCommune = new List<ProjectHasCommune>();
                    if (request.Project?.CommuneIds != null && request.Project.CommuneIds.Any())
                    {
                        request.Project.CommuneIds.ForEach(x => projectHasCommune.Add(new ProjectHasCommune()
                        {
                            CommuneId = x,
                            ProjectId = proj.Projects.Id,
                            CreatedBy = user.UserName,
                            CreatedDate = DateTime.Now,
                            ModifiedBy = user.UserName,
                            ModifiedDate = DateTime.Now
                        }));
                    }
                    _projectHasCummnuneRepo.InsertMulti(projectHasCommune);
                }

                ///save to flatline
                await SaveToFlatline(recordEntity, user?.Email, ModifyEnum.UPDATE.ToString());
                await _unitOfWork.CompleteAsync();
                await trans.CommitAsync();
                return new ResponseItem<bool>
                {
                    Result = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Đã xảy ra lỗi trog quá trình xử lý", ex);
                await trans.RollbackAsync();
                //await RemoveFileError(fileDict);
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = "Đã xảy ra lỗi trog quá trình xử lý",
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };
            }
        }

        private async Task<Records> Create(CreateRecordsDto request, CreateOrUpdateProjectDto proj)
        {
            var entity = _mapper.Map<Records>(request);
            entity.ProjectId = proj.Projects?.Id;
            var user = GetCurrentUserName();
            if (user == null)
            {
                entity.CreatedBy = "Administrator";
                entity.ModifiedBy = "Administrator";
            }
            else
            {
                entity.CreatedBy = user;
                entity.ModifiedBy = user;
            }
            entity.ModifiedDate = DateTime.Now;
            entity.CreatedDate = DateTime.Now;
            return await Task.FromResult(entity);
        }

        private async Task<List<RecordsFile>> SaveRecordFiles(List<FileAttachmentDto> createRecordFiles,
            CurrentUserDto user)
        {
            ///create record
            var records = new List<RecordsFile>();
            if (createRecordFiles == null) return null;
            foreach (var file in createRecordFiles)
            {
                records.Add(new RecordsFile
                {
                    DocumentUploadId = file.FileId ?? 0,
                    FileTypeAttachmentId = file.FileTypeAttachmentId,
                    CreatedBy = user?.Email ?? "NA",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }
            return await Task.FromResult(records);
        }

        private async Task<CreateOrUpdateProjectDto> CreateOrUpdateProjectRecord(CreateProjectDto project, string userName)
        {
            if (project == null) return null;
            if (project.Id != 0)
            {
                var projectEnt = _projectRepo.GetAll().FirstOrDefault(c => c.Id == project.Id);
                if (projectEnt != null)
                {
                    projectEnt.SetValueUpdate(userName);
                    return new CreateOrUpdateProjectDto()
                    {
                        IsNewProject = false,
                        Projects = projectEnt
                    };
                }
            }
            var proj = _mapper.Map<Project>(project);
            if (proj.InvestorId == 0 ||
                proj.ProjectGroupId == 0 ||
                proj.ProjectTypeId == 0)
            {
                return null;
            }
            proj.SetDefaultValue(userName);
            return await Task.FromResult(new CreateOrUpdateProjectDto()
            {
                IsNewProject = true,
                Projects = proj
            });
        }

        public async Task<ResponseItem<bool>> UpdateStatus(UpdateStatusRecordsDto recordsStatus)
        {
            if (recordsStatus.Id == 0 || recordsStatus.StatusId == 0)
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
            var isStatus = _recordsStatusRepo.Find(c => c.Id == recordsStatus.StatusId);
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

            ///find records in db
            var records = _repository.Find(c => c.Id == recordsStatus.Id);
            if (records == null)
            {
                return new ResponseItem<bool>
                {
                    Err = 1,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = "Hồ sơ không tồn tại",
                        ErrorType = ErrorTypeConstant.ErrorProcess
                    },
                    Result = false
                };

            }

            records.RecordsStatusId = recordsStatus.StatusId;
            records.CancelReason = recordsStatus.CancelReason;
            records.DateRealReturn = recordsStatus.DateRealReturn;
            if (recordsStatus.StatusId<3)
            {
                records.Result = null;
                records.DateRealReturn = null;
            }    
            else if (recordsStatus.StatusId == 4)
                records.Result = false;
            else if (recordsStatus.Result.HasValue)
                records.Result = recordsStatus.Result;

            _repository.Update(records);
            await _unitOfWork.CompleteAsync();
            return new ResponseItem<bool>
            {
                Result = true
            };
        }

        public async Task<byte[]> Export(FilterRecordsDto filter, string fileExtention)
        {
            if (!FileExtentions.FileExtention.Contains(fileExtention))
            {
                _logger.LogError("Format file không hợp lệ", fileExtention);
                return null;
            }
            var dataExport = (await QueryFilter(filter)).ToList();
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(_rootFile.FileNameRecordTemplate)))
            {
                if (!dataExport.Any()) return excelPackage.GetAsByteArray();
                int index = 6;
                int rowNum = 1;
                var workSheet = excelPackage.Workbook.Worksheets["Tiepnhanvatraketqua"];
                foreach (var record in dataExport)
                {
                    if (record == null) continue;
                    // write header data for each construction order
                    workSheet.Cells[index, 1].Value = rowNum;
                    workSheet.Cells[index, 2].Value = record.RecordNum;
                    workSheet.Cells[index, 3].Value = record?.Projects?.Name;
                    workSheet.Cells[index, 4].Value = record?.Projects?.Investors?.Name;
                    workSheet.Cells[index, 5].Value = MappingAddressDetail(record);
                    workSheet.Cells[index, 6].Value = record?.RecordsTypes?.Name;
                    workSheet.Cells[index, 7].Value = record?.ReceiveTypes?.Name;
                    workSheet.Cells[index, 8].Value = record.ReceiveDate;
                    workSheet.Cells[index, 9].Value = record.ReceiveUserName;
                    workSheet.Cells[index, 10].Value = record.DatePredictReturn;
                    workSheet.Cells[index, 11].Value = record.ReturnDocNumb;
                    workSheet.Cells[index, 12].Value = record.DatePredictReturn;
                    workSheet.Cells[index, 13].Value = record.DateRealReturn;
                    workSheet.Cells[index, 14].Value = record?.PC07Receive?.Name;
                    index++;
                    rowNum++;
                }
                workSheet.Cells[workSheet.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                workSheet.Cells[$"H6:H{index}"].Style.Numberformat.Format =
                     _rootFile.NumberformatDateTime;
                workSheet.Cells[$"H6:H{index}"].AutoFitColumns();

                workSheet.Cells[$"J6:J{index}"].Style.Numberformat.Format =
                    _rootFile.NumberformatDateTime;
                workSheet.Cells[$"J6:J{index}"].AutoFitColumns();

                workSheet.Cells[$"L6:L{index}"].Style.Numberformat.Format =
                    _rootFile.NumberformatDateTime;
                workSheet.Cells[$"L6:L{index}"].AutoFitColumns();

                workSheet.Cells[$"M6:M{index}"].Style.Numberformat.Format =
                    _rootFile.NumberformatDateTime;
                workSheet.Cells[$"M6:M{index}"].AutoFitColumns();

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
            worksheet.AutoFitRows();
            Aspose.Cells.PageSetup pageSetup = worksheet.PageSetup;
            // Check for license and apply if exists
            // Setting current date and current time at the centeral section of the header
            // and changing the font of the header
            pageSetup.SetHeader(1, "&\"Times New Roman,Bold\"TIẾP NHẬN VÀ TRẢ KẾT QUẢ");
            pageSetup.Orientation = PageOrientationType.Landscape;
            pageSetup.PaperSize = PaperSizeType.PaperA4;
            pageSetup.FitToPagesTall = 1;
            // Setting the number of pages to which t
            //Convert to bytes array
            MemoryStream memorystream = new MemoryStream();
            workbook.Save(memorystream, SaveFormat.Pdf);
            //Get bytes
            byte[] bytes = memorystream.ToArray();
            memorystream.Dispose();
            memorystream.Close();

            return bytes;
        }

        public async Task<IQueryable<ReportRecordDto>> ReportRecordChart(ReportRecordChartFilter filter)
        {
            var defaultFilter = new FilterRecordsDto()
            {
                PageIndex = Constant.DefaultPageIndex,
                PageSize = Constant.DefaultPageSize
            };
            if (filter.Year == 0)
            {
                filter.Year = DateTime.Now.Year;
            }

            var records = (await QueryFilter(defaultFilter)).Where(c => (!filter.RecordTypeId.HasValue || c.RecordsTypeId == filter.RecordTypeId)
                                                             && filter.Year == c.ModifiedDate.Year
                                                             && (!filter.PC07ManageId.HasValue || c.PC07ManageId == filter.PC07ManageId)).ToList()
                                                            .GroupBy(c => c.RecordsTypeId)
                                                            .Select(c => new ReportRecordDto
                                                            {
                                                                RecordTypeId = c.Key,
                                                                RecordSolvedNumber = c.Count(c => c.RecordsStatusId == 3),
                                                                Year = c.FirstOrDefault().ModifiedDate.Year,
                                                                RecordTypeName = c.Select(d => d.RecordsTypes?.Name).FirstOrDefault(),
                                                                TotalRecord = c.Count(),
                                                                ///todo
                                                                ///Nếu ngày hẹn trả lớn hơn hoặc bằng ngày thực thì hợp lệ
                                                                PercentSort = ((decimal)(c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn))) /
                                                                                    ((c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)) + (c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                                                                    || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))))) == 0 ? 1 :
                                                                                    (c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)) + (c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                                                                    || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))))))),

                                                                PercentLate = c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                                                                  || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))),
                                                                PercentOnTime = c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)),
                                                                Percent = ((decimal)(c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn))) /
                                                                                    ((c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)) + (c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                                                                    || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))))) == 0 ? 1 :
                                                                                    (c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)) + (c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                                                                    || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))))))).ToString("0.00%"),
                                                            }).AsQueryable();
            if (!string.IsNullOrEmpty(filter.Sorting))
            {
                records = records.Sort(sortByFields: $"{filter.Sorting}");
            }
            else
            {
                records = records.Sort(sortByFields: "RecordTypeId Asc");
            }

            return records;
        }

        private DateTime? GetNextDate(DateTime? datePredictReturn)
        {
            if (!datePredictReturn.HasValue) return null;
            return new DateTime(datePredictReturn.Value.Year, datePredictReturn.Value.Month, datePredictReturn.Value.Day).AddDays(1);
        }

        private string MappingAddressDetail(Records record)
        {
            var projectHas = record.Projects.ProjectHasCommunes.ToList();
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

        public IQueryable<RecordInfoAtLocalDto> RecordInfoAtLocal(RecordInfoAtLocalFilter filter)
        {
            var result = (from pc in _pcLocal07.GetAll()
                          join re in _repository.GetAll()
                             on pc.Id equals re.PC07ReceiveId into lfpc
                          from lf in lfpc.DefaultIfEmpty()
                          where !filter.PC07ManageId.HasValue || pc.Id == filter.PC07ManageId
                          select new RecordInfoAtLocalPrepairDto
                          {
                              Id = pc.Id,
                              LocalName = pc.Name,
                              RecordsStatusId = lf.RecordsStatusId,
                              DateRealReturn = lf.DateRealReturn,
                              DatePredictReturn = lf.DatePredictReturn,
                              RecordsId = lf.Id
                          }).ToList()
                          .GroupBy(c => c.Id)
                          .Select((c, index) => new RecordInfoAtLocalDto
                          {
                              TotalRecord = c.Count(r => r.RecordsId.HasValue),
                              LocalName = c.Select(x => x.LocalName).FirstOrDefault(),
                              ///id = 3 Hoàn thành
                              RecordSolved = c.Count(x => x.RecordsStatusId == 3),
                              RecordBeforeDeadLine = c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)),
                              RecordOnTime = c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)),
                              RecordOutOfDate = c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                                || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))),
                              ///id = 2     Đang xử lý
                              RecordProcessing = c.Count(x => x.RecordsStatusId == 2),
                              PercenOnTime =  ((decimal)(c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn))) /
                                              ((c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)) + (c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                              || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))))) == 0 ? 1 :
                                              (c.Count(x => x.DateRealReturn < GetNextDate(x.DatePredictReturn)) + (c.Count(x => ((x.DateRealReturn.HasValue && x.DateRealReturn.Value > x.DatePredictReturn)
                                              || (!x.DateRealReturn.HasValue && DateTime.Now > x.DatePredictReturn))))))).ToString("0.00%"),
                          }).AsQueryable();


            if (!string.IsNullOrEmpty(filter.SortBy))
            {
                result = result.Sort(sortByFields: $"{filter.SortBy}");
            }
            else
            {
                result = result.Sort(sortByFields: "LocalName Asc");
            }
            return result;
        }

        public async Task<ResponseItem<bool>> Delete(long id, string user)
        {
            if (id == 0)
            {
                return new ResponseItem<bool>
                {
                    Err = 1,
                    Result = false,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ItemNotFound,
                        ErrorType = ErrorTypeConstant.RecordNotFound
                    }
                };
            }
            var record = _repository.Find(x => x.Id.Equals(id));
            await SaveToFlatline(record, user, ModifyEnum.DELETE.ToString());
            return await base.Delete(id);
        }
        public async Task<ResponseItem<bool>> DeletePermanent(long id, string user)
        {
            if (id == 0)
            {
                return new ResponseItem<bool>
                {
                    Err = 1,
                    Result = false,
                    ResponseError = new ResponseErrorData
                    {
                        ErrorMessage = StringMessage.ErrorMessages.ItemNotFound,
                        ErrorType = ErrorTypeConstant.RecordNotFound
                    }
                };
            }
            var record = _repository.Find(x => x.Id.Equals(id));
            await SaveToFlatline(record, user, ModifyEnum.DELETEPERMANENT.ToString());
            return await base.DeletePermanent(id);
        }

        private async Task SaveToFlatline(Records record, string updateBy, string action)
        {
            var recordIncluded = (await QueryFilter()).FirstOrDefault(x => x.Id == record.Id);
            if (recordIncluded == null)
            {
                _logger.LogWarning("Không có hồ sơ nào để lưu vào flatline");
                return;
            }
            ///get include infor relative to record
            ///find out record to update
            var recordFlatline = _flatlineRepo.Find(c => c.RecordId == record.Id && c.ProjectId == record.ProjectId);
            if (recordFlatline != null)
            {
                if (action == ModifyEnum.UPDATE.ToString())
                {
                    var positions = GetPositions(recordIncluded?.Projects?.ProjectHasCommunes);
                    recordFlatline.ProjectName = recordIncluded?.Projects.Name;
                    recordFlatline.InvestorName = recordIncluded?.Projects?.Investors?.Name;
                    recordFlatline.RecordTypeId = recordIncluded?.RecordsTypeId;
                    recordFlatline.Address = recordIncluded?.Projects?.Address;
                    recordFlatline.Positions = positions.Any() ? Newtonsoft.Json.JsonConvert.SerializeObject(positions) : null;
                    recordFlatline.DatePredictReturn = recordIncluded?.DatePredictReturn;
                    recordFlatline.DateRealReturn = recordIncluded?.DateRealReturn;
                    recordFlatline.IsNewProject = recordIncluded?.IsNewProject;
                    recordFlatline.PC07ReceiveName = recordIncluded?.PC07Receive?.Name;
                    recordFlatline.ProjectTypeId = recordIncluded?.Projects?.ProjectTypeId;
                    recordFlatline.ProjectTypeName = recordIncluded?.Projects?.ProjectType?.Name;
                    recordFlatline.ReturnDocNumb = recordIncluded?.ReturnDocNumb;
                    recordFlatline.ReceiveDate = recordIncluded?.ReceiveDate;
                    recordFlatline.ReceiveUserName = recordIncluded?.ReceiveUserName;
                    recordFlatline.ReceptionForm = recordIncluded?.ReceiveTypes?.Name;
                    recordFlatline.RecordNum = recordIncluded?.RecordNum;
                    recordFlatline.RecordTypeName = recordIncluded?.RecordsTypes?.Name;
                    recordFlatline.GroupProjectId = recordIncluded?.Projects?.ProjectGroupId;
                    recordFlatline.PC07ManageId = recordIncluded?.PC07ManageId;
                    recordFlatline.SetValueUpdate(updateBy);
                    _flatlineRepo.Update(recordFlatline);
                }
                else if (action == ModifyEnum.DELETE.ToString())
                {
                    recordFlatline.SetValueUpdate(updateBy);
                    recordFlatline.IsDelete = true;
                    _flatlineRepo.Update(recordFlatline);
                }
                else
                {
                    _flatlineRepo.Delete(recordFlatline);
                }
            }
            else
            {
                var positions = GetPositions(recordIncluded?.Projects?.ProjectHasCommunes);
                var flatline = new Flatline()
                {
                    RecordId = recordIncluded?.Id,
                    ProjectId = recordIncluded?.ProjectId,
                    ProjectName = recordIncluded?.Projects.Name,
                    InvestorName = recordIncluded?.Projects?.Investors?.Name,
                    RecordTypeId = recordIncluded?.RecordsTypeId,
                    Address = recordIncluded?.Projects?.Address,
                    Positions = positions.Any() ? Newtonsoft.Json.JsonConvert.SerializeObject(positions) : null,
                    DatePredictReturn = recordIncluded?.DatePredictReturn,
                    DateRealReturn = recordIncluded?.DateRealReturn,
                    IsNewProject = recordIncluded?.IsNewProject,
                    PC07ReceiveName = recordIncluded?.PC07Receive?.Name,
                    ProjectTypeId = recordIncluded?.Projects?.ProjectTypeId,
                    ReceiveDate = recordIncluded?.ReceiveDate,
                    ReceiveUserName = recordIncluded?.ReceiveUserName,
                    ReceptionForm = recordIncluded?.ReceiveTypes?.Name,
                    RecordNum = recordIncluded?.RecordNum,
                    RecordTypeName = recordIncluded?.RecordsTypes?.Name,
                    ModifiedDate = DateTime.Now,
                    ProjectTypeName = recordIncluded?.Projects?.ProjectType?.Name,
                    ReturnDocNumb = recordIncluded?.ReturnDocNumb,
                    GroupProjectId = recordIncluded?.Projects?.ProjectGroupId,
                    PC07ManageId = recordIncluded?.PC07ManageId
                };
                flatline.SetDefaultValue(updateBy);
                await _flatlineRepo.InsertAsync(flatline);
                await _unitOfWork.CompleteAsync();
            }
        }

        private List<Positions> GetPositions(ICollection<ProjectHasCommune> projectHasCommunes)
        {
            var positions = new List<Positions>();
            List<ProjectHasCommune> dataCommunes = new List<ProjectHasCommune>(projectHasCommunes);
            dataCommunes.ForEach(x =>
            {
                if (x.CommuneId != 0)
                {
                    var commune = _communeService.GetCommuneById(x.CommuneId);
                    positions.Add(new Positions()
                    {
                        Commune = new PositionKeyValue()
                        {
                            Id = x.CommuneId,
                            Value = commune.Name
                        },
                        District = new PositionKeyValue()
                        {
                            Id = x.Commune?.DistrictId,
                            Value = commune.DistrictName
                        },
                        Province = new PositionKeyValue()
                        {
                            Id = x.Commune?.District?.ProvinceId,
                            Value = commune.ProvinceName
                        }
                    });
                }
            });
            return positions;
            //return positions.Any() ? Newtonsoft.Json.JsonConvert.SerializeObject(positions) : null;
        }

        private async Task<bool> RemoveFileError(Dictionary<long?, string> dict)
        {
            if (dict == null) return false;
            var getKey = dict.Select(c => c.Key);
            var getvalue = dict.Select(c => c.Value);

            ///delete file save at local
            foreach (var item in getvalue)
            {
                _fileService.RemoveFile(item);
            }
            var type = 0;
            var path = "";
            ///delete record file save database
            ///get file
            foreach (var item in getKey)
            {
                _iDocumentUploadService.Delete((long)item, ref type, ref path);
            }
            return true;
        }
    }
}
