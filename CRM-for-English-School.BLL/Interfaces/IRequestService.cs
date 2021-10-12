using CRM_for_English_School.AppCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Interfaces
{
    public interface IRequestService : IBaseEntityService<Request>
    {
        Task<IEnumerable<Request>> GetRequestsByCourse(int id);
        Task<IEnumerable<Request>> SearchAsync(RequestSearch requestSearch);
    }
}
