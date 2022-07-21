using Microsoft.Extensions.DependencyInjection;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IGetTargetaOutputPort, GetTarjetaPresenter>();
            services.AddScoped<IUpdateTarjetaOutputPort, UpdateTarjetaPresenter>();
            services.AddScoped<IRegistroOutputPort, RegistroPresenter>();
            return services;
        }
    }
}
