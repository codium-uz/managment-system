using Managment.System.Domain.Entities.StudentEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Managment.System.DAL.Data.Contexts.StudentConfigurations;

public class StudentAttendanceConfiguration : IEntityTypeConfiguration<StudentAttendance>
{
    public void Configure(EntityTypeBuilder<StudentAttendance> builder)
    {
        builder.ToTable("student_attendances");
        builder.HasKey(s => new { s.StudentId, s.TopicId });
        builder.Property(s => s.StudentId).IsRequired(true);
        builder.Property(s => s.TopicId).IsRequired(true);
    }
}
