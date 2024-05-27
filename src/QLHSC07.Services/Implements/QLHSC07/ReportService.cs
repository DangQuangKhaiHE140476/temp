using Aspose.Cells;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QLHSC07.CORE.Extensions;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Model.QLHSC07_Dtos.Report;
using QLHSC07.Services.Interfaces.QLHSC07;
using QLHSC07.Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using static QLHSC07.CORE.Helper.Constant;

namespace QLHSC07.Services.Implements.QLHSC07
{
    public class ReportService : IReportService
    {
        private readonly IRepository<Records, long> _recordRepo;
        private readonly IRepository<ProjectType, long> _projectTypeRepo;
        private readonly IRepository<Project, long> _projectRepo;
        private readonly IRepository<RecordsType, long> _recordTypeRepo;
        private readonly IRepository<Flatline, long> _flatlineRepo;
        private readonly RootFile _rootFile;
        private readonly ILogger<ReportService> _logger;

        public ReportService(IRepository<Records, long> recordRepo,
            RootFile rootFile,
            IRepository<ProjectType, long> projectTypeRepo,
            IRepository<Project, long> projectRepo,
            IRepository<RecordsType, long> recordTypeRepo,
            IRepository<Flatline, long> flatlineRepo,
            ILogger<ReportService> logger)
        {
            _logger = logger;
            _recordRepo = recordRepo;
            _rootFile = rootFile;
            _projectTypeRepo = projectTypeRepo;
            _projectRepo = projectRepo;
            _recordTypeRepo = recordTypeRepo;
            _flatlineRepo = flatlineRepo;
        }

        private async Task<List<MonitoringAndResults>> GetRecordsData(FilterMonitoringAndResults filter)
        {
            var datas = await _flatlineRepo.GetAll().Where(c => !c.IsDelete)
                            .WhereIf(filter.PC07ManageId.HasValue, x => x.PC07ManageId == filter.PC07ManageId)
                            .WhereIf(filter.RecordTypeId.HasValue, x => x.RecordTypeId == filter.RecordTypeId)
                            .WhereIf(filter.FromDate.HasValue, x => x.ModifiedDate >= filter.FromDate)
                            .WhereIf(filter.ToDate.HasValue, x => x.ModifiedDate <= filter.ToDate)
                            .WhereIf(filter.ProjectTypeId.HasValue, x => x.ProjectTypeId == filter.ProjectTypeId)
                            .WhereIf(filter.GroupProjectId.HasValue, x => x.GroupProjectId == filter.GroupProjectId)
                             .Select(c => new MonitoringAndResults
                             {
                                 NumberOfVotesReceived = c.RecordNum,
                                 ProjectName = c.ProjectName,
                                 InvestorName = c.InvestorName,
                                 //BuildingSite = MappingAddressDetail(c),
                                 RecordType = c.RecordTypeName,
                                 ReceptionForm = c.ReceptionForm,
                                 ReceptionTime = c.ReceiveDate,
                                 ReceptionOfficer = c.ReceiveUserName,
                                 AppointmentResult = c.DatePredictReturn,
                                 NumberOfReplyTexts = c.ReturnDocNumb,
                                 ReplyTextDate = c.DatePredictReturn,
                                 ResultsDay = c.DateRealReturn,
                                 ResultRecipient = c.PC07ReceiveName,
                                 Address = c.Address,
                                 PositionsJsonString = c.Positions,
                                 ProjectTypeId = c.ProjectTypeId,
                                 ProjectTypeName = c.ProjectTypeName,
                                 IsNewProject = c.IsNewProject
                             }).ToListAsync();
            ///get BuildingSite
            datas.ForEach(c =>
            {
                c.Positions = string.IsNullOrEmpty(c.PositionsJsonString) ? null : JsonSerializer.Deserialize<List<Positions>>(c.PositionsJsonString);
                c.BuildingSite = (c.Positions != null && c.Positions.Any() ? ConcatAddressPositionString(c.Positions) : null);
            });
            return datas;
        }

