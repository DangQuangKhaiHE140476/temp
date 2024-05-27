using QLHSC07.CORE.Helper;
using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_MSG_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.MsgReceive, Schema = Constant.Schema.QLHSC07)]
    public class MsgReceive: BaseFullAuditedEntity<long>
    {
        [Column("msg_session_id")]
        public string MsgSessionId { get; set; }
        [ForeignKey(nameof(MsgSessionId))]
        public virtual MsgSession MsgSession { get; set; }
        [Column("receive_pc07_id")]
        public long ReceivePC07Id { get; set; }
        [ForeignKey(nameof(ReceivePC07Id))]
        public virtual PC07Local ReceivePC07Local { get; set; }
    }
}
