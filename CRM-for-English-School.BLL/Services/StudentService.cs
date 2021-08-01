using AutoMapper;
using CRM_for_English_School.BLL.DataTransferObjects;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.DAL;
using CRM_for_English_School.DAL.Entities;
using CRM_for_English_School.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_for_English_School.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void AddStudent(StudentDataTransferObject studentDTO)
        {
            if (studentDTO != null)
            {
                var student = new Student()
                {
                    StudentID = studentDTO.StudentID,
                    FirstName = studentDTO.FirstName,
                    MiddleName = studentDTO.MiddleName,
                    LastName = studentDTO.LastName,
                    Age = studentDTO.Age,
                    Gender = studentDTO.Gender,
                    CurrentEnglishLevel = studentDTO.CurrentEnglishLevel,
                };

                _unitOfWork.Students.Create(student);
                _unitOfWork.Save();
            }
            else
                throw new ArgumentException("Студент не найден");
        }

        public void EditStudent(StudentDataTransferObject studentDTO)
        {
            if (studentDTO != null)
            {
                var student = new Student()
                {
                    StudentID = studentDTO.StudentID,
                    FirstName = studentDTO.FirstName,
                    MiddleName = studentDTO.MiddleName,
                    LastName = studentDTO.LastName,
                    Age = studentDTO.Age,
                    Gender = studentDTO.Gender,
                    CurrentEnglishLevel = studentDTO.CurrentEnglishLevel,
                };

                _unitOfWork.Students.Update(student);
                _unitOfWork.Save();
            }
            else
                throw new ArgumentException("Студент не найден");
        }

        public void DeleteStudent(int id)
        {
            var student = _unitOfWork.Students.Get(id);
            if (student != null)
            {
                _unitOfWork.Students.Delete(id);
                _unitOfWork.Save();
            }
            else
                throw new ArgumentException("Студент не найден");
        }

        public StudentDataTransferObject GetStudent(int id)
        {
            var student = _unitOfWork.Students.Get(id);
            return new StudentDataTransferObject()
            {
                StudentID = student.StudentID,
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                Age = student.Age,
                Gender = student.Gender,
                CurrentEnglishLevel = student.CurrentEnglishLevel,
                
            };
        }

        public IEnumerable<StudentDataTransferObject> GetStudents()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDataTransferObject>()).CreateMapper();
            return mapper.Map<IEnumerable<Student>, List<StudentDataTransferObject>>(_unitOfWork.Students.GetAll());
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
