using QLHSC07.Model.BaseModels;
using QLHSC07.Model.QLHSC07_Dtos.PC07;
using QLHSC07.Model.QLHSC07_Dtos.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsResultProcessings
{
    public class RecordsResultProcessingDto : FullAuditedEntityDto<long>
    {
        public long? RecordsId { get; set; }
        //public RecordsDto Records { get; set; }
        public long? DocumentUploadId { get; set; }
        public string DocumentUploadPath { get; set; }
        public string TenTepTin { get; set; }
        public string MaLinhVuc { get; set; }
        public string KieuDinhDang { get; set; }
        public string MaHoSo { get; set; }
        public string MaTTHC { get; set; }
        public long FieldId { get; set; }
        public int LoaiDoiTuong { get; set; }
        public int LoaiDinhDanhCHS { get; set; }
        public string MaChuGiayTo { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public int TrangThaiHoSo { get; set; }
        public int TrangThai { get; set; }
        public int HinhThuc { get; set; }
        public string MaCoQuan { get; set; }
        public string TenCoQuan { get; set; }
        public string MaGiayTo { get; set; }
        public string TenGiayTo { get; set; }
        public string KyHieuGiayTo { get; set; }
        public string ThongTinKhac { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime ThoiHanHieuLuc { get; set; }
        public string PhamViHieuLuc { get; set; }
        public int NoiNopHoSo { get; set; }
        public int HoSoCoThanhPhanSoHoa { get; set; }
        public int DuocThanhToanTrucTuyen { get; set; }
        public DateTime NgayNopHoSo { get; set; }
        public DateTime NgayHenTra { get; set; }
        public DateTime NgayTra { get; set; }
        public int MaCSDLDaKetNoi { get; set; }
        public string TenChuGiayTo { get; set; }
        public DateTime NgaySoHoa { get; set; }
        public long? PC07LocalId { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string TenToChuc { get; set; }
        public int? NamThanhLap { get; set; }
    }
}
