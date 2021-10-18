using CRM_for_English_School.AppCore.Entities;
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
        public async Task<IEnumerable<Teacher>> GetTeachersAsync()
        {
            return await _teacherService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Teacher> GetTeacherAsync(int id)
        {
            return await _teacherService.GetEntityAsync(id);
        }

        [HttpPost]
        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            if (teacher != null)
                await _teacherService.CreateEntityAsync(teacher);

            return teacher;
        }

        [HttpPut("{id}")]
        public async Task<Teacher> EditTeacherAsync(Teacher teacher)
        {
            if (teacher != null)
                await _teacherService.EditEntityAsync(teacher);

            return teacher;
        }

        [HttpDelete("{id}")]
        public async Task DeleteTeacherAsync(int id)
        {
            await _teacherService.DeleteEntityAsync(id);
        }
    }
}
