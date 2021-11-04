using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void UserRolesSeed(this ModelBuilder modelBuilder)
        {
            var userRole1 = new IdentityUserRole<string>()
            {
                UserId = "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                RoleId = "cc51b262-0dbf-442d-a121-3fcb5f25d9fb"
            };
            var userRole2 = new IdentityUserRole<string>()
            {
                UserId = "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                RoleId = "cc51b262-0dbf-442d-a121-3fcb5f25d9fb"
            };
            var userRole3 = new IdentityUserRole<string>()
            {
                UserId = "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                RoleId = "cc51b262-0dbf-442d-a121-3fcb5f25d9fb"
            };
            var userRole4 = new IdentityUserRole<string>()
            {
                UserId = "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                RoleId = "cc51b262-0dbf-442d-a121-3fcb5f25d9fb"
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRole1, userRole2, userRole3, userRole4);
        }
    }
}
