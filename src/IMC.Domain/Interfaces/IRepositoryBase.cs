using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IMC.Domain.Interfaces
{
    internal interface IRepositoryBase<T>
    {
        Task<IQueryable<T>> FindAllAsync();
        Task<IQueryable<T>> FindByConditionAsync(Expression<Func<Task, bool>> expression);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
