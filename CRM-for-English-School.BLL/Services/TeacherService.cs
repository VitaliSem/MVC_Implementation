using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> _teacherRepository;

        public TeacherService(IRepository<Teacher> teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return _teacherRepository.GetAll();
        }

        public Teacher GetTeacher(int id)
        {
            return _teacherRepository.Get(id);
        }
        public void AddTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                _teacherRepository.Create(teacher);
            }
            else
                throw new ArgumentException("Преподаватель не найден");
        }

        public void EditTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                _teacherRepository.Update(teacher);
            }
            else
                throw new ArgumentException("Препоадаватель не найден");
        }

        public void DeleteTeacher(int id)
        {
            var teacher = _teacherRepository.Get(id);
            if (teacher != null)
            {
                _teacherRepository.Delete(id);
            }
            else
                throw new ArgumentException("Преподаватель не найден");
        }
    }
}
