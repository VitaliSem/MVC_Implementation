using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using CRM_for_English_School.BLL.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace CRM_for_English_School.Controllers
{
    [Authorize]
    public class TeachersController : Controller
    {
        private readonly IBaseEntityService<Teacher> _teacherService;
        private readonly IMapper _mapper;

        public TeachersController(IBaseEntityService<Teacher> teacherervice, IMapper mapper)
        {
            _teacherService = teacherervice;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var teachers = _teacherService.GetAll();
            return View(_mapper.Map<IEnumerable<TeacherModel>>(teachers));
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(TeacherModel teacherModel)
        {
            _teacherService.CreateEntity(_mapper.Map<Teacher>(teacherModel));
            return RedirectToAction("Index", "Teachers");
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public IActionResult EditTeacher(int id)
        {
            var teacher = _teacherService.GetEntity(id);
            return View(_mapper.Map<TeacherModel>(teacher));
        }

        [HttpPost]
        public IActionResult EditTeacher(TeacherModel teacherModel)
        {
            _teacherService.EditEntity(_mapper.Map<Teacher>(teacherModel));
            return RedirectToAction("Index", "Teachers");
        }

        [HttpGet]
        public IActionResult DeleteTeacher(int id)
        {
            _teacherService.DeleteEntity(id);
            return RedirectToAction("Index", "Teachers");
        }
    }
}
