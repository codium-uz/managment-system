using Managment.System.Domain.Entities.GroupEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.GroupConfigurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable("group");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(30).IsRequired(true);
        builder.Property(x => x.Description).HasMaxLength(250);
    }
}
