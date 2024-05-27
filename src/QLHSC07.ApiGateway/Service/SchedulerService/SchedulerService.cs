using QLHSC07.CORE.Settings;
using QLHSC07.Data.Repository;
using QLHSC07.Services.Interfaces;
using Hangfire;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Service.SchedulerService
{
    public interface ISchedulerService
    {
        Task RunHangfireJobs();
    }
    public class SchedulerService : ISchedulerService
    {
        private readonly ILogger _logger;
        private readonly HangfireSetting _hangfireOption;
        private readonly IDocumentUploadResizeJob _documentUploadResizeJob;
#pragma warning restore 0649


        public SchedulerService(ILogger<SchedulerService> logger,
            IDocumentUploadResizeJob documentUploadResizeJob, 
            HangfireSetting hangfireOption)
        {
            _logger = logger;
            _hangfireOption = hangfireOption;
            _documentUploadResizeJob = documentUploadResizeJob;
        }

        public async Task RunHangfireJobs()
        {
            if (_hangfireOption.EnableSync)
                await _documentUploadResizeJob.CronJobCreateMultiSizeImagePaths();
        }
    }
}
