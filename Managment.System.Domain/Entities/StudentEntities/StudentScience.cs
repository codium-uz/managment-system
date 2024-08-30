using Managment.System.Domain.Entities.ScienceEntities;
using Managment.System.Domain.Enums;

namespace Managment.System.Domain.Entities.StudentEntities;

public class StudentScience
{
    public required long ScienceId { get; set; }
    public required long StudentId { get; set; }
    public Student? Student { get; set; }
    public Science? Science { get; set; }
    public required DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Status Status { get; set; }
}
