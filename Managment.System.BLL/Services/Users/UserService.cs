using AutoMapper;
using Managment.System.BLL.Commons;
using Managment.System.BLL.DTOs.UserDTOs;
using Managment.System.BLL.Helpers;
using Managment.System.BLL.Interfaces.Users;
using Managment.System.Domain.Entities.UserEntities;
using Managment.System.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Managment.System.BLL.Services.Users;

public class UserService(
    IRepository<User> repository, 
    IMapper mapper, 
    IConfiguration configuration) : IUserService
{
    public async Task<UserDTO> RegisterAsync(RegisterDTO register, CancellationToken cancellation = default)
    {
        var user = await repository.SelectAsync(x => x.UserName == register.UserName);
        if (user is not null)
            throw new CustomException(404, "User is already exists");

        var hasherResult = PassworHelper.Hash(register.Password);
        var mapped = mapper.Map<User>(register);

        mapped.Salt = hasherResult.salt;
        mapped.Password = hasherResult.hash;
        mapped.CreatedAt = DateTime.UtcNow.AddHours(5);

        var result = await repository.AddAsync(mapped, cancellation);
        await repository.SaveAsync(cancellation);
        return mapper.Map<UserDTO>(result);
    }

    public async Task<bool> RemoveAsync(long id, CancellationToken cancellation = default)
    {
        var user = await repository.ExistsAsync(id, cancellation);
        if (user is false)
            throw new CustomException(404, "User not found");

        await repository.DeleteAsync(id, cancellation);
        return await repository.SaveAsync(cancellation);
    }

    public async Task<UserDTO> RetreiveByIdAsync(long id, CancellationToken cancellation = default)
    {
        var userQuery = await repository.SelectAllAsync(null, null, cancellation);

        var user = await userQuery
            .Where(x => x.Id == id)
            .AsNoTracking()
            .ToListAsync(cancellation);

        if (user is null)
            throw new CustomException(404, "User not found");

        var mapped = mapper.Map<UserDTO>(user);
        return mapped;
    }

    public async Task<IEnumerable<UserDTO>> RetrieveAllAsync(CancellationToken cancellation = default)
    {
        var userQuery = await repository.SelectAllAsync(null, null, cancellation);

        var mapped = mapper.Map<IEnumerable<UserDTO>>(userQuery);

        return mapped;
    }
}
