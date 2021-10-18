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
    public class StudentsController : Controller
    {
        private readonly IBaseEntityService<Student> _studentService;
        private readonly IMapper _mapper;

        public StudentsController(IBaseEntityService<Student> studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var students = await _studentService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<StudentModel>>(students));
        }

        [Authorize(Roles = "manager")]
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentAsync(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                await _studentService.CreateEntityAsync(_mapper.Map<Student>(studentModel));
                return RedirectToAction("Index", "Students");
            }
            return View(studentModel);
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> EditStudentAsync(int id)
        {
            var student = await _studentService.GetEntityAsync(id);
            return View(_mapper.Map<StudentModel>(student));
        }

        [HttpPost]
        public async Task<IActionResult> EditStudentAsync(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                await _studentService.EditEntityAsync(_mapper.Map<Student>(studentModel));
                return RedirectToAction("Index", "Students");
            }
            return View(studentModel);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteStudentAsync(int id)
        {
            await _studentService.DeleteEntityAsync(id);
            return RedirectToAction("Index", "Students");
        }
    }
}
