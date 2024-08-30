using System.Text.Json.Serialization;

namespace Managment.System.BLL.DTOs.StudentDTOs;

public class StudentForAttendanceDto
{
    [JsonPropertyName("topic_id")]
    public required long TopicId { get; set; }
    [JsonPropertyName("student_id")]
    public required long StudentId { get; set; }
    [JsonPropertyName("attend")]
    public bool Attend { get; set; }
}
