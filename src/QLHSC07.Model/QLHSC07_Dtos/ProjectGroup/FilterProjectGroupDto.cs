﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.ProjectGroup
{
    public class FilterProjectGroupDto : PagedAndSortResultRequestDto
    {
        public string Name { get; set; }
    }
}