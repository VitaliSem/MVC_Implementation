using CRM_for_English_School.DAL.Context;
using CRM_for_English_School.DAL.Entities;
using CRM_for_English_School.DAL.Groups;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        private StudentsGroup _studentsGroup;

        public UnitOfWork()
        {
            _englishSchoolContext = new EnglishSchoolContext();
        }

        public IWorkingProcess<Student> Students
        {
            get
            {
                if (_studentsGroup == null)
                    _studentsGroup = new StudentsGroup(_englishSchoolContext);

                return _studentsGroup;
            }
        }

        public void Save()
        {
            _englishSchoolContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _englishSchoolContext.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
