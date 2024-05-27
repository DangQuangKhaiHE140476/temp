using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using QLHSC07.CORE;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using QLHSC07.Model.QLHSC07_Dtos.RecordsFiles;
using QLHSC07.Model.User;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IRecordsService : IBaseService<long, Records, RecordsDto, RecordsDto, CreateRecordsDto, UpdateRecordsDto, FilterRecordsDto>
    {
        Task<ResponseItem<bool>> CreateRecord(CreateRecordsDto request, string uploadFolderPath, CurrentUserDto user);
        Task<ResponseItem<bool>> UpdateRecord(UpdateRecordsDto request, string uploadFolderPath, CurrentUserDto user);
        Task<ResponseItem<bool>> UpdateStatus(UpdateStatusRecordsDto recordsStatus);
        Task<byte[]> Export(FilterRecordsDto filter, string fileExtention);
        Task<IQueryable<ReportRecordDto>> ReportRecordChart(ReportRecordChartFilter filter);
        IQueryable<RecordInfoAtLocalDto> RecordInfoAtLocal(RecordInfoAtLocalFilter filter);
        Task<ResponseItem<bool>> Delete(long id, string user);
        Task<ResponseItem<bool>> DeletePermanent(long id, string user);
    }
}
