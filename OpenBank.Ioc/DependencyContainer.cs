using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenBank.Presenters;
using OpenBank.RepositoryEF;
using OpenBank.UseCases;

namespace OpenBank.Ioc
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddOpenBankDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }

    }
}