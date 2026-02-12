using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Configurations;

public static class MajorEntityConfiguration
{
    public static void ApplyMajorConfiguration<T>(this ModelBuilder modelBuilder)
        where T : Major
    {
        modelBuilder.Entity<Major>(x =>
        {
            x.HasKey(s => s.Id);
            x.Property(s => s.Id).ValueGeneratedOnAdd();
            x.Property(s => s.Name).IsRequired(true).HasMaxLength(200);

            x.HasMany(s => s.Students)
            .WithOne(s => s.Major)
            .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
