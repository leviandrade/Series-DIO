using Microsoft.EntityFrameworkCore;
using Series.DIO.Domain.Entities;
using Series.DIO.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Series.DIO.Infra.Data.Repository
{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        protected readonly TContext _context;

        public RepositoryBase(TContext context)
        {
            _context = context;
        }

        public virtual void Atualizar(List<TEntity> list)
        {
            _context.Entry(list).State = EntityState.Modified;
        }

        public virtual void Atualizar(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public virtual async Task<TEntity> ConsultarPorId(int id)
        {
            var query = _context.Set<TEntity>().Where(p => p.Id.Equals(id));
            return await query.FirstOrDefaultAsync();
        }

        public virtual async Task Incluir(List<TEntity> list)
        {
            await _context.Set<TEntity>().AddRangeAsync(list);
        }

        public virtual async Task Incluir(TEntity obj)
        {
            await _context.Set<TEntity>().AddAsync(obj);
        }

        public virtual async Task<IEnumerable<TEntity>> Listar()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual void Excluir(int id)
        {
            var obj = ConsultarPorId(id);
            _context.Remove(obj);
        }
    }
}
