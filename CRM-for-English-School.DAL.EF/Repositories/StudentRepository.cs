using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRM_for_English_School.DAL.EF.Groups
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly EnglishSchoolContext _englishSchoolContext;
        public StudentRepository(EnglishSchoolContext englishSchoolContext)
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
            return _englishSchoolContext.Students.Where(predicate).ToList();
        }

        public void Delete(int ID)
        {
            Student student = Get(ID);
            if (student != null)
                _englishSchoolContext.Students.Remove(student);
        }
    }
}
