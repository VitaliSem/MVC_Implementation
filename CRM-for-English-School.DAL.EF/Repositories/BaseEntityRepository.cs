﻿using CRM_for_English_School.DAL.EF.Context;
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

        public void Create(TEntity item)
        {
            _englishSchoolContext.Add(item).State = EntityState.Added;
            _englishSchoolContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _englishSchoolContext.Find<TEntity>(id);
            if (entity != null)
                _englishSchoolContext.Remove(entity).State = EntityState.Deleted;
            _englishSchoolContext.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate) => 
            _entities
                .AsNoTracking()
                .AsEnumerable()
                .Where(predicate)
                .ToList();

        public TEntity Get(int id) => _entities.Find(id);

        public virtual IEnumerable<TEntity> GetAll() => _entities.ToList();

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _entities.ToListAsync();

        public void Update(TEntity item)
        {
            _englishSchoolContext.Entry(item).State = EntityState.Modified;
            _englishSchoolContext.SaveChanges();
        }
    }
}
