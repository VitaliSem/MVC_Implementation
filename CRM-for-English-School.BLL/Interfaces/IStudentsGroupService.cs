using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IStudentsGroupService : IBaseEntityService<StudentsGroup>
    {
        public Task<int> CreateGroupAsync(StudentsGroup studentsGroup);
    }
}
