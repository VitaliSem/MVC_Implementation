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
        public void CreateEntity(TEntity entity) => _repository.Create(entity);

        public void DeleteEntity(int id) => _repository.Delete(id);

        public void EditEntity(TEntity entity) => _repository.Update(entity);

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate) => _repository.Find(predicate);

        public IEnumerable<TEntity> GetAll() => _repository.GetAll();

        public Task<IEnumerable<TEntity>> GetAllAsync() =>_repository.GetAllAsync();
        public TEntity GetEntity(int id) => _repository.Get(id);
    }
}
