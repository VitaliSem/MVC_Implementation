using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IBaseEntityService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        Task <IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
        TEntity GetEntity(int id);
        void CreateEntity(TEntity entity);
        void EditEntity(TEntity entity);
        void DeleteEntity(int id);
    }
}
