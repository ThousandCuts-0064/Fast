using Fast.Domain.Avatars;
using Fast.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Fast.Infrastructure;

public static class ServiceCollectionEx
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return
            services.AddScoped<IAvatarRepository, AvatarRepository>();
    }
}
