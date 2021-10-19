using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Services
{
    public class BaseEntityService<TEntity> : IBaseEntityService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public BaseEntityService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public Task CreateEntityAsync(TEntity entity) => _repository.CreateAsync(entity);

        public Task DeleteEntityAsync(int id) => _repository.DeleteAsync(id);

        public Task EditEntityAsync(TEntity entity) => _repository.UpdateAsync(entity);

        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate) => _repository.FindAsync(predicate);

        public Task<IEnumerable<TEntity>> GetAllAsync() =>_repository.GetAllAsync();
        public Task<TEntity> GetEntityAsync(int id) => _repository.GetAsync(id);
    }
}
