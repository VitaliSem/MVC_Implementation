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

        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllAsync();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            var requests = await _requestService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<RequestModel>>(requests));
        }

        [Authorize(Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> AddRequest()
        {
            var courses = await _courseService.GetAllAsync();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRequestAsync(RequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                await _requestService.CreateEntityAsync(_mapper.Map<Request>(requestModel));
                return RedirectToAction("Index", "Requests");
            }
            return View(requestModel);
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> EditRequestAsync(int id)
        {
            var courses = await _courseService.GetAllAsync();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            var request = await _requestService.GetEntityAsync(id);
            return View(_mapper.Map<RequestModel>(request));
        }

        [HttpPost]
        public async Task<IActionResult> EditRequestAsync(RequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                await _requestService.EditEntityAsync(_mapper.Map<Request>(requestModel));
                return RedirectToAction("Index", "Requests");
            }
            return View(requestModel);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRequestAsync(int id)
        {
            await _requestService.DeleteEntityAsync(id);
            return RedirectToAction("Index", "Requests");
        }

        [HttpPost]
        public async Task<IActionResult> Search(RequestSearchModel searchModel)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<Course> courses = await _courseService.GetAllAsync();
                ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
                var filteredRequests = await _requestService.SearchAsync(_mapper.Map<RequestSearch>(searchModel));
                return View("Index", _mapper.Map<IEnumerable<RequestModel>>(filteredRequests));
            }
            return RedirectToAction("Index", "Requests");
        }
    }
}
