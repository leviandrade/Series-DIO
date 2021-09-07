using Infra.Shared.Mapper;
using Series.DIO.Domain.Interfaces;
using Series.DIO.Domain.Interfaces.Repositories;
using Series.DIO.Domain.Interfaces.Services;
using Series.DIO.Domain.Models;
using Series.DIO.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Generos.DIO.Service.Services
{
    public sealed class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository _generoRepository;
        private readonly IUnitOfWork<SerieContext> _unitOfWork;
        public GeneroService(IGeneroRepository generoRepository, IUnitOfWork<SerieContext> unitOfWork)
        {
            _generoRepository = generoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Atualizar(GeneroModel genero)
        {
            var oGeneroEntity = genero.ConverterParaGeneroEntity();
            _generoRepository.Atualizar(oGeneroEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<GeneroModel> ConsultarPorId(int id)
        {
            var oGeneroEntity = await _generoRepository.ConsultarPorId(id);
            return oGeneroEntity.ConverterParaGeneroModel();
        }

        public async Task Excluir(int id)
        {
            _generoRepository.Excluir(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task Inserir(GeneroModel genero)
        {
            var oGeneroEntity = genero.ConverterParaGeneroEntity();
            await _generoRepository.Incluir(oGeneroEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<GeneroModel>> Listar()
        {
            var lstGeneroEntity = await _generoRepository.Listar();
            return lstGeneroEntity.ConverterParaGenerosModel();
        }
    }
}
