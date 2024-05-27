using Microsoft.AspNetCore.Http;
using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsResultProcessings
{
    public class UpdateRecordsResultProcessingDto : EntityDto<long>
    {
        public long? DocumentUploadId { get; set; }
        [Required]
        [StringLength(50)]
        public string MaHoSo { get; set; }
        [Required]
        [StringLength(50)]
        public string MaTTHC { get; set; }
        public string MaLinhVuc { get; set; }
        public long? FieldId { get; set; }
        [Required]
        public int LoaiDoiTuong { get; set; }
        [Required]
        public int LoaiDinhDanhCHS { get; set; }
        [StringLength(50)]
        public string MaChuGiayTo { get; set; }
        [Required]
        public DateTime NgayTiepNhan { get; set; }
        [Required]
        public int TrangThai { get; set; }
        [Required]
        public int TrangThaiHoSo { get; set; }
        [Required]
        public int HinhThuc { get; set; }
        [Required]
        [StringLength(50)]
        public string MaCoQuan { get; set; }
        [Required]
        [StringLength(500)]
        public string TenCoQuan { get; set; }

        [Required]
        [StringLength(100)]
        public string MaGiayTo { get; set; }
        [Required]
        [StringLength(5000)]
        public string TenGiayTo { get; set; }
        [Required]
        [StringLength(100)]
        public string KyHieuGiayTo { get; set; }
        [StringLength(5000)]
        public string ThongTinKhac { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime? ThoiHanHieuLuc { get; set; }
        [Required]
        [StringLength(1000)]
        public string PhamViHieuLuc { get; set; }
        [Required]
        public int NoiNopHoSo { get; set; }
        [Required]
        public int HoSoCoThanhPhanSoHoa { get; set; }
        [Required]
        public int DuocThanhToanTrucTuyen { get; set; }
        public DateTime NgayNopHoSo { get; set; }
        public DateTime NgayHenTra { get; set; }
        public DateTime NgayTra { get; set; }
        [Required]
        public int MaCSDLDaKetNoi { get; set; }
        [StringLength(1000)]
        public string TenChuGiayTo { get; set; }
        public DateTime NgaySoHoa { get; set; }
        public IFormFile TepTinSoHoa { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string TenToChuc { get; set; }
        public int? NamThanhLap { get; set; }
    }
}
