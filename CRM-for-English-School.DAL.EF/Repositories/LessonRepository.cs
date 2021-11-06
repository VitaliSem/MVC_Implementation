using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class LessonRepository : BaseEntityRepository<Lesson>, ILessonRepository
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public LessonRepository(EnglishSchoolContext englishSchoolContext) : base(englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }
        public override async Task<IEnumerable<Lesson>> GetAllAsync()
        {
            return await _englishSchoolContext.Lessons.Include(c => c.Group).ToListAsync();
        }
    }
}
