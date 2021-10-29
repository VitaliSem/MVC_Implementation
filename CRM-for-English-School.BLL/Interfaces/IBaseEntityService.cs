using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IBaseEntityService<TEntity>
    {
        Task <IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
        Task<TEntity> GetEntityAsync(int id);
        Task CreateEntityAsync(TEntity entity);
        Task EditEntityAsync(TEntity entity);
        Task DeleteEntityAsync(int id);
    }
}
