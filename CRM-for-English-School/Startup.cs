using AutoMapper;
using CRM_for_English_School.Configuration;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.Filters;
using CRM_for_English_School.Mapper;
using CRM_for_English_School.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;

namespace CRM_for_English_School
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EnglishSchoolContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>(options => {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.SignIn.RequireConfirmedAccount = true;
            }).AddDefaultUI()
            .AddEntityFrameworkStores<EnglishSchoolContext>()
            .AddDefaultTokenProviders();

            services.Configure<FileModel>(Configuration.GetSection("FileModel"));
            services.Configure<AccessOptions>(Configuration.GetSection(AccessOptions.Access));

            services.AddCRMService();
            services.AddMvc(options => options.Filters.Add<CustomExceptionFilter>());

            var mapperConfig = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IWebHostEnvironment env, 
            IServiceProvider serviceProvider, 
            IOptions<AccessOptions> accessOptions,
            ILoggerFactory loggerFactory)
        {
            if (loggerFactory is null)
            {
                throw new ArgumentNullException(nameof(loggerFactory));
            }

            //app.UseExceptionHandlerMiddleware();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Shared/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }


        //loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logfile.txt"));
        //    var logger = loggerFactory.CreateLogger("FileLogger");

        //app.Run(async (context) =>
        //{
        //    logger.LogInformation("[Error] Request from the addres string - \"{0}\". " + DateTime.Now.ToString(), context.Request.Path);
        //    await context.Response.CompleteAsync();
        //});
    }
}
