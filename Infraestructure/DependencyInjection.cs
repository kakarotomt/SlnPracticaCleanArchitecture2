using Dominio.Abstractions;
using Dominio.Abstractions.Repositories;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            string stringConnection = configuration.GetConnectionString("AppStringConnection") ??throw new Exception("Error gravisimo");

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(stringConnection));

            services.AddScoped<IAgendaRepository, AgendaRepository>();
            services.AddScoped<IUnitOfWork>(opt => opt.GetRequiredService<ApplicationDbContext>());

            return services;
        }

    }
}
