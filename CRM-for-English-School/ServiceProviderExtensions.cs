using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.BLL.Services;
using CRM_for_English_School.DAL.EF.Repositories;
using CRM_for_English_School.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CRM_for_English_School
{
    public static class ServiceProviderExtensions
    {
        public static void AddCRMService(this IServiceCollection services)
        {
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IRepository<Student>, BaseEntityRepository<Student>>();
            services.AddScoped<IRepository<Teacher>, BaseEntityRepository<Teacher>>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IStudentsGroupRepository, StudentsGroupRepository>();

            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IBaseEntityService<Student>, BaseEntityService<Student>>();
            services.AddScoped<IBaseEntityService<Teacher>, BaseEntityService<Teacher>>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IStudentsGroupService, StudentsGroupService>();
        }
    }
}
