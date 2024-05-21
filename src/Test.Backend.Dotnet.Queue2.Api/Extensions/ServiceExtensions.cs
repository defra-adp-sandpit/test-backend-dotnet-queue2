using Test.Backend.Dotnet.Queue2.Core.Interfaces;
using Test.Backend.Dotnet.Queue2.Core.Services;

namespace Test.Backend.Dotnet.Queue2.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
