using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QLHSC07.CORE;
using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.Investors;
using QLHSC07.Model.QLHSC07_Dtos.Projects;
using QLHSC07.Services.BaseServices;
namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IInvestorService : IBaseService<long, Investor, InvestorDto, InvestorDto, CreateInvestorDto, UpdateInvestorDto, FilterInvestorDto>
    {
        IList<InvestorsLookupDto> GetLookupInvestors();
        Task<ResponseItem<InvestorDto>> CreateReturnInvestor(CreateInvestorDto request);
        IList<InvestorAndAddressDto> GetInvestorAndAddress();
    }
}
