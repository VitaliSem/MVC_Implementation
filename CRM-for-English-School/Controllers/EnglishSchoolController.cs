using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using CRM_for_English_School.BLL.DataTransferObjects;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.BLL.Services;
using CRM_for_English_School.Models;

namespace CRM_for_English_School.Controllers
{
    public class EnglishSchoolController : Controller
    {
        private readonly IStudentService _studentService;

        public EnglishSchoolController()
        {
            _studentService = new StudentService();
        }
        public IActionResult Index()
        {
            var studentDTOs = _studentService.GetStudents();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<StudentDataTransferObject, StudentModel>()).CreateMapper();
            var students = mapper.Map<IEnumerable<StudentDataTransferObject>, List<StudentModel>>(studentDTOs);
            return View(students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentModel student)
        {
            _studentService.AddStudent(new StudentDataTransferObject()
            {
                StudentID = student.StudentID,
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                Age = student.Age,
                Gender = student.Gender,
                CurrentEnglishLevel = student.CurrentEnglishLevel,
            });

            return RedirectToAction("Index", "EnglishSchool");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var StudentDTO = _studentService.GetStudent(id);

            var student = new StudentModel()
            {
                StudentID = StudentDTO.StudentID,
                FirstName = StudentDTO.FirstName,
                MiddleName = StudentDTO.MiddleName,
                LastName = StudentDTO.LastName,
                Age = StudentDTO.Age,
                Gender = StudentDTO.Gender,
                CurrentEnglishLevel = StudentDTO.CurrentEnglishLevel,
            };
            return View(student);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel student)
        {
            _studentService.EditStudent(new StudentDataTransferObject()
            {
                StudentID = student.StudentID,
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                Age = student.Age,
                Gender = student.Gender,
                CurrentEnglishLevel = student.CurrentEnglishLevel,
            });

            return RedirectToAction("Index", "EnglishSchool");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index", "EnglishSchool");
        }
    }
}
