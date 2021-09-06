using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.WEB.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IBaseEntityService<Teacher> _teacherService;

        public TeacherController(IBaseEntityService<Teacher> teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public IEnumerable<Teacher> GetTeachers()
        {
            return _teacherService.GetAll();
        }

        [HttpGet("async")]
        public async Task<IEnumerable<Teacher>> GetTeachersAsync()
        {
            return await _teacherService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public Teacher GetTeacher(int id)
        {
            return _teacherService.GetEntity(id);
        }

        [HttpPost]
        public Teacher AddTeacher(Teacher teacher)
        {
            if (teacher != null)
                _teacherService.CreateEntity(teacher);

            return teacher;
        }

        [HttpPut("{id}")]
        public Teacher EditTeacher(Teacher teacher)
        {
            if (teacher != null)
                _teacherService.EditEntity(teacher);

            return teacher;
        }

        [HttpDelete("{id}")]
        public void DeleteTeacher(int id)
        {
            _teacherService.DeleteEntity(id);
        }
    }
}
