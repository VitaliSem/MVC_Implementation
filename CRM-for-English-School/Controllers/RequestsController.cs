﻿using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using CRM_for_English_School.BLL.Entities;
using Microsoft.AspNetCore.Authorization;

namespace CRM_for_English_School.Controllers
{
    [Authorize]
    public class RequestsController : Controller
    {
        private readonly IBaseEntityService<Course> _courseService;
        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;

        public RequestsController(IBaseEntityService<Course> courseService, IRequestService requestService, IMapper mapper)
        {
            _courseService = courseService;
            _requestService = requestService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
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
    }
}