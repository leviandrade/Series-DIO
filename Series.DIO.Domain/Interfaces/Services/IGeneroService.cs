using Series.DIO.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Series.DIO.Domain.Interfaces.Services
{
    public interface IGeneroService
    {
        Task<IEnumerable<GeneroModel>> Listar();
        Task<GeneroModel> ConsultarPorId(int id);
        Task Excluir(int id);
        Task Inserir(GeneroModel genero);
        Task Atualizar(GeneroModel genero);
    }
}
