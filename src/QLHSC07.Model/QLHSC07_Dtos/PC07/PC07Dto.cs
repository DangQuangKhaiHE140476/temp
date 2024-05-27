using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.PC07
{
    public class PC07Dto : FullAuditedEntityDto<long>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int CommuneId { get; set; }
        public string CommuneName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }

    }
}
