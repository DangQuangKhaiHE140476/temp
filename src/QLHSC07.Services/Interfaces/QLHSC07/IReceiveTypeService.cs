using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.ReceiveType;
using QLHSC07.Model.QLHSC07_Dtos.Regency;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IReceiveTypeService : IBaseService<long, ReceiveType, ReceiveTypeDto, ReceiveTypeDto, CreateReceiveTypeDto, UpdateReceiveTypeDto, FilterReceiveTypeDto>
    {
        IList<ReceiveTypeLookupDto> GetLookupReceiveType();
    }
}
