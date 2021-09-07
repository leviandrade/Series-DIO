using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Series.DIO.Infra.Data.Context;

namespace Series.DIO.Infra.CrossCutting.InversionOfControl
{
    public static class SqlDependency
    {
        public static void AddSqlDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SerieContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("Serie")), ServiceLifetime.Scoped);

        }
    }
}
