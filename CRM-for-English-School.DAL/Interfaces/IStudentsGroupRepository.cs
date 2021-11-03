using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.Interfaces
{
    public interface IStudentsGroupRepository : IRepository<StudentsGroup>
    {
        public Task<int> CreateGroupAsync(StudentsGroup studentsGroup);
        public Task<StudentsGroup> GetStudentsGroupAsync(int id);
    }
}
