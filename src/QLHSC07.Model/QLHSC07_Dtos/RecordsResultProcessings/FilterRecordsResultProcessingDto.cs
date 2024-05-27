using QLHSC07.Model.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsResultProcessings
{
    public class FilterRecordsResultProcessingDto : PagedAndSortResultRequestDto
    {
        public string TuKhoa { get; set; }
        public DateTime? SoHoaTuNgay { get; set; }
        public DateTime? SoHoaDenNgay { get; set; }

        public DateTime? NgayCapTuNgay { get; set; }
        public DateTime? NgayCapDenNgay { get; set; }
        public int? TrangThai { get; set; }
        public CurrentUserDto CurrentUser { get; set; }
        public int? PC07LocalId { get; set; }
        public string PC07LocalCode { get; set; }

    }
}
