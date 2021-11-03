using CRM_for_English_School.AppCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IStudentService : IBaseEntityService<Student>
    {
        Task<int> CountAsync();
        Task<IEnumerable<Student>> GetStudentsByGroupId(int id);
        Task<IEnumerable<Student>> TakeStudentsFromPageAsync(int page, int numberOfStudents);
        Task<IEnumerable<Student>> SearchAsync(StudentSearch studentSearch);
    }
}
