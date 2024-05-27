using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class CreateOrUpdateProjectDto
    {
        public bool? IsNewProject { get; set; }
        public Project Projects { get; set; }
    }
}
