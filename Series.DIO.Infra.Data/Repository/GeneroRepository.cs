using Series.DIO.Domain.Entities;
using Series.DIO.Domain.Interfaces.Repositories;
using Series.DIO.Infra.Data.Context;

namespace Series.DIO.Infra.Data.Repository
{
    public sealed class GeneroRepository : RepositoryBase<GeneroEntity, SerieContext>, IGeneroRepository
    {
        public GeneroRepository(SerieContext context) : base(context)
        {
        }
    }
}
