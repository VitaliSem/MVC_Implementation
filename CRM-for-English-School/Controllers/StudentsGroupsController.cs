using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using CRM_for_English_School.BLL.Entities;

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
        public IActionResult Index()
        {
            var studentsgroups = _studentsGroupService.GetAll();
            return View(_mapper.Map<StudentsGroupModel>(studentsgroups));
        }

        [HttpGet]
        public IActionResult AddStudentsGroup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudentsGroup(StudentsGroupModel studentsGroupModel)
        {
            _studentsGroupService.CreateEntity(_mapper.Map<StudentsGroup>(studentsGroupModel));
            return RedirectToAction("Index", "StudentsGroup");
        }

        [HttpGet]
        public IActionResult EditStudentsGroup(int id)
        {
            var studentsgroup = _studentsGroupService.GetEntity(id);
            return View(_mapper.Map<StudentsGroupModel>(studentsgroup));
        }

        [HttpPost]
        public IActionResult EditStudentsGroup(StudentsGroupModel studentsGroupModel)
        {
            _studentsGroupService.EditEntity(_mapper.Map<StudentsGroup>(studentsGroupModel));
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
