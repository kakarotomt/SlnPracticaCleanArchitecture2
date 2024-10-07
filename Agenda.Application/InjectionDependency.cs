using Microsoft.Extensions.DependencyInjection;

namespace Agenda.Application
{
    public static class InjectionDependency
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(opt =>
            {
                opt.RegisterServicesFromAssemblies(typeof(InjectionDependency).Assembly);
            });
            return services;
        }
    }
}
