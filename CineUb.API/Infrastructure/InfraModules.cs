using CineUb.API.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CineUb.API.Infrastructure
{
    public static class InfraModules
    {

        public static IServiceCollection AddInfraModules(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSql(configuration);
            return services;
        }

        public static IServiceCollection AddSql(this IServiceCollection services,IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("connection");
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}
