﻿using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(opt => opt.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly));
            return services;
        }

    }
}
