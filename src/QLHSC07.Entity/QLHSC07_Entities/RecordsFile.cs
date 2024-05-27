using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.RecordsFile, Schema = Constant.Schema.QLHSC07)]
    public class RecordsFile: BaseFullAuditedEntity<long>
    {
        [Column("records_id")]
        public long RecordsId { get; set; }
        [ForeignKey(nameof(RecordsId))]
        public Records Records { get; set; }
        [Column("file_type_attachment_id")]
        public long FileTypeAttachmentId { get; set; }
        [ForeignKey(nameof(FileTypeAttachmentId))]
        public FileTypeAttachment FileTypeAttachment { get; set; }
        [Column("document_upload_id")]
        public long DocumentUploadId { get; set; }
        [ForeignKey(nameof(DocumentUploadId))]
        public DocumentUpload DocumentUpload { get; set; }
    }
}
