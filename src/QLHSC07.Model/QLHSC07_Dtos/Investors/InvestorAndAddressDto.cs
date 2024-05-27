using QLHSC07.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Investors
{
    public class InvestorAndAddressDto : BaseLookupDto<long>
    {
        public string Address { get; set; }
    }
}
