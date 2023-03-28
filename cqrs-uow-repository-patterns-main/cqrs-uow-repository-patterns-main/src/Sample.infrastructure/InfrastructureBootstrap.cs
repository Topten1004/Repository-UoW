using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sample.Application.Interfaces;
using Sample.Infrastructure.Context;
using Sample.Infrastructure.Mapper;
using Sample.Infrastructure.Repositories;
using Sample.Infrastructure.UnitOfWorks;

namespace Sample.Infrastructure
{
    public static class InfrastructureBootstrap
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(config =>
            {
                config.UseNpgsql(configuration["ConnectionString"]);
                config.EnableSensitiveDataLogging();
            });

            services.ConfigureMapping();

            #region Repositories
            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient<IUserRepository, UserRepository>();
            #endregion
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}