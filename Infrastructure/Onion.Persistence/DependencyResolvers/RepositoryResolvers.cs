using Microsoft.Extensions.DependencyInjection;
using Onion.Contract.RepositoryInterfaces;
using Onion.Persistence.RepositoryConcretes;

namespace Onion.Persistence.DependencyResolvers
{
    public static class RepositoryResolvers
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppUserProfileRepository, AppUserProfileRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductAttributeRepository, ProductAttributeRepository>();
            services.AddScoped<IProductAttributeValueRepository, ProductAttributeValueRepository>();

            //BaseRepository abstract değilse ve generic ise aşağıdaki satır kullanılabilir.
            //services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
    }
}
