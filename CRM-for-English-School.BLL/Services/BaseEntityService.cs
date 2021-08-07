using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.Services
{
    class BaseEntityService<TEntity> : IBaseEntityService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public BaseEntityService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public void CreateEntity(TEntity entity) => _repository.Create(entity);

        public void DeleteEntity(int id) => _repository.Delete(id);

        public void EditEntity(TEntity entity) => _repository.Update(entity);

        public IEnumerable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetEntity(int id) => _repository.Get(id);
    }
}
