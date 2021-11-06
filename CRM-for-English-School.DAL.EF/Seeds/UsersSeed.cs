using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Seeds
{
    public static partial class Seeds
    {
        public static void UsersSeed(this ModelBuilder modelBuilder)
        {
            var user1 = new IdentityUser()
            {
                Id = "18fedd72-d3e2-4033-9744-877b60a5a2ff",
                UserName = "SvetlanaFedorova@gmail.com",
                NormalizedUserName = "SVETLANAFEDOROVA@GMAIL.COM",
                NormalizedEmail = "SVETLANAFEDOROVA@GMAIL.COM",
                Email = "SvetlanaFedorova@gmail.com",
                PasswordHash = "Fedorova1986",
                EmailConfirmed = true
            };
            var user2 = new IdentityUser()
            {
                Id = "2aa85a78-dba9-49d8-8215-89f793f1fd74",
                UserName = "KateKalinina@gmail.com",
                NormalizedUserName = "KATEKALININA@GMAIL.COM",
                NormalizedEmail = "KATEKALININA@GMAIL.COM",
                Email = "KateKalinina@gmail.com",
                PasswordHash = "Kalinina1992",
                EmailConfirmed = true
            };
            var user3 = new IdentityUser()
            {
                Id = "465f38e5-9d8b-4ddb-9a9a-67c6d9c9f5e9",
                UserName = "IrinaStupco@gmail.com",
                NormalizedUserName = "IRINASTUPCO@GMAIL.COM",
                NormalizedEmail = "IRINASTUPCO@GMAIL.COM",
                Email = "IrinaStupco@gmail.com",
                PasswordHash = "Stupco1994",
                EmailConfirmed = true
            };
            var user4 = new IdentityUser()
            {
                Id = "008120a7-6d9c-4f2e-83aa-52764cc6e3b7",
                UserName = "KseniaFursina@gmail.com",
                NormalizedUserName = "KSENIAFURSINA@GMAIL.COM",
                NormalizedEmail = "KSENIAFURSINA@GMAIL.COM",
                Email = "KseniaFursina@gmail.com",
                PasswordHash = "Fursina1990",
                EmailConfirmed = true
            };
            modelBuilder.Entity<IdentityUser>().HasData(user1, user2, user3, user4);
        }
    }
}
