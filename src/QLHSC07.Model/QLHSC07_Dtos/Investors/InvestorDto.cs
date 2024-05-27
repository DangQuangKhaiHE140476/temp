using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Investors
{
    public class InvestorDto : FullAuditedEntityDto<long>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ProvinceId { get; set; }
        public string ProvinceName { get; set; }

        public string DistrictId { get; set; }
        public string DistrictName { get; set; }

        public string CommuneId { get; set; }
        public string CommuneName { get; set; }
    }
}
