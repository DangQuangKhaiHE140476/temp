﻿using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.ProjectType
{
    public class UpdateProjectTypeDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}