using Managment.System.Domain.Enums;

namespace Managment.System.Domain.Entities.UserEntities;

public class User : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Salt { get; set; }
    public Status Status { get; set; }
    public ICollection<UserRole> UserRole { get; set; }
}
