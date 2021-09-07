using Series.DIO.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Series.DIO.Domain.Interfaces.Services
{
    public interface ISerieService
    {
        Task<IEnumerable<SerieModel>> Listar();
        Task<SerieModel> ConsultarPorId(int id);
        Task Excluir(int id);
        Task Inserir(SerieModel serie);
        Task Atualizar(SerieModel serie);
    }
}
