using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.User
{
    public class FilterUserDto: PagedResultRequestDto
    {
        public string SortExpression { get; set; }
        public string Email { get; set; }
        public bool? IsAdmin { get; set; }
        public string FullName { get; set; }
    }
}
