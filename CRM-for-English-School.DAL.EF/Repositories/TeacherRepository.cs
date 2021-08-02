using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRM_for_English_School.DAL.EF.Groups
{
    public class TeacherRepository : IRepository<Teacher>
    {
        private readonly EnglishSchoolContext _englishSchoolContext;
        public TeacherRepository(EnglishSchoolContext englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _englishSchoolContext.Teachers;
        }

        public Teacher Get(int ID)
        {
            return _englishSchoolContext.Teachers.Find(ID);
        }

        public void Create(Teacher teacher)
        {
            _englishSchoolContext.Teachers.Add(teacher);
        }

        public void Update(Teacher teacher)
        {
            _englishSchoolContext.Entry(teacher).State = EntityState.Modified;
        }

        public IEnumerable<Teacher> Find(Func<Teacher, bool> predicate)
        {
            return _englishSchoolContext.Teachers.Where(predicate).ToList();
        }

        public void Delete(int ID)
        {
            Teacher teacher = Get(ID);
            if (teacher != null)
                _englishSchoolContext.Teachers.Remove(teacher);
        }
    }
}
