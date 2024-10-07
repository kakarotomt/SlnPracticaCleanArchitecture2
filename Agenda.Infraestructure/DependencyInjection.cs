using Agena.Domain.Abstracts;
using Agena.Domain.Abstracts.Repository;
using Agenda.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Agenda.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var stringConnection = configuration.GetConnectionString("AppStringConnection");
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(stringConnection));

            services.AddScoped<IPersonaRepository, PersonaRepository>();
            services.AddScoped<ITelefonoRespository, TelefonoRepository>();
            services.AddScoped<IUnitOfWork>(opt => opt.GetRequiredService<ApplicationContext>());


            return services;
        }

    }
}