        private async Task<List<MonitoringAndResults>> BuildDataMonitoringAndResults(FilterMonitoringAndResults filter)
        {
            var datas = await ((from projectType in _projectTypeRepo.GetAll().Where(c => !c.IsDelete).OrderBy(c => c.Id)
                                join flat in _flatlineRepo.GetAll().Where(c => !c.IsDelete)
                                          on projectType.Id equals flat.ProjectTypeId into lfProjectType
                                from flatline in lfProjectType.DefaultIfEmpty()
                                select new
                                {
                                    ProjectType = projectType,
                                    Flatline = flatline
                                })
                         .WhereIf(filter.RecordTypeId.HasValue, x => x.Flatline.RecordTypeId == filter.RecordTypeId)
                         .WhereIf(filter.FromDate.HasValue, x => x.Flatline.ModifiedDate == filter.FromDate)
                         .WhereIf(filter.ToDate.HasValue, x => x.Flatline.ModifiedDate == filter.ToDate)
                         .WhereIf(filter.ProjectTypeId.HasValue, x => x.Flatline.ProjectTypeId == filter.ProjectTypeId)
                         .WhereIf(filter.GroupProjectId.HasValue, x => x.Flatline.GroupProjectId == filter.GroupProjectId)
                         .Select(c => new MonitoringAndResults
                         {
                             NumberOfVotesReceived = c.Flatline.RecordNum,
                             ProjectName = c.Flatline.ProjectName,
                             InvestorName = c.Flatline.InvestorName,
                             //BuildingSite = MappingAddressDetail(c),
                             RecordType = c.Flatline.RecordTypeName,
                             ReceptionTime = c.Flatline.ReceiveDate,
                             ReceptionOfficer = c.Flatline.ReceiveUserName,
                             AppointmentResult = c.Flatline.DatePredictReturn,
                             NumberOfReplyTexts = c.Flatline.ReturnDocNumb,
                             ReplyTextDate = c.Flatline.DatePredictReturn,
                             ResultsDay = c.Flatline.DateRealReturn,
                             ResultRecipient = c.Flatline.PC07ReceiveName,
                             Address = c.Flatline.Address,
                             PositionsJsonString = c.Flatline.Positions,
                             ///todo
                             ProjectTypeId = c.ProjectType.Id,
                             ProjectTypeName = c.ProjectType.Name,
                             RecordTypeId = c.Flatline.RecordTypeId,
                             IsNewProject = c.Flatline.IsNewProject
                         })).ToListAsync();
            ///get BuildingSite
            datas.ForEach(c =>
            {
                c.Positions = string.IsNullOrEmpty(c.PositionsJsonString) ? null : JsonSerializer.Deserialize<List<Positions>>(c.PositionsJsonString);
                c.BuildingSite = (c.Positions != null && c.Positions.Any() ? ConcatAddressPositionString(c.Positions) : null);
            });

            return datas;
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

        public async Task<byte[]> MonitoringAndResultsReport(string fileExtention, FilterMonitoringAndResults filter)
        {
            if (!FileExtentions.FileExtention.Contains(fileExtention))
            {
                _logger.LogError("Format file không hợp lệ", fileExtention);
                return null;
            }

            var dataExport = await GetRecordsData(filter);
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(_rootFile.FileNameRecordTemplate)))
            {
                if (!dataExport.Any()) return excelPackage.GetAsByteArray();
                int index = 6;
                int rowNum = 1;
                var workSheet = excelPackage.Workbook.Worksheets["Tiepnhanvatraketqua"];
                foreach (var monitoring in dataExport)
                {
                    if (monitoring == null) continue;
                    // write header data for each construction order
                    workSheet.Cells[index, 1].Value = rowNum;
                    workSheet.Cells[index, 2].Value = monitoring?.NumberOfVotesReceived;
                    workSheet.Cells[index, 3].Value = monitoring?.ProjectName;
                    workSheet.Cells[index, 4].Value = monitoring?.InvestorName;
                    workSheet.Cells[index, 5].Value = monitoring?.BuildingSite;
                    workSheet.Cells[index, 6].Value = monitoring?.RecordType;
                    workSheet.Cells[index, 7].Value = monitoring?.ReceptionForm;
                    workSheet.Cells[index, 8].Value = monitoring?.ReceptionTime;
                    workSheet.Cells[index, 9].Value = monitoring?.ReceptionOfficer;
                    workSheet.Cells[index, 10].Value = monitoring?.AppointmentResult;
                    workSheet.Cells[index, 11].Value = monitoring?.NumberOfReplyTexts;
                    workSheet.Cells[index, 12].Value = monitoring?.ReplyTextDate;
                    workSheet.Cells[index, 13].Value = monitoring?.ResultsDay;
                    workSheet.Cells[index, 14].Value = monitoring?.ResultRecipient;
                    index++;
                    rowNum++;
                }
                workSheet.Cells[workSheet.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();

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

                SetWrapExcel(workSheet, 14, 13);

                if (fileExtention.Equals("PDF", StringComparison.OrdinalIgnoreCase))
                {
                    return await Task.FromResult(SaveAsPdf(new MemoryStream(excelPackage.GetAsByteArray())));
                }
                return await Task.FromResult(excelPackage.GetAsByteArray());
            }
        }
        private string MappingAddressDetail(string address,
            string communeName, string districtName, string provinceName)
        {
            string[] addressDetailArray = new string[]
            {
                address,
                communeName,
                districtName,
                provinceName,
            };
            if (!addressDetailArray.Any()) return "";
            return string.Join(", ", addressDetailArray.Where(c => !string.IsNullOrEmpty(c)));
        }

