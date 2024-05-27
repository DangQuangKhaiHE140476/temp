using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.RecordsStatus;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IRecordStatusService : IBaseService<long, RecordsStatus, RecordsStatusDto, RecordsStatusDto, CreateRecordsStatusDto, UpdateRecordsStatusDto, FilterRecordsStatusDto>
    {
        IList<RecordsStatusLookupDto> GetLookupRecordsStatus();
    }
}
