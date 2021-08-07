using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Services
{
    public class StudentService //: IStudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudent(int id)
        {
            return _studentRepository.Get(id);
        }
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                _studentRepository.Create(student);
            }
            else
                throw new ArgumentException("Студент не найден");
        }

        public void EditStudent(Student student)
        {
            if (student != null)
            {
                _studentRepository.Update(student);
            }
            else
                throw new ArgumentException("Студент не найден");
        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.Get(id);
            if (student != null)
            {
                _studentRepository.Delete(id);
            }
            else
                throw new ArgumentException("Студент не найден");
        }
    }
}
