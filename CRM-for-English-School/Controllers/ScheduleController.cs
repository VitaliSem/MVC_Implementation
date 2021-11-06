using AutoMapper;
using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILessonService _lessonService;
        private readonly ITeacherService _teacherService;
        private readonly IStudentsGroupService _studentsGroupService;
        private readonly IMapper _mapper;

        public ScheduleController(UserManager<IdentityUser> userManager,
            ILessonService lessonService,
            ITeacherService teacherService,
            IStudentsGroupService studentsGroupService,
            IMapper mapper)
        {
            _userManager = userManager;
            _lessonService = lessonService;
            _teacherService = teacherService;
            _studentsGroupService = studentsGroupService;
            _mapper = mapper;
        }
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Index(LessonModel lessonModel)
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var teacher = await _teacherService.GetTeacherByUserId(user.Id);
            ViewBag.Groups = _mapper.Map<IEnumerable<StudentsGroupModel>>(await _studentsGroupService.GetGroupsByTeacherId(teacher.Id));
            if (ModelState.IsValid && lessonModel.Topic != null)
                await _lessonService.CreateEntityAsync(_mapper.Map<Lesson>(lessonModel));
            var lessons = _mapper.Map<IEnumerable<LessonModel>>(await _lessonService.GetLessonsAsync());
            ScheduleViewModel model = new()
            {
                Lesson = null,
                Lessons = lessons
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _lessonService.DeleteEntityAsync(id);
            return RedirectToAction("Index");
        }
    }
}
