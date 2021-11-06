using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.Models;
using CRM_for_English_School.AppCore.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CRM_for_English_School.Controllers
{
    public class StudentsGroupsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IStudentsGroupService _studentsGroupService;
        private readonly ICourseService _courseService;
        private readonly IRequestService _requestService;
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentsGroupsController(UserManager<IdentityUser> userManager,
            IStudentsGroupService studentsGroupService,
            ICourseService courseService,
            IRequestService requestService,
            ITeacherService teacherService,
            IStudentService studentService,
            IMapper mapper)
        {
            _userManager = userManager;
            _studentsGroupService = studentsGroupService;
            _courseService = courseService;
            _requestService = requestService;
            _teacherService = teacherService;
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(await _courseService.GetAllAsync());
            var studentsgroups = _mapper.Map<IEnumerable<StudentsGroupModel>>(await _studentsGroupService.GetAllAsync());
            return View(studentsgroups);
        }
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> TeachersGroups()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var teacher = await _teacherService.GetTeacherByUserId(user.Id);
            var studentsgroups = _mapper.Map<IEnumerable<StudentsGroupModel>>(await _studentsGroupService.GetGroupsByTeacherId(teacher.Id));
            return View(studentsgroups);
        }
        [HttpGet]
        public async Task<IActionResult> AddStudentsGroupAsync(int id)
        {
            ViewBag.Course = _mapper.Map<CourseModel>(await _courseService.GetEntityAsync(id));
            ViewBag.Teachers = _mapper.Map<IEnumerable<TeacherModel>>(await _teacherService.GetAllAsync());
            ViewBag.Requests = _mapper.Map<IEnumerable<RequestModel>>(await _requestService.GetRequestsToCourseAsync(id));
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentsGroupAsync(StudentsGroupModel studentsGroupModel)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("AddStudentsGroup", new { id = studentsGroupModel.CourseId });
            studentsGroupModel.Teacher = await _teacherService.GetEntityAsync(studentsGroupModel.TeacherId);
            studentsGroupModel.Id = 0;
            int groupId = await _studentsGroupService.CreateGroupAsync(_mapper.Map<StudentsGroup>(studentsGroupModel));
            foreach(var requestId in studentsGroupModel.RequestIds)
            {
                var request = await _requestService.GetEntityAsync(requestId);
                var student = _mapper.Map<Student>(request);
                student.GroupId = groupId;
                student.Status = AppCore.Enums.StudentStatus.IsStudying;
                await _studentService.CreateEntityAsync(student);
                request.RequestStatus = AppCore.Enums.RequestStatus.Processed;
            }
            await _courseService.DeleteEntityAsync(studentsGroupModel.CourseId);
            return RedirectToAction("Index", "StudentsGroups");
        }
        [HttpGet]
        public async Task<IActionResult> EditStudentsGroupAsync(int id)
        {
            ViewBag.Teachers = _mapper.Map<IEnumerable<TeacherModel>>(await _teacherService.GetAllAsync());
            ViewBag.StudentsGroups = _mapper.Map<IEnumerable<StudentsGroupModel>>(await _studentsGroupService.GetAllAsync());
            var studentsgroup = _mapper.Map<StudentsGroupModel>(await _studentsGroupService.GetStudentsGroupAsync(id));
            return View(studentsgroup);
        }
        [HttpGet]
        public async Task<IActionResult> StudentsGroupInfoAsync(int id)
        {
            var studentsgroup = _mapper.Map<StudentsGroupModel>(await _studentsGroupService.GetStudentsGroupAsync(id));
            return View(studentsgroup);
        }

        [HttpPost]
        public async Task<IActionResult> EditStudentsGroupAsync(StudentsGroupModel studentsGroupModel)
        {
            var students = await _studentService.GetStudentsByGroupId(studentsGroupModel.Id);
            studentsGroupModel.Students = (List<Student>)students;
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
