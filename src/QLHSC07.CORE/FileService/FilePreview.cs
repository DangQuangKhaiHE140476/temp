using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.CORE.FileService
{
    public class FilePreview
    {
        public string fileName { get; set; }
        public string fileType { get; set; }
        public string filePreview { get; set; }
        public long fileSize { get; set; }
        public long? fileId { get; set; }
    }
}
