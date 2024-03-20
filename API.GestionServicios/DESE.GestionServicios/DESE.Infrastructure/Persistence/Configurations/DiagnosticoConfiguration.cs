using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DESE.Infrastructure.Persistence.Configurations
{
    public class DiagnosticoConfiguration : IEntityTypeConfiguration<Diagnostico>
    {
        public void Configure(EntityTypeBuilder<Diagnostico> builder)
        {
            builder.HasKey(e => e.IdDiagnostico)
                    .HasName("PK__Diagnost__1A01BCE38072E33E");

            builder.ToTable("Diagnostico");

            builder.Property(e => e.IdDiagnostico).HasColumnName("ID_Diagnostico");

            builder.Property(e => e.Descripcion).HasColumnType("text");

            builder.Property(e => e.FechaDiagnostico).HasColumnType("datetime");

            builder.Property(e => e.IdGestor).HasColumnName("ID_Gestor");

            builder.Property(e => e.IdInscripcion).HasColumnName("ID_Inscripcion");

            builder.Property(e => e.Recomendaciones).HasColumnType("text");

            builder.HasOne(d => d.IdGestorNavigation)
                .WithMany(p => p.Diagnosticos)
                .HasForeignKey(d => d.IdGestor)
                .HasConstraintName("FK__Diagnosti__ID_Ge__412EB0B6");

            builder.HasOne(d => d.IdInscripcionNavigation)
                .WithMany(p => p.Diagnosticos)
                .HasForeignKey(d => d.IdInscripcion)
                .HasConstraintName("FK__Diagnosti__ID_In__403A8C7D");
        }
    }
}
