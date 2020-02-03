using ExampleProject.Application.Common;
using ExampleProject.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ExampleProject.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //write your projectbased DI here
            services.AddTransient<IDateTime, DateTimeService>();
            return services;
        }
    }
}
