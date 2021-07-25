using CRM_for_English_School.DAL.Context;
using CRM_for_English_School.DAL.Entities;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_for_English_School.DAL.Groups
{
    public class StudentsGroup : IWorkingProcess<Student>
    {
        private readonly EnglishSchoolContext _englishSchoolContext;
        public StudentsGroup(EnglishSchoolContext englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }

        public IEnumerable<Student> GetAll()
        {
            return _englishSchoolContext.Students;
        }

        public Student Get(int ID)
        {
            return _englishSchoolContext.Students.Find(ID);
        }

        public void Create(Student student)
        {
            _englishSchoolContext.Students.Add(student);
        }

        public void Update(Student student)
        {
            _englishSchoolContext.Entry(student).State = EntityState.Modified;
        }

        public IEnumerable<Student> Find(Func<Student, bool> predicate)
        {
            return _englishSchoolContext.Students.Where(predicate).ToArray();
        }

        public void Delete(int ID)
        {
            Student student = Get(ID);
            if (student != null)
                _englishSchoolContext.Students.Remove(student);
        }
    }
}
