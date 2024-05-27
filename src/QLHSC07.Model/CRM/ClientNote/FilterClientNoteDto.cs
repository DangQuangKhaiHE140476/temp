using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.ClientNote
{
    public class FilterClientNoteDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
        public long ClientId { get; set; }

    }
}
