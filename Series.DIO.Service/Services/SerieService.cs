using Infra.Shared.Mapper;
using Series.DIO.Domain.Interfaces;
using Series.DIO.Domain.Interfaces.Repositories;
using Series.DIO.Domain.Interfaces.Services;
using Series.DIO.Domain.Models;
using Series.DIO.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Series.DIO.Service.Services
{
    public sealed class SerieService : ISerieService
    {
        private readonly ISerieRepository _serieRepository;
        private readonly IUnitOfWork<SerieContext> _unitOfWork;

        public SerieService(ISerieRepository serieRepository, IUnitOfWork<SerieContext> unitOfWork)
        {
            _serieRepository = serieRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Atualizar(SerieModel serie)
        {
            var oSerieEntity = serie.ConverterParaSerieEntity();
            _serieRepository.Atualizar(oSerieEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<SerieModel> ConsultarPorId(int id)
        {
            var oSerieEntity = await _serieRepository.ConsultarPorId(id);
            return oSerieEntity.ConverterParaSerieModel();
        }

        public async Task Excluir(int id)
        {
            _serieRepository.Excluir(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task Inserir(SerieModel serie)
        {
            var oSerieEntity = serie.ConverterParaSerieEntity();
            await _serieRepository.Incluir(oSerieEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<SerieModel>> Listar()
        {
            var lstSerieEntity = await _serieRepository.Listar();
            return lstSerieEntity.ConverterParaSeriesModel();
        }
    }
}
