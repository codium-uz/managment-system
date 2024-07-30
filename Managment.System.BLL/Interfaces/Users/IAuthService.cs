using Managment.System.Domain.Entities.UserEntities;

namespace Managment.System.BLL.Interfaces.Users;

public interface IAuthService
{
    string GenerateToken(User user);
}
