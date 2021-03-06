using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.BLL.Services
{
    public class StudentsGroupService : BaseEntityService<StudentsGroup>, IStudentsGroupService
    {
        private readonly IStudentsGroupRepository _studentsGroupRepository;
        public StudentsGroupService(IStudentsGroupRepository studentsGroupRepository) : base(studentsGroupRepository)
        {
            _studentsGroupRepository = studentsGroupRepository;
        }

        public Task<int> CreateGroupAsync(StudentsGroup studentsGroup)
        {
            return _studentsGroupRepository.CreateGroupAsync(studentsGroup);
        }

        public Task<StudentsGroup> GetStudentsGroupAsync(int id)
        {
            return _studentsGroupRepository.GetStudentsGroupAsync(id);
        }

        public Task<IEnumerable<StudentsGroup>> GetStudentsGroupsAsync()
        {
            return _studentsGroupRepository.GetAllAsync();
        }
        public Task<IEnumerable<StudentsGroup>> GetGroupsByTeacherId(int id)
        {
            return _studentsGroupRepository.GetGroupsByTeacherId(id);
        }
    }
}
