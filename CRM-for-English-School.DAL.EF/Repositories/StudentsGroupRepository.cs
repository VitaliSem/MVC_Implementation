using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRM_for_English_School.DAL.EF.Groups
{
    public class StudentsGroupRepository : IRepository<StudentsGroup>
    {
        private readonly EnglishSchoolContext _englishSchoolContext;
        public StudentsGroupRepository(EnglishSchoolContext englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }

        public IEnumerable<StudentsGroup> GetAll()
        {
            return _englishSchoolContext.StudentsGroups;
        }

        public StudentsGroup Get(int ID)
        {
            return _englishSchoolContext.StudentsGroups.Find(ID);
        }

        public void Create(StudentsGroup studentsGroup)
        {
            _englishSchoolContext.StudentsGroups.Add(studentsGroup);
        }

        public void Update(StudentsGroup studentsGroup)
        {
            _englishSchoolContext.Entry(studentsGroup).State = EntityState.Modified;
        }

        public IEnumerable<StudentsGroup> Find(Func<StudentsGroup, bool> predicate)
        {
            return _englishSchoolContext.StudentsGroups.Where(predicate).ToList();
        }

        public void Delete(int ID)
        {
            StudentsGroup studentsGroup = Get(ID);
            if (studentsGroup != null)
                _englishSchoolContext.StudentsGroups.Remove(studentsGroup);
        }
    }
}
