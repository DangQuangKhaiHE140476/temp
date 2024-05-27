using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.RecordTypes;
using QLHSC07.Model.QLHSC07_Dtos.Regency;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IRecordTypesService : IBaseService<long, RecordsType, RecordTypesDto, RecordTypesDto, CreateRecordTypesDto, UpdateRecordTypesDto, FilterRecordTypesDto>
    {
        IList<RecordTypesLookupDto> GetLookupRecordTypes();
    }
}
