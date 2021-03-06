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
        const int pageSize = 10;
        private readonly IStudentService _studentService;
        private readonly IStudentsGroupService _studentsGroupService;
        private readonly IMapper _mapper;

        public StudentsController(IStudentService studentService, IStudentsGroupService studentsGroupService, IMapper mapper)
        {
            _studentService = studentService;
            _studentsGroupService = studentsGroupService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexAsync(int page = 1)
        {
            var countOfStudents = await _studentService.CountAsync();
            ViewBag.Groups = _mapper.Map<IEnumerable<StudentsGroupModel>>(await _studentsGroupService.GetAllAsync());
            var students = _mapper.Map<IEnumerable<StudentModel>>(await _studentService.TakeStudentsFromPageAsync(page, pageSize));
            PageViewModel pageViewModel = new(countOfStudents, page, pageSize);
            PaginationModel paginationModel = new()
            {
                Students = students,
                PageViewModel = pageViewModel
            };
            return View(paginationModel);
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
            ViewBag.StudentsGroups = _mapper.Map<IEnumerable<StudentsGroupModel>>(await _studentsGroupService.GetAllAsync());
            var student = _mapper.Map<StudentModel>(await _studentService.GetEntityAsync(id));
            return View(student);
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
        public async Task<IActionResult> ExcludeAsync(int id)
        {
            var student = await _studentService.GetEntityAsync(id);
            var groupId = student.GroupId;
            student.GroupId = null;
            student.Status = AppCore.Enums.StudentStatus.Expelled;
            await _studentService.EditEntityAsync(student);
            return RedirectToAction("EditStudentsGroup", "StudentsGroups", new { id=groupId });
        }
        [HttpPost]
        public async Task<IActionResult> Search(StudentSearchModel searchModel)
        {
            if (ModelState.IsValid)
            {
                IEnumerable<StudentsGroup> groups = await _studentsGroupService.GetAllAsync();
                ViewBag.Groups = _mapper.Map<IEnumerable<StudentsGroupModel>>(groups);
                var filteredStudents = _mapper.Map<IEnumerable<StudentModel>>(await _studentService.SearchAsync(_mapper.Map<StudentSearch>(searchModel)));
                PaginationModel paginationModel = new()
                {
                    Students = filteredStudents,
                    PageViewModel = null
                };
                return View("Index", paginationModel);
            }
            return RedirectToAction("Index", "Requests");
        }
    }
}
