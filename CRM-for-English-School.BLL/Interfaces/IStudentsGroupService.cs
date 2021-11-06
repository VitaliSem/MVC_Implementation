using CRM_for_English_School.AppCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IStudentsGroupService : IBaseEntityService<StudentsGroup>
    {
        public Task<int> CreateGroupAsync(StudentsGroup studentsGroup);
        public Task<StudentsGroup> GetStudentsGroupAsync(int id);
        Task<IEnumerable<StudentsGroup>> GetGroupsByTeacherId(int id);
    }
}
