using Microsoft.AspNetCore.Mvc;
using QLHSC07.Model.BaseModels;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using QLHSC07.Model.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.MsgExchange
{
    public class CreateMsgExchange : BaseCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual ICollection<long> ReceiveUnitId { get; set; }
    }
}
