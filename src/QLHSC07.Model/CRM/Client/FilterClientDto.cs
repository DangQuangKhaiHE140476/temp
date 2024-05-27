using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.Client
{
    public class FilterClientDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
        public long? ClientType { get; set; }
        public long? IsConfirm { get; set; }
        public bool? IsActive { get; set; }
        public string PhoneNumber { get; set; }

    }
}
