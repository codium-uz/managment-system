using Managment.System.Domain.Entities.ScienceEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.ScienceConfigurations;

public class TopicConfiguration : IEntityTypeConfiguration<Topic>
{
    public void Configure(EntityTypeBuilder<Topic> builder)
    {
        builder.ToTable("topics");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Name).IsRequired(true).HasMaxLength(50);
        builder.HasIndex(t => t.Name).IsUnique();
        builder.Property(t => t.Title).IsRequired(true).HasMaxLength(50);
        builder.Property(t => t.ScienceId).IsRequired();
        builder.Property(t => t.CreatedAt).IsRequired();
    }
}
