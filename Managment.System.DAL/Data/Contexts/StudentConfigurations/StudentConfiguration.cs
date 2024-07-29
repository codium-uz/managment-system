using Managment.System.Domain.Entities.StudentEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.StudentConfigurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("students");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.FirstName).IsRequired(true);
        builder.Property(t => t.LastName).IsRequired(true);
        builder.Property(t => t.MiddleName).IsRequired(true);
        builder.HasIndex(t => t.UserName).IsUnique();
        builder.HasIndex(t => t.PhoneNumber).IsUnique();
    }
}
