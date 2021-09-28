using CRM_for_English_School.DAL.EF.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using CRM_for_English_School.AppCore.Entities;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class RequestRepository : BaseEntityRepository<Request>
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public RequestRepository(EnglishSchoolContext englishSchoolContext) : base (englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }

        public override IEnumerable<Request> GetAll()
        {
            var requests =  _englishSchoolContext.Requests.Include(r => r.Course).ToList();
            return requests;
        }

        /*
        public async Task<IEnumerable<Request>> GetConfirmedRequests()
        {
            return await _englishSchoolContext.Requests.Where(r => r.RequestStatus.HasFlag(RequestStatus.Confirmed)).ToListAsync();
        }

        public async Task<IEnumerable<Request>> GetPendingRequests()
        {
            return await _englishSchoolContext.Requests.Where(r => r.RequestStatus.HasFlag(RequestStatus.Pending)).ToListAsync();
        }
        */
    }
}
