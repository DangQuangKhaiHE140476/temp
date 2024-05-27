using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model
{
    public interface IPagedResultRequestDto
    {
        [Range(0, int.MaxValue, ErrorMessage = "{0} phải lớn hơn hoặc bằng {1}")]
        public int PagedIndex { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "{0} phải lớn hơn hoặc bằng {1}")]
        public int PageSize { get; set; }
    }
}
