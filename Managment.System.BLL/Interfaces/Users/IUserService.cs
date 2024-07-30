using Managment.System.BLL.DTOs.UserDTOs;

namespace Managment.System.BLL.Interfaces.Users;

public interface IUserService
{
    Task<IEnumerable<UserDTO>> RetrieveAllAsync(CancellationToken cancellation = default);
    Task<UserDTO> RetreiveByIdAsync(long id, CancellationToken cancellation = default);
    Task<UserDTO> RegisterAsync(RegisterDTO register, CancellationToken cancellation = default);
    Task<bool> RemoveAsync(long id, CancellationToken cancellation = default);
}
