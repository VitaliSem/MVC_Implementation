using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class TeacherRepository : BaseEntityRepository<Teacher>, ITeacherRepository
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public TeacherRepository(EnglishSchoolContext englishSchoolContext) : base(englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }
        public override async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            return await _englishSchoolContext.Teachers.ToListAsync();
        }
        public async Task<Teacher> GetTeacherByUserId(string userId)
        {
            return await _englishSchoolContext.Teachers.FirstOrDefaultAsync(t => t.UserId.ToString() == userId);
        }

    }
}
