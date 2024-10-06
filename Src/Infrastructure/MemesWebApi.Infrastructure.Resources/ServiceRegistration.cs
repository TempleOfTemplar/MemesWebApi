using MemesWebApi.Application.Interfaces;
using MemesWebApi.Infrastructure.Resources.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MemesWebApi.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}
