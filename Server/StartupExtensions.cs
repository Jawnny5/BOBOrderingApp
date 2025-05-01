using AutoMapper;
using BOBOrderingApp.Server.ApiMappingProfiles;
using BOBOrderingApp.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BOBOrderingApp.Server;

public static class StartupExtensions
{
    public static void AddAppServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ApiMappingProfile));
        services.AddSingleton<IMenuItemService, HardcodedMenuItemService>();
    }
}
