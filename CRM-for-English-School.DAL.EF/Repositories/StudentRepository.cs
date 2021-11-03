using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_for_English_School.DAL.EF.Repositories
{
    public class StudentRepository : BaseEntityRepository<Student>, IStudentRepository
    {
        private readonly EnglishSchoolContext _englishSchoolContext;

        public StudentRepository(EnglishSchoolContext englishSchoolContext):base(englishSchoolContext)
        {
            _englishSchoolContext = englishSchoolContext;
        }
        public override async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _englishSchoolContext.Students.Include(s => s.Group).ToListAsync();
        }

        public async Task<IEnumerable<Student>> GetStudentsByGroupId(int id)
        {
            return await _englishSchoolContext.Students.Where(s => s.GroupId == id).ToListAsync();
        }
        public async Task<IEnumerable<Student>> TakePortion(int pageNumber, int pageSize)
        {
            return await _englishSchoolContext.Students.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }
        public async Task<IEnumerable<Student>> SearchAsync(StudentSearch studentSearch)
        {
            var students = _englishSchoolContext.Students.AsQueryable();
            if (!string.IsNullOrWhiteSpace(studentSearch.FirstName))
                students = students.Where(s => Microsoft.EntityFrameworkCore.EF.Functions.Like(s.FirstName, studentSearch.FirstName));
            if (!string.IsNullOrWhiteSpace(studentSearch.LastName))
                students = students.Where(s => Microsoft.EntityFrameworkCore.EF.Functions.Like(s.LastName, studentSearch.LastName));
            if (studentSearch.AgeLowBorder.HasValue)
            {
                if (studentSearch.AgeHighBorder.HasValue && studentSearch.AgeHighBorder.Value < studentSearch.AgeLowBorder.Value)
                    throw new ArgumentException("Значение верхней границы возраста задано некорректно!");
                students = students.Where(s => s.Age >= studentSearch.AgeLowBorder.Value);
            }
            if (studentSearch.AgeHighBorder.HasValue)
            {
                if (studentSearch.AgeLowBorder.HasValue && studentSearch.AgeLowBorder.Value > studentSearch.AgeHighBorder.Value)
                    throw new ArgumentException("Значение нижней границы возраста задано некорректно!");
                students = students.Where(s => s.Age <= studentSearch.AgeHighBorder.Value);
            }
            if (studentSearch.GroupId.HasValue)
                students = students.Where(s => s.GroupId.Value == studentSearch.GroupId);
            if (studentSearch.Status != 0)
                students = students.Where(s => s.Status == studentSearch.Status);
            if (studentSearch.EnglishLevel?.Length > 0)
                students = students.Where(s => studentSearch.EnglishLevel.Contains(s.CurrentEnglishLevel));
            var result = await students.ToListAsync();
            return result;
        }
        public async Task<int> GetCountAsync()
        {
            return await _englishSchoolContext.Students.CountAsync();
        }
    }
}
