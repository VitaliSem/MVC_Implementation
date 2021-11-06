using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Services
{
    public class TeacherService : BaseEntityService<Teacher>, ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository) : base(teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public Task<Teacher> GetTeacherByUserId(string userId)
        {
            return _teacherRepository.GetTeacherByUserId(userId);
        }

        public Task<IEnumerable<Teacher>> GetTeachersAsync()
        {
            return _teacherRepository.GetAllAsync();
        }
    }
}
