using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teama.Domain.Common;
using Teama.Domain.Repositories.Base;

namespace Teama.Infrastructure.Persistence.Base
{
    public class Repository<T> : IRepository<T> where T : AuditableEntity
    {
        protected readonly TeamaContext _TeamaContext;

        public Repository(TeamaContext teamaContext)
        {
            _TeamaContext = teamaContext;
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            //T can be movie or moviereview
            return await _TeamaContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _TeamaContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            await _TeamaContext.Set<T>().AddAsync(entity);
            await _TeamaContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _TeamaContext.Entry(entity).State = EntityState.Modified;
            await _TeamaContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _TeamaContext.Set<T>().Remove(entity);
            await _TeamaContext.SaveChangesAsync();
        }

    }
}
