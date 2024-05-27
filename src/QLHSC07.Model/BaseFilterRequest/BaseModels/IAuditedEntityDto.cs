using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.BaseModels
{
    public interface IAuditedEntityDto
    {
        string CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        string ModifiedBy { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}
