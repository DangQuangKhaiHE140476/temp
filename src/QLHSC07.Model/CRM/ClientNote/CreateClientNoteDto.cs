using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.ClientNote
{
    public class CreateClientNoteDto : BaseCreateDto
    {
        public long ClientId { get; set; }
        public string Note { set; get; }
        public string UserId { get; set; }
    }
}
