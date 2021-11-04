using CRM_for_English_School.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace CRM_for_English_School
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<AccessOptions> accessOptions)
        {
            string managerEmail = accessOptions.Value.ManagerUserEmail;
            string password = accessOptions.Value.ManagerUserPassword;
            var roles = new[] { "manager", "teacher", "student" };
            foreach (var role in roles)
            {
                if(await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = role,
                        NormalizedName = role.ToUpper()
                    });
                }
            }
            if(await userManager.FindByEmailAsync(managerEmail) == null)
            {
                IdentityUser manager = new()
                {
                    UserName = managerEmail,
                    Email = managerEmail,
                    EmailConfirmed = true
                };
                IdentityResult result = await userManager.CreateAsync(manager, password);
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(manager, "manager");
            }
        }
    }
}
