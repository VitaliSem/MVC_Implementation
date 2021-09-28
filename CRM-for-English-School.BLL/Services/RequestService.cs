using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM_for_English_School.AppCore.Entities;

namespace CRM_for_English_School.BLL.Services
{
    public class RequestService : BaseEntityService<Request>, IRequestService
    {
        private readonly IRepository<Request> _repository;

        public RequestService(IRepository<Request> repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Request>> GetRequests()
        {
            return await _repository.GetAllAsync();
        }

        /*
        public async Task<IEnumerable<Request>> GetConfirmedRequests()
        {

            var requests = await _repository.GetAllAsync();
            return requests.Where(r => r.RequestStatus.HasFlag(RequestStatus.Confirmed));
        }
        public async Task<IEnumerable<Request>> GetPendingRequests()
        {
            var requests = await _repository.GetAllAsync();
            return requests.Where(r => r.RequestStatus.HasFlag(RequestStatus.Pending));
        }
        */
    }
}
