using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Infrastructure.Mapper
{
    public static class ConfigureMappingExtension
    {
        public static void ConfigureMapping(this IServiceCollection service)
        {
            var assembly = Assembly.GetExecutingAssembly();
            service.AddAutoMapper(assembly);

            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}