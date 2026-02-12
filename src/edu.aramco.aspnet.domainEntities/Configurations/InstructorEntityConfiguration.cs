using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Configurations;

public static class InstructorEntityConfiguration
{
    public static void ApplyInstructorConfiguration<T>(this ModelBuilder modelBuilder)
        where T : Instructor
    {
        modelBuilder.Entity<T>().Property(s => s.EmailAddress).IsRequired(true).HasMaxLength(50);

        modelBuilder.Entity<T>()
            .HasMany(s => s.Courses);
    }
}
