using Microsoft.EntityFrameworkCore;

namespace StudentRestAPI.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Akash",
                    LastName = "Gupta",
                    Gender = Gender.Male,
                });

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 2,
                    FirstName = "vash",
                    LastName = "Gupta",
                    Gender = Gender.Male,
                });
        }
    }
}
