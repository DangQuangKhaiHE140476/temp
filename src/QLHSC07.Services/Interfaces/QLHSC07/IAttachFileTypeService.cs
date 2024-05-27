using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.AttachFileType;
using QLHSC07.Model.QLHSC07_Dtos.Regency;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IAttachFileTypeService : IBaseService<long, FileTypeAttachment, AttachFileTypeDto, AttachFileTypeDto, CreateAttachFileTypeDto, UpdateAttachFileTypeDto, FilterAttachFileTypeDto>
    {
        Task<IList<AttachFileTypeLookupDto>> GetLookupAttachFileType();
        Task<IList<AttachFileTypeLookupDto>> GetLookupByReCordType(long recordsTypeId);
    }
}
