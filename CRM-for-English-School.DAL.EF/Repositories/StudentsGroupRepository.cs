using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class StudentsGroupRepository : BaseEntityRepository<StudentsGroup>, IStudentsGroupRepository
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public StudentsGroupRepository(EnglishSchoolContext englishSchoolContext) : base(englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }
        public override IEnumerable<StudentsGroup> Find(Func<StudentsGroup, bool> predicate)
        {
            return _englishSchoolContext.StudentsGroups.Include(g => g.Teacher).Include(g => g.Students).Where(predicate);
        }
        public override async Task<IEnumerable<StudentsGroup>> GetAllAsync()
        {
            return await _englishSchoolContext.StudentsGroups.Include(g => g.Teacher).Include(g => g.Students).ToListAsync();
        }
        public async Task<int> CreateGroupAsync(StudentsGroup studentsGroup)
        {
            var entity = await _englishSchoolContext.AddAsync(studentsGroup);
            entity.State = EntityState.Added;
            await _englishSchoolContext.SaveChangesAsync();
            return entity.Entity.Id;
        }

        public async Task<StudentsGroup> GetStudentsGroupAsync(int id)
        {
            return await _englishSchoolContext.StudentsGroups
                .Include(g => g.Teacher)
                .Include(g => g.Students)
                .FirstAsync(g => g.Id == id);
        }
    }
}
