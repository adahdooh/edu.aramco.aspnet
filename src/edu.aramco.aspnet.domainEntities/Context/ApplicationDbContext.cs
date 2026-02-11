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


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .UseTpcMappingStrategy();

        modelBuilder.ApplyStudentConfiguration<Student>();
        modelBuilder.ApplyInstructorConfiguration<Instructor>();
        modelBuilder.ApplySMSConfiguration<SMS>();

        base.OnModelCreating(modelBuilder);
    }
}
