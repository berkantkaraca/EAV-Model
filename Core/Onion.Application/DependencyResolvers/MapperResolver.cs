using Microsoft.Extensions.DependencyInjection;
using Onion.Application.MappingProfiles;

namespace Onion.Application.DependencyResolvers
{
    public static class MapperResolver
    {
        public static void AddMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
