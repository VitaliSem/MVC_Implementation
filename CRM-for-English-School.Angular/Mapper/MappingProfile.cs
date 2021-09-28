using AutoMapper;
using CRM_for_English_School.Angular.DTO;
using CRM_for_English_School.AppCore.Entities;

namespace CRM_for_English_School.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
        }
    }
}
