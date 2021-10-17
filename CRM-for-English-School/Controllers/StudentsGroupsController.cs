using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CRM_for_English_School.Controllers
{
    public class StudentsGroupsController : Controller
    {
        private readonly IStudentsGroupService _studentsGroupService;
        private readonly IMapper _mapper;

        public StudentsGroupsController(IStudentsGroupService studentsGroupService, IMapper mapper)
        {
            _studentsGroupService = studentsGroupService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var studentsgroups = await _studentsGroupService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<StudentsGroupModel>>(studentsgroups));
        }

        [HttpGet]
        public IActionResult AddStudentsGroup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentsGroupAsync(StudentsGroupModel studentsGroupModel)
        {
            await _studentsGroupService.CreateEntityAsync(_mapper.Map<StudentsGroup>(studentsGroupModel));
            return RedirectToAction("Index", "StudentsGroups");
        }

        [HttpGet]
        public async Task<IActionResult> EditStudentsGroupAsync(int id)
        {
            var studentsgroup = await _studentsGroupService.GetEntityAsync(id);
            return View(_mapper.Map<StudentsGroupModel>(studentsgroup));
        }

        [HttpPost]
        public async Task<IActionResult> EditStudentsGroupAsync(StudentsGroupModel studentsGroupModel)
        {
            await _studentsGroupService.EditEntityAsync(_mapper.Map<StudentsGroup>(studentsGroupModel));
            return RedirectToAction("Index", "StudentsGroups");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteStudentsGroupAsync(int id)
        {
            await _studentsGroupService.DeleteEntityAsync(id);
            return RedirectToAction("Index", "StudentsGroups");
        }
    }
}
