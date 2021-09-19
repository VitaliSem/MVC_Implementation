using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using System.Collections.Generic;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly EnglishSchoolContext _context;
        private readonly IBaseEntityService<Course> _courseService;
        private readonly IMapper _mapper;
        
        public HomeController(EnglishSchoolContext context, IBaseEntityService<Course> courseService, IMapper mapper)
        {
            _context = context;
            _courseService = courseService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string searchString)
        {
            //if (!string.IsNullOrEmpty(searchString))
            var courses = _courseService.Find(c => c.Name.Contains(searchString)).ToList();
            return View(_mapper.Map<IEnumerable<CourseModel>>(courses));
        }

        [Authorize(Roles = "manager")]
        public IActionResult ManagerIndex()
        {
            return View();
        }

        [Authorize(Roles = "manager")]
        public IActionResult ManagerSearch(string searchString)
        {
            var person = from p in _context.Students
                          select p;
            if (!string.IsNullOrEmpty(searchString))
                person = person.Where(s => s.FirstName.Contains(searchString));
            var searchResult = person.ToList();
            return View(_mapper.Map<IEnumerable<StudentModel>>(searchResult));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
