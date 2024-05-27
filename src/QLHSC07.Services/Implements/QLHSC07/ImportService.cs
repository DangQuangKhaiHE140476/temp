using Aspose.Cells;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using QLHSC07.CORE.Extensions;
using QLHSC07.CORE.Helper;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.Administrative;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.Import;
using QLHSC07.Model.QLHSC07_Dtos.Investors;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using QLHSC07.Model.QLHSC07_Dtos.Report;
using QLHSC07.Services.Interfaces;
using QLHSC07.Services.Interfaces.QLHSC07;
using QLHSC07.Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static QLHSC07.CORE.Helper.Constant;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class ImportService : IImportService
    {
        private readonly ILogger<ImportService> _logger;
        private readonly IRecordsService _recordsService;
        private readonly IProvinceService _provinceService;
        private readonly IRepository<ProjectGroup, long> _projectGroupRepo;
        private readonly IRepository<HistoryImportLog, long> _historyImportLogRepo;
        private readonly ICommuneService _communeService;
        private readonly IDistrictService _districtService;
        private readonly IInvestorService _investorService;
        private readonly IProjectService _projectService;

        public ImportService(ILogger<ImportService> logger,
            IRecordsService recordsService,
            IProvinceService provinceService,
            ICommuneService communeService,
            IDistrictService districtService,
            IInvestorService investorService,
            IProjectService projectService,
             IRepository<HistoryImportLog, long> historyImportLogRepo,
            IRepository<ProjectGroup, long> projectGroupRepo)
        {
            _logger = logger;
            _recordsService = recordsService;
            _provinceService = provinceService;
            _projectGroupRepo = projectGroupRepo;
            _communeService = communeService;
            _districtService = districtService;
            _investorService = investorService;
            _projectService = projectService;
            _historyImportLogRepo = historyImportLogRepo;
        }

        public async Task<List<ValidateImportDto>> Import(IFormFile formFile)
        {
            var stream = formFile.OpenReadStream();
            var recordDatas = new List<ImportRecordsDto>();
            var validateDatas = new List<ValidateImportDto>();
            /// start handle file
            using (ExcelPackage package = new ExcelPackage(stream))
            {
                //get the first worksheet in the workbook
                var sheetNames = package.Workbook.Worksheets.Select(x => x.Name);
                foreach (var sheetName in sheetNames)
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];
                    int totalRows = worksheet.Dimension.Rows;

                    for (int i = 6; i <= totalRows; i++)
                    {
                        recordDatas.Add(new ImportRecordsDto
                        {
                            RowReal = i.ToString(),
                            RowNumber = worksheet.Cells[i, 1].Value == null ? "" : worksheet.Cells[i, 1].Value.ToString(),
                            ProjectName = worksheet.Cells[i, 2].Value == null ? "" : worksheet.Cells[i, 2].Value.ToString(),
                            Address = worksheet.Cells[i, 3].Value == null ? "" : worksheet.Cells[i, 3].Value.ToString(),
                            Province = worksheet.Cells[i, 4].Value == null ? "" : worksheet.Cells[i, 4].Value.ToString(),
                            InvestorName = worksheet.Cells[i, 5].Value == null ? "" : worksheet.Cells[i, 5].Value.ToString(),
                            ScaleProject = worksheet.Cells[i, 6].Value == null ? "" : worksheet.Cells[i, 6].Value.ToString(),
                            ProjectType = worksheet.Cells[i, 7].Value == null ? "" : worksheet.Cells[i, 7].Value.ToString(),
                            ProjectGroup = worksheet.Cells[i, 8].Value == null ? "" : worksheet.Cells[i, 8].Value.ToString(),
                            ProjectLevel = worksheet.Cells[i, 9].Value == null ? "" : worksheet.Cells[i, 9].Value.ToString(),
                            TextNumberTD = worksheet.Cells[i, 10].Value == null ? "" : worksheet.Cells[i, 10].Value.ToString(),
                            TextTimeTD = worksheet.Cells[i, 11].Value == null ? "" : worksheet.Cells[i, 11].Value.ToString(),
                            TextTypeDescriptionTD = worksheet.Cells[i, 12].Value == null ? "" : worksheet.Cells[i, 12].Value.ToString(),
                            TextNumberNT = worksheet.Cells[i, 13].Value == null ? "" : worksheet.Cells[i, 13].Value.ToString(),
                            TextTimeNT = worksheet.Cells[i, 14].Value == null ? "" : worksheet.Cells[i, 14].Value.ToString(),
                            TextTypeDescriptionNT = worksheet.Cells[i, 15].Value == null ? "" : worksheet.Cells[i, 15].Value.ToString(),
                            Description = worksheet.Cells[i, 16].Value == null ? "" : worksheet.Cells[i, 16].Value.ToString(),
                            UserAccept = worksheet.Cells[i, 17].Value == null ? "" : worksheet.Cells[i, 17].Value.ToString(),
                        });
                    }
                    _logger.LogInformation($"{worksheet.Name}: {recordDatas.Count}");
                    validateDatas.AddRange(await ImportRecordFile(recordDatas, formFile.FileName, worksheet.Name));
                    recordDatas.Clear();
                }
            }
            return validateDatas;
        }

        public async Task<List<ValidateImportDto>> ImportRecordFile(List<ImportRecordsDto> records, string fileName, string sheetName)
        {
            if (!records.Any())
            {
                _logger.LogWarning("Không có gì để import vào database");
                return null;
            }
            var validateData = await ValidateData(records, fileName, sheetName);
            var validData = validateData.Where(c => c.IsValid).Select(c => c.Record).ToList();

            foreach (var item in validData)
            {                          
                if (!string.IsNullOrEmpty(item.TextNumberNT))
                {
                    await _recordsService.CreateRecord(new CreateRecordsDto
                    {
                        RecordNum = item.TextNumberNT,
                        DatePredictCheck = DateTime.TryParse(item.TextTimeNT, out var datePredictCheck) ? datePredictCheck : (DateTime?)null,
                        DateRealReturn = DateTime.TryParse(item.TextTimeNT, out var dateRealReturn) ? dateRealReturn : (DateTime?)null,
                        ReceiveDate = DateTime.TryParse(item.TextTimeNT, out var receiveDate) ? receiveDate : (DateTime?)null,
                        Project = new CreateProjectDto()
                        {
                            Id = item.ProjectId
                        },
                        ///set default value tổng cục
                        PC07ManageId = 1
                    }, null, new Model.User.CurrentUserDto() { Email = "System" });
                }

                if (!string.IsNullOrEmpty(item.TextNumberTD))
                {
                    await _recordsService.CreateRecord(new CreateRecordsDto
                    {
                        RecordNum = item.TextNumberTD,
                        DatePredictCheck = DateTime.TryParse(item.TextTimeTD, out var datePredictCheck) ? datePredictCheck : (DateTime?)null,
                        DateRealReturn = DateTime.TryParse(item.TextTimeTD, out var dateRealReturn) ? dateRealReturn : (DateTime?)null,
                        ReceiveDate = DateTime.TryParse(item.TextTimeTD, out var receiveDate) ? receiveDate : (DateTime?)null,
                        Project = new CreateProjectDto()
                        {
                            Id = item.ProjectId
                        },
                        ///set default value tổng cục
                        PC07ManageId = 1,
                    }, null, new Model.User.CurrentUserDto() { Email = "System" });
                }
            }
            return validateData;
        }

        private async Task<List<ValidateImportDto>> ValidateData(List<ImportRecordsDto> records, string fileName, string sheetName)
        {
            var provinceInFile = records.Where(x => !string.IsNullOrEmpty(x.Province)).Select(c => c.Province.ToLower().Trim()).Distinct().ToList();
            var provincesDict = _provinceService.GetProvinceWithFirstCommuneAndDistrict(provinceInFile);

            var projectGroupInFile = records.Where(x => !string.IsNullOrEmpty(x.ProjectGroup)).Select(c => c.ProjectGroup.ToLower()).Distinct();
            var projectGroupDict = _projectGroupRepo.GetAll().Where(x => projectGroupInFile.Contains(x.Name.ToLower()))
                                .ToDictionary(x => x.Name, x => x.Id);

            var investorNames = records.Select(x => $"{x.InvestorName.ToLower()}-{x.Address.ToLower()}").Distinct().ToList();
            
            var comparer = StringComparer.OrdinalIgnoreCase;
            var investorCreatedDict = new Dictionary<string, long>(comparer);

            var investorDict = _investorService.GetInvestorAndAddress().Where(c => investorNames.Contains($"{c.Name.ToLower()}-{c.Address.ToLower()}"))
                               .ToDictionary(x => $"{x.Name.ToLower()}-{x.Address.ToLower()}", x => x.Id);

            var projectNames = records.Select(x => x.ProjectName).Distinct().ToList();
            var projectDict = _projectService.GetProjectDictionary(projectNames);
            var projectNamesInFileDict = new Dictionary<string, long>(comparer);
            var validateRecords = records.Select(c => new ValidateImportDto
            {
                IsValid = true,
                Record = c
            }).ToList();

            foreach (var record in validateRecords)
            {
                var errors = new List<HistoryImportDetailDto>();
                var unisignProvince = UtilHelper.ConvertToUnSign(string.IsNullOrEmpty(record.Record.Province) ? "" : record.Record.Province.Trim());
                record.Record.ProvinceId = provincesDict.TryGetValue(unisignProvince, out var provinceInfo) ? provinceInfo.Id : 0;
                record.Record.GroupProjectId = projectGroupDict.TryGetValue(record.Record.ProjectGroup, out var projectGroupId) ? projectGroupId : 0;
                ///check exists province
                if (record.Record.ProvinceId == 0)
                {
                    record.Record.CommuneId = 25822;
                    record.Record.DistrictId = 711;
                    errors.Add(new HistoryImportDetailDto
                    {
                        FileName = fileName,
                        SheetName = sheetName,
                        Row = record?.Record?.RowNumber,
                        RawData = record.Record.GetRawData(),
                        Description = $"Tỉnh này không tồn tại {record?.Record?.Province}"
                    });
                    record.IsValid = false;
                    _logger.LogWarning($"Tỉnh này không tồn tại {record?.Record?.Province}");
                }
                else
                {
                    if (provinceInfo.CommuneId == 0)
                    {
                        ///attach to undefine
                        provinceInfo.CommuneId = 25822;
                    }
                    if (provinceInfo.DistrictId == 0)
                    {
                        ///attach to undefine
                        provinceInfo.DistrictId = 711;
                    }
                    record.Record.CommuneId = provinceInfo.CommuneId;
                    record.Record.DistrictId = provinceInfo.DistrictId;
                }

                /////check exists group project
                if (record.Record.GroupProjectId == 0)
                {
                    ///attach to undefine
                    record.Record.GroupProjectId = 5;
                    //errors.Add(new HistoryImportDetailDto
                    //{
                    //    FileName = fileName,
                    //    SheetName = sheetName,
                    //    Row = record?.Record?.RowNumber,
                    //    RawData = record.Record.GetRawData(),
                    //    Description = $"Không có nhóm dự án này {record?.Record?.ProjectGroup}"
                    //});
                }

                ///check for investor
                //if (record.IsValid)
                if (true)
                {
                    var investorKey = $"{record.Record.InvestorName.ToLower()}-{record.Record.Address.ToLower()}";
                    var isInvestorValid = investorDict.TryGetValue(investorKey, out var investorId);
                    if (isInvestorValid)
                    {
                        record.Record.InvestorId = investorId;
                    }
                    else
                    {
                        ///check is create new?
                        var isCreateInvestorNew = investorCreatedDict.TryGetValue(investorKey, out var id);
                        if (isCreateInvestorNew)
                        {
                            record.Record.InvestorId = id;
                        }
                        else
                        {
                            var investor = new CreateInvestorDto()
                            {
                                //todo
                                CommuneId = record.Record.CommuneId,
                                DistrictId = record.Record.DistrictId,
                                ProvinceId = record.Record.ProvinceId,
                                Address = record.Record.Address,
                                Name = record.Record.InvestorName
                            };
                            record.Record.InvestorId = await _investorService.CreateReturnId(investor);
                            investorCreatedDict.Add(investorKey, record.Record.InvestorId);
                        }
                    }

                    ///check project
                    var isProject = projectDict.TryGetValue(record.Record.ProjectName, out var projectId);
                    if (isProject)
                    {
                        record.Record.ProjectId = projectId;
                    }
                    else
                    {
                        var isCheckInFile = projectNamesInFileDict.TryGetValue(record.Record.ProjectName, out var projectName);
                        if (isCheckInFile)
                        {
                            record.Record.ProjectId = projectName;
                        }
                        else
                        {
                            var project = new CreateProjectDto()
                            {
                                //todo
                                Name = record.Record.ProjectName,
                                Address = record.Record.Address,
                                //CommuneIds = record.Record.CommuneId,
                                InvestorId = record.Record.InvestorId,
                                ProjectGroupId = record.Record.GroupProjectId == null ? 1 : record.Record.GroupProjectId,
                                ///todo ProjectStatusId
                                ProjectStatusId = 1,
                                ///todo Project ProjectTypeId
                                ProjectTypeId = 1,
                            };

                            record.Record.ProjectId = await _projectService.CreateReturnId(project);
                            projectNamesInFileDict.Add(record.Record.ProjectName, record.Record.ProjectId);
                        }
                    }
                }
                #region comment code
                //if (string.IsNullOrEmpty(record.Record?.Address))
                //{
                //    errors.Add(new HistoryImportDetailDto
                //    {
                //        FileName = fileName,
                //        SheetName = sheetName,
                //        Row = record?.Record?.RowNumber,
                //        RawData = record.Record.GetRawData(),
                //        Description = $"Địa chỉ này không hợp lệ {record?.Record?.Address}"
                //    });
                //}
                //else
                //{
                //    //var address = UtilHelper.ConvertToUnSign(record.Record.Address);
                //    /////check is has commune
                //    //var isCommuneValid = address.Contains(AddressExtentions.CommuneExtention[0]) || address.Contains(AddressExtentions.CommuneExtention[1]);
                //    //if (!isCommuneValid)
                //    //{
                //    //    errors.Add(new HistoryImportDetailDto
                //    //    {
                //    //        FileName = fileName,
                //    //        SheetName = sheetName,
                //    //        Row = record?.Record?.RowNumber,
                //    //        RawData = record.Record.GetRawData(),
                //    //        Description = $"Địa chỉ này có không có xã, phường {record?.Record?.Address}"
                //    //    });
                //    //}
                //    /////check is has district
                //    //var isDistrictValid = address.Contains(AddressExtentions.DistrictExtention[0])
                //    //                   || address.Contains(AddressExtentions.DistrictExtention[1])
                //    //                   || address.Contains(AddressExtentions.DistrictExtention[2])
                //    //                   || address.Contains(AddressExtentions.DistrictExtention[3]);
                //    //if (!isDistrictValid)
                //    //{
                //    //    errors.Add(new HistoryImportDetailDto
                //    //    {
                //    //        FileName = fileName,
                //    //        SheetName = sheetName,
                //    //        Row = record?.Record?.RowNumber,
                //    //        RawData = record.Record.GetRawData(),
                //    //        Description = $"Địa chỉ này có không có quận, huyện, thị xã, thành phố {record?.Record?.Address}"
                //    //    });
                //    //}

                //    if (!errors.Any())
                //    {
                //        /// attach communeId for record
                //        //var communeName = record.Record?.Address?.Split(",").FirstOrDefault(c => Constant.AddressExtentions.CommuneExtention.Equals(c));
                //        //var communeId = string.IsNullOrEmpty(communeName) ? 0 : _communeService.GetCommuneByName(UtilHelper.ConvertToUnSign(communeName));
                //        //if (communeId == 0)
                //        //{
                //        //    errors.Add(new HistoryImportDetailDto
                //        //    {
                //        //        FileName = fileName,
                //        //        SheetName = sheetName,
                //        //        Row = record?.Record?.RowNumber,
                //        //        RawData = record.Record.GetRawData(),
                //        //        Description = $"Xã, Phường này không tồn tại trong database {communeName}"
                //        //    });
                //        //}
                //        //else
                //        //{
                //        //    record.Record.CommuneId = communeId;
                //        //}

                //        /// attach communeId for record
                //        //var districtName = record.Record?.Address?.Split(",").FirstOrDefault(c => Constant.AddressExtentions.DistrictExtention.Equals(c));
                //        //var districtId = string.IsNullOrEmpty(districtName) ? 0 : _districtService.GetDistrictByName(UtilHelper.ConvertToUnSign(districtName));
                //        //if (districtId == 0)
                //        //{
                //        //    errors.Add(new HistoryImportDetailDto
                //        //    {
                //        //        FileName = fileName,
                //        //        SheetName = sheetName,
                //        //        Row = record?.Record?.RowNumber,
                //        //        RawData = record.Record.GetRawData(),
                //        //        Description = $"Quận, Huyện, Thành phố, Thị xã này không tồn tại trong database {communeName}"
                //        //    });
                //        //}
                //        //else
                //        //{
                //        //    record.Record.DistrictId = districtId;
                //        //}
                //    }
                //}
                #endregion
                
                if (errors.Any())
                {
                    record.FailedObjs = errors;
                    record.IsValid = false;
                    var logs = errors.Select(x => new HistoryImportLog()
                    {
                        Row = x.Row,
                        Description = x.Description,
                        FileName = x.FileName,
                        RawData = x.RawData,
                        SheetName = x.SheetName
                    }).ToList();
                    _historyImportLogRepo.InsertMulti(logs);
                }
            }

            return validateRecords;
        }
    }
}
