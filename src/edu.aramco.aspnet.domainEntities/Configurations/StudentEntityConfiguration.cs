using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Configurations;

public static class StudentEntityConfiguration
{
    public static void ApplyStudentConfiguration<T>(this ModelBuilder modelBuilder) where T : Student
    {
        modelBuilder.Entity<T>()
            .Property(s => s.EmailAddress)
            .IsRequired(true)
            .HasMaxLength(50);
    }
}
