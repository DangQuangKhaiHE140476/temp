using QLHSC07.Dto.BaseEntity;
using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsFiles
{
    public class RecordsFileDto: EntityDto<long>
    {
        public long RecordsId { get; set; }
        public long FileTypeAttachmentId { get; set; }
        public string FileTypeAttachmentName { get; set; }
        public long DocumentUploadId { get; set; }
        public string Path { get; set; }
    }
}
