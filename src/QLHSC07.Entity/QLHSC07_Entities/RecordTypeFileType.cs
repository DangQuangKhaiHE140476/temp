using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.RecordsTypeFileType, Schema = Constant.Schema.QLHSC07)]
    public class RecordsTypeFileType : BaseFullAuditedEntity<long>
    {
        [Column("records_type_id")]
        public long RecordsTypeId { get; set; }
        [ForeignKey(nameof(RecordsTypeId))]
        public RecordsType RecordsType { get; set; }
        [Column("file_type_attachment_id")]
        public long FileTypeAttachmentId { get; set; }
        [ForeignKey(nameof(FileTypeAttachmentId))]
        public FileTypeAttachment FileTypeAttachment { get; set; }
        [Column("is_required")]
        public bool IsRequired { get; set; }
    }
}
