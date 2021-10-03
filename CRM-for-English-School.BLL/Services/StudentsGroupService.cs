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

        public async Task<IEnumerable<StudentsGroup>> GetStudentsGroups()
        {
            var studentsGroups = await _studentsGroupRepository.GetAllAsync();
            return studentsGroups;
        }
    }
}
