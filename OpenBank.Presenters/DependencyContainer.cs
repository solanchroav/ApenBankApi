using Microsoft.Extensions.DependencyInjection;
using OpenBank.UseCasesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IGetTargetaOutputPort, CreateTargetaPresenter>();
            return services;
        }
    }
}
