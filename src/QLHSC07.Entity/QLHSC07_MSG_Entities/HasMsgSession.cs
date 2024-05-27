using QLHSC07.CORE.Helper;
using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_MSG_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.HasMsgSession, Schema = Constant.Schema.QLHSC07)]
    public class HasMsgSession: BaseFullAuditedEntity<long>
    {
        [Column("pc07_local_id")]
        public long PC07LocalId { get; set; }
        public PC07Local PC07Local { get; set; }
        [Column("msg_session_id")]
        public string MsgSessionId { get; set; }
        [ForeignKey(nameof(MsgSessionId))]
        public MsgSession MsgSession { get; set; }
    }
}
