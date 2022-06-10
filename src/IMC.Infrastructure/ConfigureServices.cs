using Microsoft.Extensions.DependencyInjection;

namespace IMC.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services)
        {
            return services;
        }
    }
}
