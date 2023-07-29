using ALFASOFT.Data.Repositories;
using ALFASOFT.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ALFASOFT.IoC
{
    public static class DependencyInjectionRepositories
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IContactRepository, ContactRepository>();
            return services;
        }
    }
}
