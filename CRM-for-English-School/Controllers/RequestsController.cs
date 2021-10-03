using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;

namespace CRM_for_English_School.Controllers
{
    [Authorize]
    public class RequestsController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;

        public RequestsController(ICourseService courseService, IRequestService requestService, IMapper mapper)
        {
            _courseService = courseService;
            _requestService = requestService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            var requests = _requestService.GetAll();
            return View(_mapper.Map<IEnumerable<RequestModel>>(requests));
        }

        [Authorize(Roles = "manager")]
        [HttpGet]
        public IActionResult AddRequest()
        {
            var courses = _courseService.GetAll();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            return View();
        }

        [HttpPost]
        public IActionResult AddRequest(RequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                _requestService.CreateEntity(_mapper.Map<Request>(requestModel));
                return RedirectToAction("Index", "Requests");
            }
            return View(requestModel);
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public IActionResult EditRequest(int id)
        {
            var courses = _courseService.GetAll();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            var request = _requestService.GetEntity(id);
            return View(_mapper.Map<RequestModel>(request));
        }

        [HttpPost]
        public IActionResult EditRequest(RequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                _requestService.EditEntity(_mapper.Map<Request>(requestModel));
                return RedirectToAction("Index", "Requests");
            }
            return View(requestModel);
        }

        [HttpGet]
        public IActionResult DeleteRequest(int id)
        {
            _requestService.DeleteEntity(id);
            return RedirectToAction("Index", "Requests");
        }

        [HttpPost]
        public async Task<IActionResult> Search(RequestSearchModel searchModel)
        {
            if (ModelState.IsValid)
            {
                var courses = _courseService.GetAll();
                ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
                var filteredRequests = await _requestService.SearchAsync(_mapper.Map<RequestSearch>(searchModel));
                return View("Index", _mapper.Map<IEnumerable<RequestModel>>(filteredRequests));
            }
            return RedirectToAction("Index", "Requests");
        }
    }
}
