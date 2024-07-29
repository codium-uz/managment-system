using Managment.System.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.UserConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.UserName).IsRequired();
        builder.HasIndex(t => t.UserName).IsUnique();
        builder.Property(t => t.Password).IsRequired();
    }
}
