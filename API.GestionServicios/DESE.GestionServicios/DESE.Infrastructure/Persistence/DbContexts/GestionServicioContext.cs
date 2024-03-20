using DESE.Application.Interfaces;
using DESE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace DESE.Infrastructure.Persistence.DbContexts
{
    public partial class GestionServicioContext : DbContext, IApplicationDbContext
    {
        public GestionServicioContext() 
        { 
        }

        public GestionServicioContext(DbContextOptions<GestionServicioContext> options) : base(options)
        {
        }
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Diagnostico> Diagnosticos { get; set; } = null!;
        public virtual DbSet<Gestor> Gestors { get; set; } = null!;
        public virtual DbSet<Inscripcion> Inscripcions { get; set; } = null!;
        public virtual DbSet<Seguimiento> Seguimientos { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
