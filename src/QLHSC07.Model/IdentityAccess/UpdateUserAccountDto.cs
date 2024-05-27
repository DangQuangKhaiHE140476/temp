﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.IdentityAccess
{
    public class UpdateUserAccountDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Sex { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
