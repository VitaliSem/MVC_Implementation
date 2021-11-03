using CRM_for_English_School.AppCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<int> GetCountAsync();
        Task<IEnumerable<Student>> GetStudentsByGroupId(int id);
        Task<IEnumerable<Student>> TakePortion(int pageNumber, int pageSize);
        Task<IEnumerable<Student>> SearchAsync(StudentSearch studentSearch);
    }
}
