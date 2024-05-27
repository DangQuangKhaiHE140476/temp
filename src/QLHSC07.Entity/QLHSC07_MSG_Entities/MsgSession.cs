using QLHSC07.CORE.Helper;
using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_MSG_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.MsgSession, Schema = Constant.Schema.QLHSC07)]
    public class MsgSession: BaseFullAuditedEntity<string>
    {
        [Column("send_pc07_id")]
        public long SendPC07Id { get; set; }
        [ForeignKey(nameof(SendPC07Id))]
        public PC07Local SendPC07Local { get; set; }
        
        [Column("title")]
        public string Title { get; set; }
        public virtual ICollection<HasMsgSession> HasMsgSessions { get; set; }
        public virtual ICollection<MsgReceive> MsgReceives { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
