using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenBank.Entities.Interfaces;
using OpenBank.RepositoryEF.DataContext;
using OpenBank.RepositoryEF.Repositories;

namespace OpenBank.RepositoryEF
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OpenBankContext>(options => options.UseSqlServer(configuration.GetConnectionString("OpenBank")));
            services.AddScoped<ITargetaRepository, TargetaRepository>();
            services.AddScoped<IRegistroRepository, RegistroRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
