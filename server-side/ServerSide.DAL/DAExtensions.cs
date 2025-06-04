using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServerSide.DAL.Context;

namespace ServerSide.DAL
{
    public static class DAExtensions
    {
        public static void AddDataAccessExtensions(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GAMADBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
