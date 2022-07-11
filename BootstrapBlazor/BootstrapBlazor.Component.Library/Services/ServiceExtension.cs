using BootstrapBlazor.Component.Library.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BootstrapBlazor;

public static class ServiceExtension
{
    public static void AddBootstrapBlazor(this IServiceCollection services)
    {
        services.AddScoped<IClassBuilder, ClassBuilder>();
    }
}