        /// <summary>
        /// Danh sách dự án công trình được thẩm duyệt thiết kế PCCC
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> ProjectsApprovedPCCCReport(string fileExtention, FilterMonitoringAndResults filter)
        {
            if (!FileExtentions.FileExtention.Contains(fileExtention))
            {
                _logger.LogError("Format file không hợp lệ", fileExtention);
                return null;
            }

            var dataExport = await GetRecordsData(filter);
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(_rootFile.ProjectsApprovedTemplate)))
            {
                if (!dataExport.Any()) return excelPackage.GetAsByteArray();
                int index = 10;
                int rowNum = 1;
                var workSheet = excelPackage.Workbook.Worksheets["baocao"];
                var sign = excelPackage.Workbook.Worksheets["sign"];
                foreach (var monitoring in dataExport)
                {
                    if (monitoring == null) continue;

                    var positions = GetPositionReport(monitoring.Positions);
                    // write header data for each construction order
                    workSheet.Cells[index, 1].Value = rowNum;
                    workSheet.Cells[index, 2].Value = monitoring?.ProjectName;
                    workSheet.Cells[index, 3].Value = string.Join(", ", (new List<string>() { monitoring?.Address, positions?.Communes, positions?.Districts }).Where(c => !string.IsNullOrEmpty(c)));
                    workSheet.Cells[index, 4].Value = string.Join(", ", (new List<string>() { positions?.Provinces }).Where(c => !string.IsNullOrEmpty(c)));
                    workSheet.Cells[index, 5].Value = monitoring?.InvestorName;
                    workSheet.Cells[index, 6].Value = monitoring?.RecordType;
                    workSheet.Cells[index, 7].Value = monitoring.ResultsDay.HasValue ? ((DateTime)monitoring.ResultsDay).ToString("MM/dd/yyyy") : null;
                    index++;
                    rowNum++;
                }
                workSheet.Cells[$"G10:G{index}"].Style.Numberformat.Format =
                     _rootFile.NumberformatDateTime;
                workSheet.Cells[$"G10:G{index}"].AutoFitColumns();

                workSheet.Cells[$"A{index}:G{index + 2}"].Merge = true;
                sign.Cells["A1:G6"].Copy(workSheet.Cells[$"A{index}:G{index + 1}"]);
                workSheet.Cells[$"A{index + 1}:G{index + 1}"].AutoFitColumns();

                workSheet.Cells[workSheet.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                excelPackage.Workbook.Worksheets.Delete(sign);
                SetWrapExcel(workSheet, 7, 20);
                if (fileExtention.Equals("PDF", StringComparison.OrdinalIgnoreCase))
                {
                    return await Task.FromResult(SaveAsPdf(new MemoryStream(excelPackage.GetAsByteArray())));
                }
                return await Task.FromResult(excelPackage.GetAsByteArray());
            }
        }

