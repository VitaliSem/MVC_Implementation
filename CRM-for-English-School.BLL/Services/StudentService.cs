using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Services
{
    public class StudentService : BaseEntityService<Student>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository):base(studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Task<int> CountAsync()
        {
            return _studentRepository.GetCountAsync();
        }
        public Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return _studentRepository.GetAllAsync();
        }

        public Task<IEnumerable<Student>> GetStudentsByGroupId(int id)
        {
            return _studentRepository.GetStudentsByGroupId(id);
        }
        public Task<IEnumerable<Student>> SearchAsync(StudentSearch studentSearch)
        {
            return _studentRepository.SearchAsync(studentSearch);
        }
        public Task<IEnumerable<Student>> TakeStudentsFromPageAsync(int page, int numberOfStudents)
        {
            return _studentRepository.TakePortion(page, numberOfStudents);
        }
    }
}
