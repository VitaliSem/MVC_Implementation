using CRM_for_English_School.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IWorkingProcess<Student> Students { get; }

        void Save();

        void Dispose();
    }
}
