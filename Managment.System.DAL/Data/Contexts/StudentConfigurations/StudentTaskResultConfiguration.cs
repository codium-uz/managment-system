using Managment.System.Domain.Entities.StudentEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.StudentConfigurations;

public class StudentTaskResultConfiguration : IEntityTypeConfiguration<StudentTaskResult>
{
    public void Configure(EntityTypeBuilder<StudentTaskResult> builder)
    {
        builder.ToTable("student_task_results");
        builder.HasKey(s => new {s.TaskId, s.StudentId});

        builder.Property(s => s.Content).IsRequired(true);
        builder.Property(s => s.CreatedAt).IsRequired(true);
    }
}
