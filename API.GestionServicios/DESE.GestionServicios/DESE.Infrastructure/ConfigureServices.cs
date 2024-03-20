using DESE.Application.Interfaces;
using DESE.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DESE.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GestionServicioContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DB_GestionServicio"));
            });

            services.AddScoped<IApplicationDbContext, GestionServicioContext>();
            return services;
        }
    }
}
