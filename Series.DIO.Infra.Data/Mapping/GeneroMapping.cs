using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Series.DIO.Domain.Entities;

namespace Series.DIO.Infra.Data.Mapping
{
    internal sealed class GeneroMapping : IEntityTypeConfiguration<GeneroEntity>
    {
        public void Configure(EntityTypeBuilder<GeneroEntity> builder)
        {
            builder.ToTable("TB_GENERO");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_GENERO");
            builder.Property(p => p.Descricao).HasColumnName("DESCRICAO");
        }
    }
}
