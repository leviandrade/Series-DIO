using System.Threading.Tasks;

namespace Series.DIO.Domain.Interfaces
{
    public interface IUnitOfWork<TContext> where TContext : class
    {
        void Commit();
        Task CommitAsync();
    }
}
