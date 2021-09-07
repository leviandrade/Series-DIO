using AutoMapper;
using Series.DIO.Domain.Entities;
using Series.DIO.Domain.Models;
using System.Collections.Generic;

namespace Infra.Shared.Mapper
{
    public static class GeneroMapper
    {
        private static readonly IMapper _mapper = MapperConfig.RegisterMappers();
        public static GeneroEntity ConverterParaGeneroEntity(this GeneroModel generoModel) =>
            _mapper.Map<GeneroEntity>(generoModel);
        public static IEnumerable<GeneroEntity> ConverterParaGenerosEntity(this IEnumerable<GeneroModel> generosModel) =>
            _mapper.Map<IEnumerable<GeneroEntity>>(generosModel);

        public static GeneroModel ConverterParaGeneroModel(this GeneroEntity generoEntity) =>
           _mapper.Map<GeneroModel>(generoEntity);
        public static IEnumerable<GeneroModel> ConverterParaGenerosModel(this IEnumerable<GeneroEntity> generosEntity) =>
            _mapper.Map<IEnumerable<GeneroModel>>(generosEntity);
    }
}
