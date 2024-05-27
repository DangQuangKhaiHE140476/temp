﻿using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.PC07
{
    public class CreatePC07Dto : BaseCreateDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ProvinceId { get; set; }
        public int CommuneId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
    }
}