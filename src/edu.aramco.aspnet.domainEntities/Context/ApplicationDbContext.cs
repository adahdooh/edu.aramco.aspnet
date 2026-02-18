using edu.aramco.aspnet.domainEntities.Configurations;
using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<SMS> SMSs { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Major> Majors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().UseTpcMappingStrategy();

        modelBuilder.ApplyStudentConfiguration<Student>();
        modelBuilder.ApplyInstructorConfiguration<Instructor>();
        modelBuilder.ApplySMSConfiguration<SMS>();
        modelBuilder.ApplyCourseConfiguration<Course>();
        modelBuilder.ApplyEnrollmentConfiguration<Enrollment>();
        modelBuilder.ApplyMajorConfiguration<Major>();

        //modelBuilder.Entity<SMS>()
        //    .HasData(
        //        new SMS { Id = 1, PhoneNumber = "SMS 1", Body = "Body" },
        //        new SMS { Id = 3, PhoneNumber = "SMS 3", Body = "Body" }
        //    );

        base.OnModelCreating(modelBuilder);
    }
}
