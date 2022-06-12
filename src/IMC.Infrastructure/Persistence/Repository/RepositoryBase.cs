using System;
using IMC.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace IMC.Infrastructure.Persistence.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> 
        where T : class
    {

        protected IMCDbContext context { get; set; }

        public RepositoryBase(IMCDbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> FindAll()
        {
             return this.context.Set<T>().AsNoTracking();
        }


        public async Task CreateAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>().Where(expression).AsNoTracking();
        }
    }
}
