using Managment.System.Domain.Enums;
using System.Text.Json.Serialization;

namespace Managment.System.BLL.DTOs.StudentDTOs;

public class StudentForResultDto
{
    [JsonPropertyName("firstname")]
    public string FirstName { get; set; }
    [JsonPropertyName("lastname")]
    public string LastName { get; set; }
    [JsonPropertyName("middle_name")]
    public string MiddleName { get; set; }
    [JsonPropertyName("username")]
    public string UserName { get; set; }
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }
    [JsonPropertyName("photo_url")]
    public string PhotoUrl { get; set; }
    [JsonPropertyName("status")]
    public Status Status { get; set; }
}
