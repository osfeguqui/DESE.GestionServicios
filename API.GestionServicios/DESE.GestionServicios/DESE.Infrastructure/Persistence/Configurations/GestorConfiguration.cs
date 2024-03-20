

using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DESE.Infrastructure.Persistence.Configurations
{
    public class GestorConfiguration : IEntityTypeConfiguration<Gestor>
    {
        public void Configure(EntityTypeBuilder<Gestor> builder)
        {
            builder.HasKey(e => e.IdGestor)
                    .HasName("PK__Gestor__F03D3125DB5AB144");

            builder.ToTable("Gestor");

            builder.HasIndex(e => e.NumeroDocumentoIdentidad, "UQ__Gestor__2B8421E62F1FC22F")
                .IsUnique();

            builder.Property(e => e.IdGestor).HasColumnName("ID_Gestor");

            builder.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Especialidad)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.HorarioDisponibilidad)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
