using Managment.System.Domain.Enums;
using System.Text.RegularExpressions;

namespace Managment.System.Domain.Entities.StudentEntities;

public class Student : AudiTable
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public required string UserName { get; set; }
    public required string PhoneNumber { get; set; }
    public string? PhotoUrl { get; set; }
    public Status Status { get; set; }
    public long GroupId { get; set; }
    public required Group Group { get; set; }
    public ICollection<StudentScience>? StudentSciences { get; set; }
    public ICollection<StudentTaskResult>? TasksResults { get; set; }
}
