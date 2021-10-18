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

        public Task<IEnumerable<Request>> GetRequests()
        {
            return _repository.GetAllAsync();
        }

        public Task<IEnumerable<Request>> GetRequestsByCourseAsync(int id)
        {
            return _repository.GetRequestsByCourseAsync(id);
        }

        public Task<IEnumerable<Request>> SearchAsync(RequestSearch requestSearch)
        {
            return _repository.SearchAsync(requestSearch);
        }
    }
}
