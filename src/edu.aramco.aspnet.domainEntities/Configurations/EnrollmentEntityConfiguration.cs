using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Configurations;

public static class EnrollmentEntityConfiguration
{
    public static void ApplyEnrollmentConfiguration<T>(this ModelBuilder modelBuilder)
        where T : Enrollment
    {
        modelBuilder.Entity<T>()
            .HasKey(x => new { x.StudentId, x.CourseId });

        modelBuilder.Entity<T>()
            .HasOne(x => x.Student)
            .WithMany();

        modelBuilder.Entity<T>()
            .HasOne(x => x.Course)
            .WithMany();
    }
}