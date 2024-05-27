using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Dto.BaseEntity
{
    public class Files
    {
        public string fileName { get; set; }
        public string fileType { get; set; }
        public string filePreview { get; set; }
        public long fileSize { get; set; }
        public long? fileId { get; set; }
    }
}
