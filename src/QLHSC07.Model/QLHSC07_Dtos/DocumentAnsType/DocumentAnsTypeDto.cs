using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.DocumentAnsType
{
    public class DocumentAnsTypeDto : FullAuditedEntityDto<long>
    {
        public string Name { get; set; }

    }
}
