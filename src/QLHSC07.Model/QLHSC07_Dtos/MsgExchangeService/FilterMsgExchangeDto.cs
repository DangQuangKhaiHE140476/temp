using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.MsgExchange
{
    public class FilterMsgExchangeDto : PagedAndSortResultRequestDto
    {
        public string Keyword { get; set; }
        public string Title { get; set; }
        public string Session { get; set; }
        public string Content { get; set; }
        public virtual ICollection<long> ReceiveUnitId { get; set; }
    }
}
