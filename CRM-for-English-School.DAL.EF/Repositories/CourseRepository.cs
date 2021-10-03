using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class CourseRepository : BaseEntityRepository<Course>, ICourseRepository
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public CourseRepository(EnglishSchoolContext englishSchoolContext) : base(englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }

        public override async Task<IEnumerable<Course>> GetAllAsync()
        {
            var courses = await _englishSchoolContext.Courses.Include(c => c.Requests).ToListAsync();
            return courses;
        }
    }
}
