using AutoMapper;
using Series.DIO.Domain.Entities;
using Series.DIO.Domain.Models;
using System.Collections.Generic;

namespace Infra.Shared.Mapper
{
    public static class SerieMapper
    {
        private readonly static IMapper _mapper;
        static SerieMapper()
        {
            _mapper = MapperConfig.RegisterMappers();
        }
        public static SerieEntity ConverterParaSerieEntity(this SerieModel serieModel) =>
            _mapper.Map<SerieEntity>(serieModel);
        public static IEnumerable<SerieEntity> ConverterParaSeriesEntity(this IEnumerable<SerieModel> seriesModel) =>
            _mapper.Map<IEnumerable<SerieEntity>>(seriesModel);

        public static SerieModel ConverterParaSerieModel(this SerieEntity serieEntity) =>
           _mapper.Map<SerieModel>(serieEntity);
        public static IEnumerable<SerieModel> ConverterParaSeriesModel(this IEnumerable<SerieEntity> seriesEntity) =>
            _mapper.Map<IEnumerable<SerieModel>>(seriesEntity);

    }
}