        private void SetWrapExcel(ExcelWorksheet worksheet, int columnNr, int widthCell)
        {
            if (columnNr < 1) return;
            worksheet.Column(1).AutoFit();
            for (int i = 2; i <= columnNr; i++)
            {
                worksheet.Column(i).Width = widthCell;
                worksheet.Column(i).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Column(i).Style.VerticalAlignment = ExcelVerticalAlignment.Top;
                //wrap text in the cells
                worksheet.Column(i).Style.WrapText = true;
                if (i == 3)
                {
                    worksheet.Column(i).Width = widthCell + 10;
                }
            }

            //wrap text in the cells
            worksheet.PrinterSettings.PaperSize = ePaperSize.A4;
            worksheet.PrinterSettings.Orientation = eOrientation.Portrait;
            worksheet.PrinterSettings.HorizontalCentered = true;
            worksheet.PrinterSettings.FitToPage = true;
            worksheet.PrinterSettings.FitToWidth = 1;
            worksheet.PrinterSettings.FitToHeight = 0;
        }

        /// <summary>
        ///Tạo dữ liệu báo cáo: Thống kê số liệu kết quả thực hiện công tác thẩm duyệt TK PCCC
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> StatisticsAndApprovalReport(string fileExtention, FilterMonitoringAndResults filter)
        {
            if (!FileExtentions.FileExtention.Contains(fileExtention))
            {
                _logger.LogError("Format file không hợp lệ", fileExtention);
                return null;
            }

            var sumRowNumb = 29;
            Random r = new Random();
            var dataExport = (await BuildDataMonitoringAndResults(filter))
                             .GroupBy(c => c.ProjectTypeId)
                             .Select(c => new StatisticsAndApprovalResult
                             {
                                 ProjectType = c.Select(c => c.ProjectTypeName).FirstOrDefault(),
                                 ///Chấp thuận địa điểm xây dựng
                                 ApprovingConstructionSiteNr = c.Count(x => x.RecordTypeId == 1),
                                 ///Số văn bản góp ý thiết kế cơ sở
                                 GivingCommentsNr = c.Count(x => x.RecordTypeId == 2),
                                 ///Thẩm duyệt công trình mới
                                 ApprovalNewProjects = c.Count(x => x.RecordTypeId == 3 && x.IsNewProject == true),
                                 ///Thẩm duyệt điều chỉnh, cải tạo
                                 ApprovalOldProjects = c.Count(x => x.RecordTypeId == 3 && x.IsNewProject == false),
                                 ///Nghiệm thu công trình mới
                                 AcceptanceNewProjects = c.Count(x => x.RecordTypeId == 4 && x.IsNewProject == true),
                                 ///Nghiệm thu công trình cải tạo
                                 AcceptanceOldProjects = c.Count(x => x.RecordTypeId == 4 && x.IsNewProject == false),
                                 ///Số văn bản kiến nghị
                                 PetitionsNr = r.Next(0, 10)
                             });

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(_rootFile.StatisticsAndApprovalTemplate)))
            {
                var workSheet = excelPackage.Workbook.Worksheets["baocao"];
                ///fake data
                int rows = 23;
                //if (!dataExport.Any()) return excelPackage.GetAsByteArray();
                int index = 6;
                int rowNum = 1;

                foreach (var data in dataExport)
                {
                    workSheet.Cells[index, 2].Value = data.ProjectType;
                    workSheet.Cells[index, 3].Value = data.ApprovingConstructionSiteNr;
                    workSheet.Cells[index, 4].Value = data.GivingCommentsNr;
                    workSheet.Cells[index, 5].Value = data.ApprovalNewProjects;
                    workSheet.Cells[index, 6].Value = data.ApprovalOldProjects;
                    workSheet.Cells[index, 7].Value = data.AcceptanceNewProjects;
                    workSheet.Cells[index, 8].Value = data.AcceptanceOldProjects;
                    workSheet.Cells[index, 9].Value = data.PetitionsNr;
                    index++;
                    rowNum++;
                }

                //calculate the SUM of range
                workSheet.Cells[sumRowNumb, 3].Formula = "=SUM(C1:C28)";
                workSheet.Cells[sumRowNumb, 4].Formula = "=SUM(D1:D28)";
                workSheet.Cells[sumRowNumb, 5].Formula = "=SUM(E1:E28)";
                workSheet.Cells[sumRowNumb, 6].Formula = "=SUM(F1:F28)";
                workSheet.Cells[sumRowNumb, 7].Formula = "=SUM(G1:G28)";
                workSheet.Cells[sumRowNumb, 8].Formula = "=SUM(H1:H28)";
                workSheet.Cells[sumRowNumb, 9].Formula = "=SUM(I1:I28)";
                ///2. Góp ý đồ án quy hoạch								
                workSheet.Cells[32, 3].Value = r.Next(0, 100);
                workSheet.Cells[33, 3].Value = r.Next(0, 100);
                workSheet.Cells[34, 3].Value = r.Next(0, 100);
                workSheet.Cells[35, 3].Value = r.Next(0, 100);
                workSheet.Cells[36, 3].Value = r.Next(0, 100);
                workSheet.Cells[37, 3].Value = r.Next(0, 100);

                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                SetWrapExcel(workSheet, 8, 30);
                if (fileExtention.Equals("PDF", StringComparison.OrdinalIgnoreCase))
                {
                    return await Task.FromResult(SaveAsPdf(new MemoryStream(excelPackage.GetAsByteArray()), true));
                }
                return await Task.FromResult(excelPackage.GetAsByteArray());
            }
        }

        private PositionSeperates GetPositionReport(List<Positions> positions)
        {
            if (positions == null || !positions.Any()) return null;
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
            return new PositionSeperates
            {
                Communes = string.Join(" - ", pos.Where(x => !string.IsNullOrEmpty(x.Comm)).Select(x => x.Comm).Distinct().ToList()),
                Districts = string.Join(" - ", pos.Where(x => !string.IsNullOrEmpty(x.Dist)).Select(x => x.Dist).Distinct().ToList()),
                Provinces = string.Join(" - ", pos.Where(x => !string.IsNullOrEmpty(x.Prov)).Select(x => x.Prov).Distinct().ToList()),
            };
        }

        private byte[] SaveAsPdf(MemoryStream stream, bool autofit = false)
        {
            if (stream == null)
            {
                _logger.LogWarning("Stream không thể là null");
                return stream.ToArray();
            }
            var loadOptions = new Aspose.Cells.LoadOptions(Aspose.Cells.LoadFormat.Xlsx);

            var workbook = new Aspose.Cells.Workbook(stream, loadOptions: loadOptions);
            var worksheet = workbook.Worksheets[0];
            // Setting the number of pages to which the length of the worksheet will be spanned
            //if (autofit)
            //{
            //    worksheet.PageSetup.FitToPagesTall = 1;
            //    worksheet.AutoFitRows();
            //}
            var cells = worksheet.Cells;
            Aspose.Cells.Style stl = new Aspose.Cells.Style();
            var font = stl.Font;
            font.Size = 13;
            stl.IsTextWrapped = true;
            StyleFlag sf = new StyleFlag();
            sf.VerticalAlignment = true;
            sf.WrapText = true;
            sf.FontSize = true;

            cells.ApplyStyle(stl, sf);
            worksheet.AutoFitRows();

            Aspose.Cells.PageSetup pageSetup = worksheet.PageSetup;
            // Check for license and apply if exists
            // Setting current date and current time at the centeral section of the header
            // and changing the font of the header
            pageSetup.PaperSize = Aspose.Cells.PaperSizeType.PaperA4Rotated;
            pageSetup.Orientation = Aspose.Cells.PageOrientationType.Landscape;

            // Setting the number of pages to which t
            MemoryStream memorystream = new MemoryStream();
            workbook.Save(memorystream, Aspose.Cells.SaveFormat.Pdf);
            //Get bytes
            byte[] bytes = memorystream.ToArray();

            return bytes;
        }
    }
}
