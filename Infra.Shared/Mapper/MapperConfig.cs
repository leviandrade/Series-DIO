using AutoMapper;
using Series.DIO.Domain.Entities;
using Series.DIO.Domain.Models;

namespace Infra.Shared.Mapper
{
    public class MapperConfig
    {
        public static IMapper RegisterMappers()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GeneroEntity, GeneroModel>().ReverseMap();
                cfg.CreateMap<SerieEntity, SerieModel>().ReverseMap();
            });

            return config.CreateMapper();
        }
    }
}
