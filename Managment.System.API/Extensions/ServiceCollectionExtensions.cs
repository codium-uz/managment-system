using Managment.System.DAL.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Managment.System.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddContext(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionStrings = configuration.GetConnectionString("localhost");

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionStrings));

        return services;
    }
}
