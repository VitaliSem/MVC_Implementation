using CRM_for_English_School.AppCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IStudentService : IBaseEntityService<Student>
    {
        public Task<IEnumerable<Student>> GetStudentsByGroupId(int id);
    }
}
