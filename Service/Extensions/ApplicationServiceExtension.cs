using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Data;
using Service.Interface;
using Service.Repository;
using Service.Services;

namespace Service.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
                IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IProductService, ProductsRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);


            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("TeaConnection")));

            return services;
        }

    }
}
