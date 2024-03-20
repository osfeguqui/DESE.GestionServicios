using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DESE.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Diagnostico> Diagnosticos { get; set; }
        DbSet<Gestor> Gestors { get; set; }
        DbSet<Inscripcion> Inscripcions { get; set; }
        DbSet<Seguimiento> Seguimientos { get; set; }
        DbSet<Servicio> Servicios { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
