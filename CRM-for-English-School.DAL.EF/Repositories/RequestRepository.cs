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

        public override async Task<IEnumerable<Request>> GetAllAsync()
        {
            return await _englishSchoolContext.Requests.Include(r => r.Course).ToListAsync();
        }

        public async Task<IEnumerable<Request>> TakePortion(int pageNumber, int pageSize)
        {
            return await _englishSchoolContext.Requests.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Request>> GetRequestsByCourseAsync(int id)
        {
            return await _englishSchoolContext.Requests.Where(r => r.CourseId == id).ToListAsync();
        }

        public async Task<List<Request>> SearchAsync(RequestSearch requestSearch)
        {
            var requests = _englishSchoolContext.Requests.AsQueryable();
            if (!string.IsNullOrWhiteSpace(requestSearch.FirstName))
                requests = requests.Where(r => Microsoft.EntityFrameworkCore.EF.Functions.Like(r.FirstName, requestSearch.FirstName));
            if (!string.IsNullOrWhiteSpace(requestSearch.LastName))
                requests = requests.Where(r => Microsoft.EntityFrameworkCore.EF.Functions.Like(r.LastName, requestSearch.LastName));
            if (requestSearch.AgeLowBorder.HasValue)
            {
                if (requestSearch.AgeHighBorder.HasValue && requestSearch.AgeHighBorder.Value < requestSearch.AgeLowBorder.Value)
                    throw new ArgumentException("Значение верхней границы возраста задано некорректно!");
                requests = requests.Where(r => r.Age >= requestSearch.AgeLowBorder.Value);
            }
            if (requestSearch.AgeHighBorder.HasValue)
            {
                if (requestSearch.AgeLowBorder.HasValue && requestSearch.AgeLowBorder.Value > requestSearch.AgeHighBorder.Value)
                    throw new ArgumentException("Значение нижней границы возраста задано некорректно!");
                requests = requests.Where(r => r.Age <= requestSearch.AgeHighBorder.Value);
            }
            if (requestSearch.CourseId.HasValue)
                requests = requests.Where(r => r.CourseId.Value == requestSearch.CourseId);
            if (requestSearch.EnglishLevel?.Length > 0)
                requests = requests.Where(r => requestSearch.EnglishLevel.Contains(r.CurrentEnglishLevel.Value));
            var result = await requests.ToListAsync();
            return result;
        }

        public async Task<int> GetCountAsync()
        {
            return await _englishSchoolContext.Requests.CountAsync();
        }
    }
}
