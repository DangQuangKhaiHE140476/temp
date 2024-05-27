using Microsoft.AspNetCore.Mvc;
using QLHSC07.ApiGateway.Attribute;
using QLHSC07.CORE;
using QLHSC07.CORE.Helper;
using QLHSC07.CORE.Resource;
using QLHSC07.Model.QLHSC07_Dtos.Report;
using QLHSC07.Services.Interfaces.QLHSC07;
using System;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    //[Authorize]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService recordsService)
        {
            _reportService = recordsService;
        }

        [HttpPost("MonitoringAndResultsReport")]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public async Task<ActionResult> ExportFile(string fileExtention, [FromQuery] FilterMonitoringAndResults filter)
        {
            var folder = "download_" + Guid.NewGuid();
            if (string.IsNullOrEmpty(fileExtention))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.FileInvalid
                });
            }

            var file = folder + $".{fileExtention}";
            var result = await _reportService.MonitoringAndResultsReport(fileExtention, filter);
            return File(result, "application/octet-stream", file);
        }
        
        [HttpPost("ProjectsApprovedPCCCReport")]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public async Task<ActionResult> ProjectsApprovedPCCCReport(string fileExtention, [FromQuery] FilterMonitoringAndResults filter)
        {
            var folder = "download_" + Guid.NewGuid();
            if (string.IsNullOrEmpty(fileExtention))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.FileInvalid
                });
            }

            var file = folder + $".{fileExtention}";
            var result = await _reportService.ProjectsApprovedPCCCReport(fileExtention, filter);
            return File(result, "application/octet-stream", file);
        }
        
        [HttpPost("StatisticsAndApprovalReport")]
        [ServiceFilter(typeof(RecordPermissionAttribute))]
        public async Task<ActionResult> StatisticsAndApprovalReport(string fileExtention, [FromQuery] FilterMonitoringAndResults filter)
        {
            var folder = "download_" + Guid.NewGuid();
            if (string.IsNullOrEmpty(fileExtention))
            {
                return BadRequest(new ResponseErrorData
                {
                    ErrorType = ErrorTypeConstant.DataNotValid,
                    ErrorMessage = StringMessage.ErrorMessages.FileInvalid
                });
            }
            var file = folder + $".{fileExtention}";
            var result = await _reportService.StatisticsAndApprovalReport(fileExtention, filter);
            return File(result, "application/octet-stream", file);
        }
    }
}
