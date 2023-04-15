using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Repository.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindById(int id);
        Task<IEnumerable<T>> FindAll(bool trackChanges);
        Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
