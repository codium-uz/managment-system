using Managment.System.BLL.DTOs.UserDTOs;

namespace Managment.System.BLL.Interfaces.Users;

public interface IAccountService
{
    Task<string> LoginAsync(LoginDTO login, CancellationToken cancellation = default);
}
