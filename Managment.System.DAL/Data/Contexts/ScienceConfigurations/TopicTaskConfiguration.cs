using Managment.System.Domain.Entities.ScienceEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.ScienceConfigurations;

public class TopicTaskConfiguration : IEntityTypeConfiguration<TopicTask>
{
    public void Configure(EntityTypeBuilder<TopicTask> builder)
    {
        builder.ToTable("topic_task");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Title).IsRequired().HasMaxLength(30);
        builder.Property(t => t.Description).HasMaxLength(250);
        builder.Property(t => t.CreatedAt).IsRequired();
    }
}
