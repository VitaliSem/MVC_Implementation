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

        public async Task<IEnumerable<Request>> GetRequests()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<Request>> GetRequestsByCourse(int id)
        {
            return await _repository.GetRequestsByCourse(id);
        }

        public async Task<IEnumerable<Request>> SearchAsync(RequestSearch requestSearch)
        {
            return await _repository.SearchAsync(requestSearch);
        }
    }
}
