namespace Managment.System.Domain.Entities.StudentEntities;

public class StudentTaskResult
{
    public required long TaskId { get; set; }
    public required long StudentId { get; set; }
    public Student? Student { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public string Content { get; set; }
}
