using System.Collections.Generic;
using System.Threading.Tasks;

namespace Series.DIO.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> ConsultarPorId(int id);
        Task Incluir(List<TEntity> list);
        Task Incluir(TEntity obj);
        void Atualizar(List<TEntity> list);
        void Atualizar(TEntity obj);
        Task<IEnumerable<TEntity>> Listar();
        void Excluir(int id);
    }
}
