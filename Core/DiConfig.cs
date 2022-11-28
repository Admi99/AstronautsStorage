using Core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class DiConfig
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IAstronautService, AstronautService>();
    }
}