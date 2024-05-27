using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.AdministrativeFormalities
{
    public class UpdateAdministrativeFormalitiesDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public long ParentId { get; set; }
    }
}
