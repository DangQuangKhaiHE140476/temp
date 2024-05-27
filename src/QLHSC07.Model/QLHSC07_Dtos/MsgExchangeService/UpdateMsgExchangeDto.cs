using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.MsgExchange
{
    public class UpdateMsgExchangeDto : EntityDto<string>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual ICollection<string> ReceiveUnitId { get; set; }
    }
}
