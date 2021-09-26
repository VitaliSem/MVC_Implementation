using AutoMapper;
using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.Models;

namespace CRM_for_English_School.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonModel>().ReverseMap();
            CreateMap<Request, RequestModel>().ReverseMap();
            CreateMap<Student, StudentModel>().ReverseMap();
            CreateMap<Teacher, TeacherModel>().ReverseMap();
            CreateMap<Course, CourseModel>().ReverseMap();
            CreateMap<StudentsGroup, StudentsGroupModel>().ReverseMap();
        }
    }
}
