using AutoMapper;
using CRM_for_English_School.Angular.DTO;
using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM_for_English_School.Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly IBaseEntityService<Course> _courseService;
        private readonly IMapper _mapper;

        public CoursesController(IBaseEntityService<Course> courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CourseDTO>> GetAsync()
        {
            return _mapper.Map<IEnumerable<CourseDTO>>(await _courseService.GetAllAsync());
        }
    }
}
