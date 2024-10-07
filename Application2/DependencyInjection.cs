using Microsoft.Extensions.DependencyInjection;

namespace Application2
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddApplication(this IServiceCollection services) {

            services.AddMediatR(opt => opt.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly));
            
            return services;
        }
    }
}
