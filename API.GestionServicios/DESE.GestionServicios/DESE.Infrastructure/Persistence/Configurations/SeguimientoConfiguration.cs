using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DESE.Infrastructure.Persistence.Configurations
{
    public class SeguimientoConfiguration : IEntityTypeConfiguration<Seguimiento>
    {
        public void Configure(EntityTypeBuilder<Seguimiento> builder)
        {
            builder.HasKey(e => e.IdSeguimiento)
                    .HasName("PK__Seguimie__B710FBA385B06C2A");

            builder.ToTable("Seguimiento");

            builder.Property(e => e.IdSeguimiento).HasColumnName("ID_Seguimiento");

            builder.Property(e => e.ActividadRealizada).HasColumnType("text");

            builder.Property(e => e.FechaSeguimiento).HasColumnType("date");

            builder.Property(e => e.IdInscripcion).HasColumnName("ID_Inscripcion");

            builder.Property(e => e.Resultados).HasColumnType("text");

            builder.HasOne(d => d.IdInscripcionNavigation)
                .WithMany(p => p.Seguimientos)
                .HasForeignKey(d => d.IdInscripcion)
                .HasConstraintName("FK__Seguimien__ID_In__46E78A0C");
        }
    }
}
