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
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;

        public TeachersController(ITeacherService teacherervice, IMapper mapper)
        {
            _teacherService = teacherervice;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var teachers = await _teacherService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<TeacherModel>>(teachers));
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacherAsync(TeacherModel teacherModel)
        {
            await _teacherService.CreateEntityAsync(_mapper.Map<Teacher>(teacherModel));
            return RedirectToAction("Index", "Teachers");
        }

        [Authorize (Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> EditTeacherAsync(int id)
        {
            var teacher = await _teacherService.GetEntityAsync(id);
            return View(_mapper.Map<TeacherModel>(teacher));
        }

        [HttpPost]
        public async Task<IActionResult> EditTeacherAsync(TeacherModel teacherModel)
        {
            await _teacherService.EditEntityAsync(_mapper.Map<Teacher>(teacherModel));
            return RedirectToAction("Index", "Teachers");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteTeacherAsync(int id)
        {
            await _teacherService.DeleteEntityAsync(id);
            return RedirectToAction("Index", "Teachers");
        }
    }
}
