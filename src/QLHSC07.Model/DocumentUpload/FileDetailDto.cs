using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.DocumentUpload
{
    public class FileDetailDto
    {
        public long? Id { get; set; }
        public string Path { get; set; }
        public string Extenstion { get; set; }
        public string FileName { get; set; }
        public string Session { get; set; }
    }
}
