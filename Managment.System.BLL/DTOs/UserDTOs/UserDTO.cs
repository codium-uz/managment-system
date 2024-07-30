using Managment.System.Domain.Entities.UserEntities;
using Managment.System.Domain.Enums;
using System.Text.Json.Serialization;

namespace Managment.System.BLL.DTOs.UserDTOs;

public class UserDTO
{
    [JsonPropertyName("username")]
    public string UserName { get; set; }
    [JsonPropertyName("password")]
    public string Password { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonPropertyName("status")]
    public Status Status { get; set; }
    [JsonPropertyName("user_roles")]
    public ICollection<UserRole> UserRoles { get; set; }
}
