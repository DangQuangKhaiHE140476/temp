using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.AdministrativeFormalities
{
    public class FilterAdministrativeFormalitiesDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}
