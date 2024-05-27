using QLHSC07.CORE;
using QLHSC07.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QLHSC07.Services.BaseServices
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu của entity</typeparam>
    /// <typeparam name="TEntity">Entity</typeparam>
    /// <typeparam name="TEntityDto">DTO tương ứng với Entity</typeparam>
    /// <typeparam name="TListEntityDto">DTO dùng cho các trường hợp list, không có next object</typeparam>
    /// <typeparam name="TCreateDto">DTO Create</typeparam>
    /// <typeparam name="TUpdateDto">DTO Update</typeparam>
    /// <typeparam name="TFilterDto">DTO filter dữ liệu</typeparam>
    public interface IBaseService<T, TEntity, TEntityDto, TListEntityDto, TCreateDto, TUpdateDto, TFilterDto>: 
        IBaseNoFilterService<T, TEntity, TEntityDto, TListEntityDto, TCreateDto, TUpdateDto>
    {
        Task<IPagedList<TListEntityDto>> GetAll(TFilterDto filter);
        Task<ICollection<TListEntityDto>> GetAllNoPage(TFilterDto filter);
    }
}
