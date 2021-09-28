using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using CRM_for_English_School.AppCore.Entities;

namespace CRM_for_English_School.Controllers
{
    public class CoursesController : Controller
    {
        private readonly IBaseEntityService<Course> _courseService;
        private readonly IMapper _mapper;

        public CoursesController(IBaseEntityService<Course> courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            return View(_mapper.Map<IEnumerable<CourseModel>>(courses));
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(CourseModel courseModel)
        {
            _courseService.CreateEntity(_mapper.Map<Course>(courseModel));
            return RedirectToAction("Index", "Courses");
        }

        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            var course = _courseService.GetEntity(id);
            return View(_mapper.Map<CourseModel>(course));
        }

        [HttpPost]
        public IActionResult EditCourse(CourseModel courseModel)
        {
            _courseService.EditEntity(_mapper.Map<Course>(courseModel));
            return RedirectToAction("Index", "Courses");
        }

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            _courseService.DeleteEntity(id);
            return RedirectToAction("Index", "Courses");
        }
    }
}
