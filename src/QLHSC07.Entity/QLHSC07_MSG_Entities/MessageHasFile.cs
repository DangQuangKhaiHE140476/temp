using QLHSC07.CORE.Helper;
using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_MSG_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.MessageHasFile, Schema = Constant.Schema.QLHSC07)]
    public class MessageHasFile : BaseFullAuditedEntity<long>
    {
        public MessageHasFile()
        {
        }

        [Column("attachment_id")]
        public long AttachmentId { get; set; }
        [ForeignKey(nameof(AttachmentId))]
        public virtual DocumentUpload Attachment { get; set; }
        
        [Column("message_id")]
        public long MessageId { get; set; }
        [ForeignKey(nameof(MessageId))]
        public virtual Message Message { get; set; }
    }
}
