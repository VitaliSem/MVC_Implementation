using CRM_for_English_School.AppCore.Entities;
using CRM_for_English_School.DAL.EF.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM_for_English_School.DAL.EF.Context
{
    public class EnglishSchoolContext : IdentityDbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentsGroup> StudentsGroups { get; set; }

        public EnglishSchoolContext() { }
        public EnglishSchoolContext(DbContextOptions<EnglishSchoolContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.RequestsSeed();
            modelBuilder.TeachersSeed();
            modelBuilder.CourcesSeed();
            modelBuilder.StudentsSeed();

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Requests);
            modelBuilder.Entity<Request>()
                .Property(p => p.Age)
                .HasComputedColumnSql("DATEDIFF(YEAR,BirthDate,GETDATE())");
        }
    }
}
