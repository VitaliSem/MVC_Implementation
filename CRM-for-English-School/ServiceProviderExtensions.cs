using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.BLL.Services;
using CRM_for_English_School.DAL.EF.Repositories;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace CRM_for_English_School
{
    public static class ServiceProviderExtensions
    {
        public static void AddCRMService(this IServiceCollection services)
        {
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IStudentsGroupRepository, StudentsGroupRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();

            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IStudentsGroupService, StudentsGroupService>();
            services.AddScoped<ILessonService, LessonService>();

            services.AddScoped<UserManager<IdentityUser>>();
        }
    }
}
