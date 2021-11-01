using AutoMapper;
using CRM_for_English_School.AppCore.Entities;
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
            CreateMap<RequestSearch, RequestSearchModel>().ReverseMap();
            CreateMap<StudentsGroupModel, StudentsGroup>()
                .ForMember("Name", opt => opt.MapFrom(sg => sg.GroupName))
                .ForMember("Id", opt => opt.Ignore())
                .ForMember("Students", opt => opt.MapAtRuntime()).ReverseMap();
            CreateMap<Request, Student>()
                .ForMember("GroupId", opt => opt.MapFrom(r => r.CourseId))
                .ForMember("Id", opt => opt.Ignore()).ReverseMap();
        }
    }
}
