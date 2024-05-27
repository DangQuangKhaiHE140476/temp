using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Model.CRM.ClientNote
{
    public class ClientNoteViewDto : FullAuditedEntityDto<long>
    {
        public long ClientId { get; set; }
        public long ClientName { get; set; }
        public string Note { set; get; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
