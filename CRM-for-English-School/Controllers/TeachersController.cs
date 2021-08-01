using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherervice)
        {
            _teacherService = teacherervice;
        }
        public IActionResult Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Teacher, TeacherModel>());
            var mapper = new Mapper(config);
            var teacher = mapper.Map<IEnumerable<StudentModel>>(_teacherService.GetTeachers());
            return View(teacher);
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(TeacherModel teacherModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TeacherModel, Teacher>());
            var mapper = new Mapper(config);
            var teacher = mapper.Map<TeacherModel, Teacher>(teacherModel);
            _teacherService.AddTeacher(teacher);

            return RedirectToAction("Index", "Teachers");
        }

        [HttpGet]
        public IActionResult EditTeacher(int id)
        {
            var student = _teacherService.GetTeacher(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Teacher, TeacherModel>());
            var mapper = new Mapper(config);
            var member = mapper.Map<Teacher, TeacherModel>(_teacherService.GetTeacher(id));
            return View(member);
        }

        [HttpPost]
        public IActionResult EditTeacher(TeacherModel teacherModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TeacherModel, Teacher>());
            var mapper = new Mapper(config);
            var teacher = mapper.Map<TeacherModel, Teacher>(teacherModel);
            _teacherService.EditTeacher(teacher);

            return RedirectToAction("Index", "Teachers");
        }

        [HttpGet]
        public IActionResult DeleteTeacher(int id)
        {
            _teacherService.DeleteTeacher(id);
            return RedirectToAction("Index", "Teachers");
        }
    }
}
