using CRM_for_English_School.AppCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.Interfaces
{
    public interface IRequestRepository : IRepository<Request>
    {
        Task<int> GetCountAsync();
        Task<IEnumerable<Request>> GetRequestsByCourseAsync(int id);
        Task<IEnumerable<Request>> TakePortion(int pageNumber, int pageSize);
        Task<IEnumerable<Request>> SearchAsync(RequestSearch requestSearch);
    }
}
