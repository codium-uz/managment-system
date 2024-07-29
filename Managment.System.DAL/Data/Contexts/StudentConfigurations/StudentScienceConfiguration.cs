using Managment.System.Domain.Entities.StudentEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.StudentConfigurations;

public class StudentScienceConfiguration : IEntityTypeConfiguration<StudentScience>
{
    public void Configure(EntityTypeBuilder<StudentScience> builder)
    {
        builder.ToTable("student_sciences");
        builder.HasKey(s => s.ScienceId);
        builder.Property(s => s.ScienceId).IsRequired(true);
        builder.Property(s => s.StudentId).IsRequired(true);
        builder.Property(s => s.CreatedAt).IsRequired(true);

        builder.HasOne(s => s.Student)
            .WithMany(s => s.StudentSciences)
            .HasForeignKey(s => s.StudentId);
    }
}
