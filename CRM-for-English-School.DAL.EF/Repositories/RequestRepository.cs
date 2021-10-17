using CRM_for_English_School.DAL.EF.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.Interfaces;
using System.Threading.Tasks;
using System;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class RequestRepository : BaseEntityRepository<Request>, IRequestRepository
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public RequestRepository(EnglishSchoolContext englishSchoolContext) : base(englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }

        public override IEnumerable<Request> GetAll()
        {
            var requests = _englishSchoolContext.Requests.Include(r => r.Course).ToList();
            return requests;
        }

        public async Task<IEnumerable<Request>> GetRequestsByCourse(int id)
        {
            return await _englishSchoolContext.Requests.Where(r => r.CourseId == id).ToListAsync();
        }

        public async Task<IEnumerable<Request>> SearchAsync(RequestSearch requestSearch)
        {
            var requests = _englishSchoolContext.Requests.AsQueryable();
            if (!string.IsNullOrWhiteSpace(requestSearch.FirstName))
                requests = requests.Where(r => Microsoft.EntityFrameworkCore.EF.Functions.Like(r.FirstName, requestSearch.FirstName));
            if (!string.IsNullOrWhiteSpace(requestSearch.LastName))
                requests = requests.Where(r => Microsoft.EntityFrameworkCore.EF.Functions.Like(r.LastName, requestSearch.LastName));
            if (requestSearch.AgeLowBorder.HasValue)
                requests = requests.Where(r => r.BirthDate.Year <= (DateTime.Now.Year - requestSearch.AgeLowBorder.Value));
            if (requestSearch.AgeHighBorder.HasValue)
                requests = requests.Where(r => r.BirthDate.Year >= (DateTime.Now.Year - requestSearch.AgeHighBorder.Value));
            if (requestSearch.CourseId.HasValue)
                requests = requests.Where(r => r.CourseId.Value == requestSearch.CourseId);
            if (requestSearch.EnglishLevel.Length != 0)
            {
                requests = requests.Where(r => requestSearch.EnglishLevel.Contains(r.CurrentEnglishLevel.Value));
            }
            var result = await requests.ToListAsync();
            return result;
        }
    }
}
