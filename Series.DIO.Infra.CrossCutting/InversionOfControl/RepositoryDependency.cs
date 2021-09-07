using Microsoft.Extensions.DependencyInjection;
using Series.DIO.Domain.Interfaces;
using Series.DIO.Domain.Interfaces.Repositories;
using Series.DIO.Infra.Data.Context;
using Series.DIO.Infra.Data.Repository;

namespace Series.DIO.Infra.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork<SerieContext>, UnitOfWork<SerieContext>>();
            services.AddScoped<IGeneroRepository, GeneroRepository>();
            services.AddScoped<ISerieRepository, SerieRepository>();
        }
    }
}
