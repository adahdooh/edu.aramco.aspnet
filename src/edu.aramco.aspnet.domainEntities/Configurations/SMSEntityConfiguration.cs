using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.domainEntities.Configurations;

public static class SMSEntityConfiguration
{
    public static void ApplySMSConfiguration<T>(this ModelBuilder modelBuilder) where T : SMS
    {
        modelBuilder.Entity<T>()
            .HasKey(s => s.Id);

        modelBuilder.Entity<T>()
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<T>()
            .Property(s => s.PhoneNumber)
            .IsRequired(true)
            .HasMaxLength(15);

        modelBuilder.Entity<T>()
            .Property(s => s.Body)
            .IsRequired()
            .HasMaxLength(160);
    }
}
