﻿using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Controllers
{
    public class StudentsGroupsController : Controller
    {
        private readonly IStudentsGroupService _studentsGroupService;

        public StudentsGroupsController(IStudentsGroupService studentsGroupService)
        {
            _studentsGroupService = studentsGroupService;
        }
        public IActionResult Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentsGroup, StudentsGroupModel>());
            var mapper = new Mapper(config);
            var studentsGroups = mapper.Map<IEnumerable<StudentsGroupModel>>(_studentsGroupService.GetAll());
            return View(studentsGroups);
        }

        [HttpGet]
        public IActionResult AddStudentsGroup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudentsGroup(StudentsGroupModel studentsGroupModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentsGroupModel, StudentsGroup>());
            var mapper = new Mapper(config);
            var studentsGroup = mapper.Map<StudentsGroupModel, StudentsGroup>(studentsGroupModel);
            _studentsGroupService.CreateEntity(studentsGroup);

            return RedirectToAction("Index", "StudentsGroup");
        }

        [HttpGet]
        public IActionResult EditStudentsGroup(int id)
        {
            var student = _studentsGroupService.GetEntity(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentsGroup, StudentsGroupModel>());
            var mapper = new Mapper(config);
            var member = mapper.Map<StudentsGroup, StudentsGroupModel>(_studentsGroupService.GetEntity(id));
            return View(member);
        }

        [HttpPost]
        public IActionResult EditStudentsGroup(StudentsGroupModel studentsGroupModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentsGroupModel, StudentsGroup>());
            var mapper = new Mapper(config);
            var studentsGroup = mapper.Map<StudentsGroupModel, StudentsGroup>(studentsGroupModel);
            _studentsGroupService.EditEntity(studentsGroup);

            return RedirectToAction("Index", "StudentsGroup");
        }

        [HttpGet]
        public IActionResult DeleteStudentsGroup(int id)
        {
            _studentsGroupService.DeleteEntity(id);
            return RedirectToAction("Index", "StudentsGroup");
        }
    }
}
