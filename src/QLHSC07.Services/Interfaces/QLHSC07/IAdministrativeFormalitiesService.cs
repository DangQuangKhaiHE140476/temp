using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.AdministrativeFormalities;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IAdministrativeFormalitiesService : IBaseService<long, AdministrativeFormalities, AdministrativeFormalitiesDto, AdministrativeFormalitiesDto, CreateAdministrativeFormalitiesDto, UpdateAdministrativeFormalitiesDto, FilterAdministrativeFormalitiesDto>
    {
        IList<AdministrativeFormalitiesLookupDto> GetLookupAdministrativeFormalities();
    }
}
