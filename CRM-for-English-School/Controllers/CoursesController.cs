using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;

namespace CRM_for_English_School.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<CourseModel>>(courses));
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCourseAsync(CourseModel courseModel)
        {
            await _courseService.CreateEntityAsync(_mapper.Map<Course>(courseModel));
            return RedirectToAction("Index", "Courses");
        }

        [HttpGet]
        public async Task<IActionResult> EditCourse(int id)
        {
            var course = await _courseService.GetEntityAsync(id);
            return View(_mapper.Map<CourseModel>(course));
        }

        [HttpPost]
        public async Task<IActionResult> EditCourseAsync(CourseModel courseModel)
        {
            await _courseService.EditEntityAsync(_mapper.Map<Course>(courseModel));
            return RedirectToAction("Index", "Courses");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCourseAsync(int id)
        {
            await _courseService.DeleteEntityAsync(id);
            return RedirectToAction("Index", "Courses");
        }
    }
}
