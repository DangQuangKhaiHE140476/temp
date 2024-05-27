using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.PC07;
using QLHSC07.Model.QLHSC07_Dtos.Regency;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IPC07Service : IBaseService<long, PC07Local, PC07Dto, PC07Dto, CreatePC07Dto, UpdatePC07Dto, FilterPC07Dto>
    {
        IList<PC07LookupDto> GetLookupPC07(FilterPC07LookupDto filter);
        bool UpdateCode();
    }
}
