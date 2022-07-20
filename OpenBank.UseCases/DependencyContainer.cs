using Microsoft.Extensions.DependencyInjection;
using OpenBank.UseCases.CreateRegistro;
using OpenBank.UseCases.CreateTargeta;
using OpenBank.UseCases.GetTargeta;
using OpenBank.UseCasesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices (this IServiceCollection services)
        {
            services.AddTransient<IUpdateTarjetaInputPort, UpdateTarjetaIterator>();
            services.AddTransient<IGetTargetaInputPort, GetTarjetaIterator>();
            services.AddTransient<IRegistroInputPort, RegistroIterator>();
            return services;

        }
    }
}
