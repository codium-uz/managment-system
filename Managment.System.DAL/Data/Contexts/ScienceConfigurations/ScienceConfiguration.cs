using Managment.System.Domain.Entities.ScienceEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.ScienceConfigurations;

public class ScienceConfiguration : IEntityTypeConfiguration<Science>
{
    public void Configure(EntityTypeBuilder<Science> builder)
    {
        builder.ToTable("sciences");
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Name).IsRequired(true).HasMaxLength(20);
        builder.HasIndex(s => s.Name).IsUnique();
        builder.Property(s => s.Title).IsRequired().HasMaxLength(50);
        builder.Property(s => s.Description).HasMaxLength(250);
        builder.Property(s => s.CreatedAt).IsRequired();
    }
}
