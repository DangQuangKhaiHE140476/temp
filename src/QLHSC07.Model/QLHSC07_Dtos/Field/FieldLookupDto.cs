using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Field
{
    public class AdministrativeFormalitiesLookupDto 
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<AdministrativeFormalitiesLookupDto> Childs { get; set; }
    }
}
