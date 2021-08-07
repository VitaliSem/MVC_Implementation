﻿using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using System.Collections.Generic;
using CRM_for_English_School.BLL.Entities;

namespace CRM_for_English_School.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IBaseEntityService<Student> _studentService;

        public StudentsController(IBaseEntityService<Student> studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentModel>());
            var mapper = new Mapper(config);
            var students = mapper.Map<IEnumerable<StudentModel>>(_studentService.GetAll());
            return View(students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentModel studentModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>());
            var mapper = new Mapper(config);
            var student = mapper.Map<StudentModel, Student>(studentModel);
            _studentService.CreateEntity(student);

            return RedirectToAction("Index", "Students");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = _studentService.GetEntity(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentModel>());
            var mapper = new Mapper(config);
            var member = mapper.Map<Student, StudentModel>(_studentService.GetEntity(id));
            return View(member);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel studentModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>());
            var mapper = new Mapper(config);
            var student = mapper.Map<StudentModel, Student>(studentModel);
            _studentService.EditEntity(student);

            return RedirectToAction("Index", "Students");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            _studentService.DeleteEntity(id);
            return RedirectToAction("Index", "Students");
        }
    }
}
