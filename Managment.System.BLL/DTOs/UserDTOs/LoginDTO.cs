using System.Text.Json.Serialization;

namespace Managment.System.BLL.DTOs.UserDTOs;

public class LoginDTO
{
    [JsonPropertyName("username")]
    public string UserName { get; set; }
    [JsonPropertyName ("password")]
    public string Password { get; set; }
}
