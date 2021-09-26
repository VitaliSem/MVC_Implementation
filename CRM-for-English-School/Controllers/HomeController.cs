using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AutoMapper;
using System.Collections.Generic;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.BLL.Entities;
using System.Threading;

namespace CRM_for_English_School.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly IBaseEntityService<Course> _courseService;
        private readonly IRequestService _requestService;
        private readonly EnglishSchoolContext _context;
        private readonly IMapper _mapper;

        public HomeController(EnglishSchoolContext context,
            IBaseEntityService<Course> courseService,
            IRequestService requestService,
            IMapper mapper)
        {
            _context = context;
            _requestService = requestService;
            _courseService = courseService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            return View();
        }

        [Authorize(Roles = "manager")]
        public IActionResult ManagerIndex()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult FillRequestForm(RequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                _requestService.CreateEntity(_mapper.Map<Request>(requestModel));
            }
            Thread.Sleep(3000);
            return RedirectToAction("Index", "Home");
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
