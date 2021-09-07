using Microsoft.EntityFrameworkCore;
using Series.DIO.Domain.Entities;
using Series.DIO.Infra.Data.Mapping;

namespace Series.DIO.Infra.Data.Context
{
    public class SerieContext : DbContext
    {
        public SerieContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SerieEntity> Serie { get; set; }
        public DbSet<GeneroEntity> Genero { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GeneroMapping());
            modelBuilder.ApplyConfiguration(new SerieMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
