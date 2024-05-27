using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.ClientNote
{
    public class UpdateClientNoteDto : EntityDto<long>
    {
        public string Note { set; get; }
    }
}
