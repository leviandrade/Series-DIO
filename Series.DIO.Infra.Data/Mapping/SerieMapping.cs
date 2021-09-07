using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Series.DIO.Domain.Entities;

namespace Series.DIO.Infra.Data.Mapping
{
    internal sealed class SerieMapping : IEntityTypeConfiguration<SerieEntity>
    {
        public void Configure(EntityTypeBuilder<SerieEntity> builder)
        {
            builder.ToTable("TB_SERIE");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_SERIE");
            builder.Property(p => p.IdGenero).HasColumnName("ID_GENERO");
            builder.Property(p => p.Ano).HasColumnName("NR_ANO");
            builder.Property(p => p.Descricao).HasColumnName("DESCRICAO");
            builder.Property(p => p.Titulo).HasColumnName("NM_TITULO");
            builder.Property(p => p.Excluido).HasColumnName("FL_EXCLUIDO");

            builder.HasOne(p => p.Genero)
                   .WithMany()
                   .HasForeignKey(p => p.IdGenero);
        }
    }
}
