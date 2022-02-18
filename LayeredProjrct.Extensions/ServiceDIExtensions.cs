using LayeredProjrct.Core.Implement;
using LayeredProjrct.Core.Interface.Repository;
using LayeredProjrct.Core.Interface.Service;
using LayeredProjrct.Repository.Implement;
using Microsoft.Extensions.DependencyInjection;
namespace LayeredProjrct.Extensions
{
    public static class DIExtensions
    {
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
            services.AddScoped<IProductService, ProductService>();
            return services;
		}

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

    }

}
