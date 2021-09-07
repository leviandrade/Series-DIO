using Generos.DIO.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Series.DIO.Domain.Interfaces.Services;
using Series.DIO.Service.Services;

namespace Series.DIO.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IGeneroService, GeneroService>();
            services.AddScoped<ISerieService, SerieService>();
        }
    }
}
