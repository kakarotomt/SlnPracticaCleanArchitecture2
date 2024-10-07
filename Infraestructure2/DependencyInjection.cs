using Dominio2.Abtractions;
using Dominio2.Abtractions.Repositories;
using Infraestructure2.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure2
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var stringConnection = configuration.GetConnectionString("AppStringConnection");
            services.AddDbContext<ApplicationDbContext>(options => { options.UseSqlServer(stringConnection); });
            services.AddScoped<IRegistroRepository, RegistroRepository>();

            services.AddScoped<IUnitOfWork>(opt => opt.GetRequiredService<ApplicationDbContext>());

            return services;
        }

    }
}
