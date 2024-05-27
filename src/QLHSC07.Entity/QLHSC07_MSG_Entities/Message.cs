using QLHSC07.CORE.Helper;
using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_MSG_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.Message, Schema = Constant.Schema.QLHSC07)]
    public class Message : BaseFullAuditedEntity<long>
    {
        public Message()
        {
            MessageHasFile = new HashSet<MessageHasFile>();
        }

        [Column("msg_session_id")]
        public string MsgSessionId { get; set; }
        [ForeignKey(nameof(MsgSessionId))]
        public MsgSession MsgSession { get; set; }

        [Column("content")]
        [StringLength(Constant.Maxlength.Content)]
        public string Content { get; set; }
        [Column("is_reply")]
        public bool IsReply { get; set; }

        [Column("message_date")]
        public DateTime? MessageDate { get; set; }
        [Column("message_by_id")]
        public long? MessageById { get; set; }
        [ForeignKey(nameof(MessageById))]
        public PC07Local MessageBy { get; set; }

        [Column("is_important")]
        public bool IsImportant { get; set; }
        public virtual ICollection<MessageHasFile> MessageHasFile { get; set; }
    }
}
