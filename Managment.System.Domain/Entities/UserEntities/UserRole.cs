using System.ComponentModel.DataAnnotations;

namespace Managment.System.Domain.Entities.UserEntities;

public class UserRole
{
    [Required]
    public long UserId { get; set; }
    public User? User { get; set; }
    [Required]
    public long RoleId { get; set; }
    public Role? Role { get; set; }
}
