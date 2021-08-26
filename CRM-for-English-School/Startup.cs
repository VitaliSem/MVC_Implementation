using AutoMapper;
using CRM_for_English_School.Configuration;
using CRM_for_English_School.DAL.EF.Context;
using CRM_for_English_School.Logger;
using CRM_for_English_School.Mapper;
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
using System.IO;
using System.Threading.Tasks;

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
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddDefaultUI()
                .AddEntityFrameworkStores<EnglishSchoolContext>()
                .AddDefaultTokenProviders();

            services.AddCRMService();
            services.Configure<AccessOptions>(Configuration.GetSection(AccessOptions.Access));

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Students}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            CreateRoles(serviceProvider, accessOptions).Wait();

            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logfile.txt"));
            var logger = loggerFactory.CreateLogger("FileLogger");

            app.Run(async (context) =>
            {
                logger.LogInformation("[Info] Request from the addres string - \"{0}\". " + DateTime.Now.ToString(), context.Request.Path);
                await context.Response.CompleteAsync();
            });
        }

        private static async Task CreateRoles(IServiceProvider serviceProvider, IOptions<AccessOptions> accessOptions)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = new[] { "manager", "teacher", "student" };
            foreach(var role in roles)
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = role,
                    NormalizedName = role.ToUpper()
                });
            }
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var user = await userManager.FindByEmailAsync(accessOptions.Value.ManagerUserEmail);
            if (user != null)
                await userManager.AddToRoleAsync(user, "manager");
        }
    }
}
