using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Configurations;

public static class MajorEntityConfiguration
{
    public static void ApplyMajorConfiguration<T>(this ModelBuilder modelBuilder)
        where T : Major
    {
        modelBuilder.Entity<T>().HasKey(s => s.Id);
        modelBuilder.Entity<T>().Property(s => s.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<T>().Property(s => s.Name).IsRequired(true).HasMaxLength(200);

        modelBuilder.Entity<T>()
            .HasMany(s => s.Students)
            .WithOne()
            .HasForeignKey(s => s.MajorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
