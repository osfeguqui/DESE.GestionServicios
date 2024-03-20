

using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DESE.Infrastructure.Persistence.Configurations
{
    public class InscripcionConfiguration : IEntityTypeConfiguration<Inscripcion>
    {
        public void Configure(EntityTypeBuilder<Inscripcion> builder)
        {
            builder.HasKey(e => e.IdInscripcion)
                   .HasName("PK__Inscripc__B84666E01A179CCC");

            builder.ToTable("Inscripcion");

            builder.Property(e => e.IdInscripcion).HasColumnName("ID_Inscripcion");

            builder.Property(e => e.EstadoInscripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FechaInscripcion).HasColumnType("date");

            builder.Property(e => e.IdCliente).HasColumnName("ID_Cliente");

            builder.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.Inscripcions)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Inscripci__ID_Cl__3D5E1FD2");
        }
    }
}
