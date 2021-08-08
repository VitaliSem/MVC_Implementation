using AutoMapper;
using CRM_for_English_School.BLL.Entities;
using CRM_for_English_School.BLL.Interfaces;
using CRM_for_English_School.BLL.Services;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.DAL.EF.Repositories;
using CRM_for_English_School.DAL.Interfaces;
using CRM_for_English_School.Mapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CRM_for_English_School
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EnglishSchoolContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EnglishSchoolDB;Trusted_Connection=True;"));

            services.AddScoped<IRepository<Student>, BaseEntityRepository<Student>>();
            services.AddScoped<IRepository<Teacher>, BaseEntityRepository<Teacher>>();
            services.AddScoped<IRepository<StudentsGroup>, BaseEntityRepository<StudentsGroup>>();

            services.AddScoped<IBaseEntityService<Student>, BaseEntityService<Student>>();
            services.AddScoped<IBaseEntityService<Teacher>, BaseEntityService<Teacher>>();
            services.AddScoped<IBaseEntityService<StudentsGroup>, BaseEntityService<StudentsGroup>>();

            var mapperConfig = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Students}/{action=Index}/{id?}");
            });
        }
    }
}
