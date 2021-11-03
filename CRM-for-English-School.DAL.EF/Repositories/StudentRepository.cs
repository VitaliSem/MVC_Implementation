using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class StudentRepository : BaseEntityRepository<Student>, IStudentRepository
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public StudentRepository(EnglishSchoolContext englishSchoolContext):base(englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }
        public override async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _englishSchoolContext.Students.Include(s => s.Group).ToListAsync();
        }

        public async Task<IEnumerable<Student>> GetStudentsByGroupId(int id)
        {
            return await _englishSchoolContext.Students.Where(s => s.GroupId == id).ToListAsync();
        }
    }
}
