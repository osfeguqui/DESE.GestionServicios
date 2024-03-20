
using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DESE.Infrastructure.Persistence.Configurations
{
    public class ServicioConfiguration : IEntityTypeConfiguration<Servicio>
    {
        public void Configure(EntityTypeBuilder<Servicio> builder)
        {
            builder.HasKey(e => e.IdServicio)
                    .HasName("PK__Servicio__1932F5842A41E545");

            builder.ToTable("Servicio");

            builder.Property(e => e.IdServicio).HasColumnName("ID_Servicio");

            builder.Property(e => e.AreaEspecialidad)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Costo).HasColumnType("decimal(10, 2)");

            builder.Property(e => e.Descripcion).HasColumnType("text");

            builder.Property(e => e.DuracionEstimada)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.IdDiagnostico).HasColumnName("ID_Diagnostico");

            builder.Property(e => e.NombreServicio)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.HasOne(d => d.IdDiagnosticoNavigation)
                .WithMany(p => p.Servicios)
                .HasForeignKey(d => d.IdDiagnostico)
                .HasConstraintName("FK__Servicio__ID_Dia__440B1D61");
        }
    }
}
