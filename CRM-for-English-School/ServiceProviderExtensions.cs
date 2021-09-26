﻿using CRM_for_English_School.BLL.Entities;
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
            services.AddScoped<IRepository<Request>, RequestRepository>();
            services.AddScoped<IRepository<Student>, BaseEntityRepository<Student>>();
            services.AddScoped<IRepository<Teacher>, BaseEntityRepository<Teacher>>();
            services.AddScoped<IRepository<Course>, BaseEntityRepository<Course>>();
            services.AddScoped<IRepository<StudentsGroup>, BaseEntityRepository<StudentsGroup>>();

            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IBaseEntityService<Student>, BaseEntityService<Student>>();
            services.AddScoped<IBaseEntityService<Teacher>, BaseEntityService<Teacher>>();
            services.AddScoped<IBaseEntityService<Course>, BaseEntityService<Course>>();
            services.AddScoped<IBaseEntityService<StudentsGroup>, BaseEntityService<StudentsGroup>>();
        }
    }
}
