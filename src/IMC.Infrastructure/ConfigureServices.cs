using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using IMC.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using IMC.Domain.Interfaces;
using IMC.Infrastructure.Persistence.Repository;

namespace IMC.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<IMCDbContext>(options =>
            {
                options.UseInMemoryDatabase("IMC");
            });
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            return services;
        }
    }
}
