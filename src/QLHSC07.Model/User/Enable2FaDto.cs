using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLHSC07.Model.User
{
    public class Enable2FaDto
    {

    }
    public class Disable2FaDto
    {
        [Required]
        public string password { set; get; }
    }
    public class ChangeSecretKeyDto
    {
        [Required]
        public string password { set; get; }
    }
}
