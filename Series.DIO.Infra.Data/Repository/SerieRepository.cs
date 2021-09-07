using Microsoft.EntityFrameworkCore;
using Series.DIO.Domain.Entities;
using Series.DIO.Domain.Interfaces.Repositories;
using Series.DIO.Infra.Data.Context;

namespace Series.DIO.Infra.Data.Repository
{
    public sealed class SerieRepository : RepositoryBase<SerieEntity, SerieContext>, ISerieRepository
    {
        public SerieRepository(SerieContext context) : base(context)
        {
        }

        public override void Excluir(int id)
        {
            var obj = base.ConsultarPorId(id); 
            obj.Result.Excluido = true;
            base.Atualizar(obj.Result);
        }
    }
}
