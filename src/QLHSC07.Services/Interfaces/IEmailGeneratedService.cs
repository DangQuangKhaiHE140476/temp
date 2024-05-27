using System;
using System.Threading.Tasks;
using QLHSC07.Data.Repository;
using QLHSC07.Entity;
using QLHSC07.Infrastructure.Interface;
using QLHSC07.Model.EmailGenerated;

namespace QLHSC07.Services.Interfaces
{
    public interface IEmailGeneratedService
    {
       IPagedList<EmailGeneratedViewDto> GetListEmailGenerated(int pageIndex,int pageSize,string sortExpression,string title);
       EmailGeneratedDetailDto GetDetailEmailGenerated(int id);
        DetailEmailContactToAdminDto GetDetailContactAdmin(int id, string authorEmail);
       bool Create(CreateEmailGeneratedDto model);
       IPagedList<EmailContactToAdminDto> GetListEmailGeneratedContactToAdmin(int pageIndex, int pageSize, string sortExpression,int type,string sendFrom,string userName);
       bool UpdateReplyStatus(long userId);
       Task<bool> CreateAsync(CreateEmailGeneratedDto model);
    }
}
