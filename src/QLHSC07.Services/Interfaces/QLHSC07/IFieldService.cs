using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.Field;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IFieldService : IBaseService<long, Field, FieldDto, FieldDto, CreateAdministrativeFormalitiesDto, UpdateFieldDto, FilterFieldDto>
    {
        IList<AdministrativeFormalitiesLookupDto> GetLookupField();
    }
}
