using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM_for_English_School.AppCore.Entities;

namespace CRM_for_English_School.BLL.Services
{
    public class RequestService : BaseEntityService<Request>, IRequestService
    {
        private readonly IRequestRepository _repository;

        public RequestService(IRequestRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<int> CountAsync()
        {
            return _repository.GetCountAsync();
        }

        public Task<IEnumerable<Request>> GetRequests()
        {
            return _repository.GetAllAsync();
        }

        public Task<IEnumerable<Request>> GetRequestsToCourseAsync(int id)
        {
            return _repository.GetRequestsToCourseAsync(id);
        }

        public Task<IEnumerable<Request>> SearchAsync(RequestSearch requestSearch)
        {
            return _repository.SearchAsync(requestSearch);
        }

        public Task<IEnumerable<Request>> TakeRequestsFromPageAsync(int page, int numberOfRequests)
        {
            return _repository.TakePortion(page, numberOfRequests);
        }
    }
}
