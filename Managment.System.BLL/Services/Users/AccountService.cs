using Managment.System.BLL.Commons;
using Managment.System.BLL.DTOs.UserDTOs;
using Managment.System.BLL.Helpers;
using Managment.System.BLL.Interfaces.Users;
using Managment.System.Domain.Entities.UserEntities;
using Managment.System.Infrastructure.Repositories;

namespace Managment.System.BLL.Services.Users;

public class AccountService(IRepository<User> repository, IAuthService authService) : IAccountService
{
    public async Task<string> LoginAsync(LoginDTO login, CancellationToken cancellation = default)
    {
        var user = await repository.SelectAsync(x => x.UserName == login.UserName);
        if (user is null)
            throw new CustomException(404, "User is null");

        var hasherResult = PassworHelper.Verify(login.Password, user.Salt, user.Password);
        if (hasherResult is false)
            throw new CustomException(404, "Password is wrong!");

        return authService.GenerateToken(user);
    }
}
