using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.CRM.Order
{
    public class FilterOrderDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
        public long? ClientId { get; set; }
    }
}
