using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.AttachFileType
{
    public class UpdateAttachFileTypeDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
