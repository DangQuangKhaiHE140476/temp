using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class FileAttachmentDto
    {
        public long? FileId { get; set; }
        public long FileTypeAttachmentId { get; set; }
    }
}
