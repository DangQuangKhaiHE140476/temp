using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.AttachFileType
{
    public class AttachFileTypeLookupDto : BaseLookupDto<long>
    {
        public bool IsRequired { get; set; }
    }
}
