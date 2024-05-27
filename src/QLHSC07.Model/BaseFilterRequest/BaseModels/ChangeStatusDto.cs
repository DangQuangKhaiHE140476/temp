using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.BaseFilterRequest.BaseModels
{
    public class ChangeStatusDto
    {
        public ICollection<long> Ids { get; set; }
        public bool Status { get; set; }
    }
}
