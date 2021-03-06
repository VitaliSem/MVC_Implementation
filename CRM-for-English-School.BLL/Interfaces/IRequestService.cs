using CRM_for_English_School.AppCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IRequestService : IBaseEntityService<Request>
    {
        Task<int> CountAsync();
        Task<IEnumerable<Request>> TakeRequestsFromPageAsync(int page, int numberOfRequests);
        Task<IEnumerable<Request>> GetRequestsToCourseAsync(int id);
        Task<IEnumerable<Request>> SearchAsync(RequestSearch requestSearch);
    }
}
