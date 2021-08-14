﻿using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IBaseEntityService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetEntity(int id);
        void CreateEntity(TEntity entity);
        void EditEntity(TEntity entity);
        void DeleteEntity(int id);
    }
}