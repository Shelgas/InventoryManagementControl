using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace IMC.Application

{
    public static class CinfigureApplicationServices
    {
        public static IServiceCollection AddApplication(
          this IServiceCollection services)
        {
            services.AddMediatR(typeof(CinfigureApplicationServices).Assembly);
            return services;
        }
    }
}
