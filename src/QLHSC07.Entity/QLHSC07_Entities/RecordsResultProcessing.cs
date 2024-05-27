using QLHSC07.CORE.Helper;
using QLHSC07.Entity.Administrative;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.RecordsResultProcessing, Schema = Constant.Schema.QLHSC07)]
    public class RecordsResultProcessing : BaseFullAuditedEntity<long>
    {
        [Column("records_id")]
        public long? RecordsId { get; set; }
        [ForeignKey(nameof(RecordsId))]
        public Records Records { get; set; }
        [Column("document_upload_id")]
        public long? DocumentUploadId { get; set; }
        [ForeignKey(nameof(DocumentUploadId))]
        public DocumentUpload DocumentUpload { get; set; }

        [Column("ten_chu_giay_to")]
        [StringLength(1000)]
        public string TenChuGiayTo { get; set; }
        [Column("ngay_so_hoa")]
        public DateTime NgaySoHoa { get; set; }
        //update
        [Required]
        [Column("ma_ho_so")]
        [StringLength(50)]
        public string MaHoSo { get; set; }
        [Required]
        [Column("ma_tthc")]
        [StringLength(50)]
        public string MaTTHC { get; set; }
        [Required]
        [Column("ma_linh_vuc")]
        [StringLength(50)]
        public string MaLinhVuc { get; set; }
        //[Column("field_id")]
        //public long? FieldId { get; set; }
        //[ForeignKey(nameof(FieldId))]
        //public Field Field { get; set; }

        [Required]
        [Column("loai_doi_tuong")]
        public int LoaiDoiTuong { get; set; }
        [Required]
        [Column("loai_dinh_danh_chs")]
        public int LoaiDinhDanhCHS { get; set; }
        [Column("ma_chu_giay_to")]
        [StringLength(50)]
        //SoDinhDanhCHS
        public string MaChuGiayTo { get; set; }
        [Required]
        [Column("ngay_tiep_nhan")]
        public DateTime NgayTiepNhan { get; set; }
        [Required]
        [Column("trang_thai")]
        public int TrangThai { get; set; }
        [Required]
        [Column("trang_thai_ho_so")]
        public string TrangThaiHoSo { get; set; }
        [Required]
        [Column("hinh_thuc")]
        public int HinhThuc { get; set; }
        [Column("ma_co_quan")]
        [StringLength(50)]
        public string MaCoQuan { get; set; }
        [Column("ten_co_quan")]
        [StringLength(500)]
        //DonViXuLy
        public string TenCoQuan { get; set; }
        [Required]
        [Column("ten_giay_to")]
        [StringLength(5000)]
        public string TenGiayTo { get; set; }
        [Required]
        [Column("ma_giay_to")]
        [StringLength(100)]
        public string MaGiayTo { get; set; }
        [Required]
        [Column("ky_hieu_giay_to")]
        [StringLength(100)]
        public string KyHieuGiayTo { get; set; }
        [Column("thong_tin_khac")]
        [StringLength(5000)]
        public string ThongTinKhac { get; set; }
        [Required]
        [Column("ngay_cap")]
        public DateTime NgayCap { get; set; }
        [Required]
        [Column("thoi_han_hieu_luc")]
        public DateTime ThoiHanHieuLuc { get; set; }
        [Required]
        [Column("pham_vi_hieu_luc")]
        [StringLength(100)]
        public string PhamViHieuLuc { get; set; }
        [Required]
        [Column("noi_nop_ho_so")]
        public int NoiNopHoSo { get; set; }
        [Required]
        [Column("ho_so_co_thanh_phan_so_hoa")]
        public int HoSoCoThanhPhanSoHoa { get; set; }
        [Required]
        [Column("duoc_thanh_toan_truc_tuyen")]
        public int DuocThanhToanTrucTuyen { get; set; }
        [Required]
        [Column("ngay_nop_ho_so")]
        public DateTime NgayNopHoSo { get; set; }
        [Required]
        [Column("ngay_hen_tra")]
        public DateTime NgayHenTra { get; set; }
        [Column("ngay_tra")]
        public DateTime NgayTra { get; set; }
        [Required]
        [Column("ma_csdl_da_ket_noi")]
        public int MaCSDLDaKetNoi { get; set; }
        [Column("pc07_local_id")]
        public long PC07LocalId { get; set; }
        [Column("ngay_sinh")]
        public DateTime? NgaySinh { get; set; }
        [Column("ten_to_chuc")]
        public string TenToChuc { get; set; }
        [Column("nam_thanh_lap")]
        public int? NamThanhLap { get; set; }
    }
}
