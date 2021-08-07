using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Services
{
    public class StudentsGroupService //: IStudentsGroupService
    {
        private readonly IRepository<StudentsGroup> _studentsGroupRepository;

        public StudentsGroupService(IRepository<StudentsGroup> studentsGroupRepository)
        {
            _studentsGroupRepository = studentsGroupRepository;
        }

        public IEnumerable<StudentsGroup> GetAllGroups()
        {
            return _studentsGroupRepository.GetAll();
        }

        public StudentsGroup GetStudentsGroup(int id)
        {
            return _studentsGroupRepository.Get(id);
        }
        public void AddStudentsGroup(StudentsGroup studentsGroup)
        {
            if (studentsGroup != null)
            {
                _studentsGroupRepository.Create(studentsGroup);
            }
            else
                throw new ArgumentException("Группа не найден");
        }

        public void EditStudentsGroup(StudentsGroup studentsGroup)
        {
            if (studentsGroup != null)
            {
                _studentsGroupRepository.Update(studentsGroup);
            }
            else
                throw new ArgumentException("Группа не найден");
        }

        public void DeleteStudentsGroup(int id)
        {
            var studentsGroup = _studentsGroupRepository.Get(id);
            if (studentsGroup != null)
            {
                _studentsGroupRepository.Delete(id);
            }
            else
                throw new ArgumentException("Группа не найден");
        }
    }
}
