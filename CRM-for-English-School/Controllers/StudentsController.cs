using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using CRM_for_English_School.BLL.Entities;
using Microsoft.AspNetCore.Authorization;

namespace CRM_for_English_School.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly IBaseEntityService<Student> _studentService;
        private readonly IMapper _mapper;

        public StudentsController(IBaseEntityService<Student> studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(_mapper.Map<IEnumerable<StudentModel>>(students));
        }

        [Authorize(Roles = "manager")]
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _studentService.CreateEntity(_mapper.Map<Student>(studentModel));
                return RedirectToAction("Index", "Students");
            }
            return View(studentModel);
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = _studentService.GetEntity(id);
            return View(_mapper.Map<StudentModel>(student));
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _studentService.EditEntity(_mapper.Map<Student>(studentModel));
                return RedirectToAction("Index", "Students");
            }
            return View(studentModel);
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            _studentService.DeleteEntity(id);
            return RedirectToAction("Index", "Students");
        }
    }
}
