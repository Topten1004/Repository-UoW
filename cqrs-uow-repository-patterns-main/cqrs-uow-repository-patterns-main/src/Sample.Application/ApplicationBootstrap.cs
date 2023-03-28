using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Application
{
    public static class ApplicationBootstrap
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(assembly);
        }
    }
}