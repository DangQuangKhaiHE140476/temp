using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model
{
    public class PagedResultRequestDto
    {
        [Range(0, int.MaxValue, ErrorMessage = "{0} phải lớn hơn hoặc bằng {1}")]
        public int PageIndex { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "{0} phải lớn hơn hoặc bằng {1}")]
        public int PageSize { get; set; }
    }
}
