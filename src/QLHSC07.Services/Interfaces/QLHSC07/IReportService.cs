using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using QLHSC07.CORE;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using QLHSC07.Model.QLHSC07_Dtos.RecordsFiles;
using QLHSC07.Model.QLHSC07_Dtos.Report;
using QLHSC07.Model.User;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IReportService
    {
        Task<byte[]> MonitoringAndResultsReport(string fileExtention, FilterMonitoringAndResults filter);
        Task<byte[]> ProjectsApprovedPCCCReport(string fileExtention, FilterMonitoringAndResults filter);
        Task<byte[]> StatisticsAndApprovalReport(string fileExtention, FilterMonitoringAndResults filter);
    }
}
