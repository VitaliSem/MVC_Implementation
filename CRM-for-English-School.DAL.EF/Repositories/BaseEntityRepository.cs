using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class BaseEntityRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly EnglishSchoolContext _englishSchoolContext;
        private readonly DbSet<TEntity> _entities;

        public BaseEntityRepository(EnglishSchoolContext englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
            _entities = englishSchoolContext.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity item)
        {
            var entity = await _englishSchoolContext.AddAsync(item);
            entity.State = EntityState.Added;
            await _englishSchoolContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = _englishSchoolContext.Find<TEntity>(id);
            if (entity != null)
                _englishSchoolContext.Remove(entity).State = EntityState.Deleted;
            await _englishSchoolContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate) =>
            await _entities
            .AsNoTracking()
            .AsEnumerable()
            .Where(predicate)
            .AsQueryable()
            .ToListAsync();

        public async Task<TEntity> GetAsync(int id) => await _entities.FindAsync(id);

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _entities.ToListAsync();

        public async Task UpdateAsync(TEntity item)
        {
            _englishSchoolContext.Entry(item).State = EntityState.Modified;
            await _englishSchoolContext.SaveChangesAsync();
        }
    }
}
