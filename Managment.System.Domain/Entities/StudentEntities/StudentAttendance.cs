namespace Managment.System.Domain.Entities.StudentEntities;

public class StudentAttendance
{
    public required long TopicId { get; set; }
    public required long StudentId { get; set; }
    public Student? Student { get; set; }
    public bool Attend { get; set; }
}
