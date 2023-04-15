using CNET_V7_Domain.Misc;
using CNET_V7_Entities.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Service.Contracts
{
    public interface IService<T> where T : class
    {
        Task<ResponseModel<IEnumerable<T>>> FindAll(bool trackChanges);
        Task<ResponseModel<T>> Create(T entity);
        Task<ResponseModel<T>> Update(T entity);
        Task<ResponseModel<T>> Delete(int id);
        Task<ResponseModel<T>> FindById(int id);
    }
}
