using Microsoft.AspNetCore.Http;
using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.RecordsResultProcessings
{
    public class SynchronizeRecordsResultProcessingDto : BaseCreateDto
    {
        public string MaHoSo { get; set; }
        public string MaTTHC { get; set; }
        public string MaLinhVuc { get; set; }
        public string LoaiDoiTuong { get; set; }
        public string LoaiDinhDanhCHS { get; set; }
        public string MaChuGiayTo { get; set; }
        public string NgayTiepNhan { get; set; }
        public string TrangThaiHoSo { get; set; }
        public string HinhThuc { get; set; }
        public string MaCoQuan { get; set; }
        public string DonViXuLy { get; set; }
        public string MaGiayToKetQua { get; set; }
        public string TenGiayToKetQua { get; set; }
        public string SoKyHieu { get; set; }
        public string TrichYeuNoiDung { get; set; }
        public string NgayCap { get; set; }
        public string ThoiHanHieuLuc { get; set; }
        public string PhamViHieuLuc { get; set; }
        public string TenFileGiayToKetQuaDinhKem { get; set; }
        public string NoiNopHoSo { get; set; }
        public string HoSoCoThanhPhanSoHoa { get; set; }
        public string DuocThanhToanTrucTuyen { get; set; }
        public string NgayNopHoSo { get; set; }
        public string NgayHenTra { get; set; }
        public string NgayTra { get; set; }
        public string MaCSDLDaKetNoi { get; set; }
    }
}
