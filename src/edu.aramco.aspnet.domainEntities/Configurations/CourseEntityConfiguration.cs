using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Configurations;

public static class CourseEntityConfiguration
{
    public static void ApplyCourseConfiguration<T>(this ModelBuilder modelBuilder)
        where T : Course
    {
        modelBuilder.Entity<T>().HasKey(s => s.Id);
        modelBuilder.Entity<T>().Property(s => s.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<T>().Property(s => s.Name).IsRequired(true).HasMaxLength(200);
        modelBuilder.Entity<T>().Property(s => s.Description).IsRequired().HasMaxLength(900);
        modelBuilder.Entity<T>().Property(s => s.Author).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<T>().Property(s => s.Hours).IsRequired();
    }
}
