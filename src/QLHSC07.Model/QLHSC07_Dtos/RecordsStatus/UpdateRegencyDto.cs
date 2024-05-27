using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsStatus
{
    public class UpdateRecordsStatusDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
