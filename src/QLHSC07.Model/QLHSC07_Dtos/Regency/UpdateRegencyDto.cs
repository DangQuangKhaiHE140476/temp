using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Regency
{
    public class UpdateRegencyDto: EntityDto<long>
    {
        public string Name { get; set; }
    }
}
