using ALFASOFT.Application.AutoMapper;
using ALFASOFT.Application.Services;
using ALFASOFT.Data.Repositories;
using ALFASOFT.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ALFASOFT.IoC
{
    public static class DependencyInjectionServices
    {
        public static IServiceCollection RegisterSevices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
           
            services.AddScoped<IContactService, ContactService>();
            return services;
        }
    }
}
