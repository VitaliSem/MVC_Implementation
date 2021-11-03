using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Text;

namespace CRM_for_English_School.Controllers
{
    [Authorize]
    public class RequestsController : Controller
    {
        const int pageSize = 10;
        private readonly ICourseService _courseService;
        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;

        public RequestsController(ICourseService courseService, IRequestService requestService, IMapper mapper)
        {
            _courseService = courseService;
            _requestService = requestService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var courses = await _courseService.GetAllAsync();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            var countOfRequests = await _requestService.CountAsync();
            ViewBag.RequestCount = countOfRequests;
            var requests = _mapper.Map<IEnumerable<RequestModel>>(await _requestService.TakeRequestsFromPageAsync(page, pageSize));
            PageViewModel pageViewModel = new(countOfRequests, page, pageSize);
            PaginationModel paginationModel = new()
            {
                Requests = requests,
                PageViewModel = pageViewModel
            };
            return View(paginationModel);
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
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(await _courseService.GetAllAsync());
            var request = _mapper.Map<RequestModel>(await _requestService.GetEntityAsync(id));
            return View(request);
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
        public async Task<IActionResult> DownloadAllRequestsAsync()
        {
            var requests = await _requestService.GetAllAsync();
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, encoding: Encoding.UTF8);
            var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(requests);
            writer.Flush();
            stream.Position = 0;
            return File(stream, contentType: "text/plain", fileDownloadName: "requests.csv");
        }

        [HttpPost]
        public async Task<IActionResult> Search(RequestSearchModel searchModel)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<Course> courses = await _courseService.GetAllAsync();
                ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
                var filteredRequests = _mapper.Map<IEnumerable<RequestModel>>(await _requestService.SearchAsync(_mapper.Map<RequestSearch>(searchModel)));
                PaginationModel paginationModel = new()
                {
                    Requests = filteredRequests,
                    PageViewModel = null
                };
                return View("Index", paginationModel);
            }
            return RedirectToAction("Index", "Requests");
        }
    }
}
