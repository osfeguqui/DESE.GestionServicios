using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DESE.Infrastructure.Persistence.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.IdCliente)
                   .HasName("PK__Cliente__E005FBFF6A95E4B3");

            builder.ToTable("Cliente");

            builder.HasIndex(e => e.NumeroDocumentoIdentidad, "UQ__Cliente__2B8421E6BE51276D")
                .IsUnique();

            builder.Property(e => e.IdCliente).HasColumnName("ID_Cliente");

            builder.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Empresa)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.OtrosDetalles).HasColumnType("text");

            builder.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
