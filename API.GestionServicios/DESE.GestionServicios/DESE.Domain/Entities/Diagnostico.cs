namespace DESE.Domain.Entities
{
    public class Diagnostico
    {
        public int IdDiagnostico { get; set; }
        public int? IdInscripcion { get; set; }
        public int? IdGestor { get; set; }
        public DateTime? FechaDiagnostico { get; set; }
        public string? Descripcion { get; set; }
        public string? Recomendaciones { get; set; }

        public virtual Gestor? IdGestorNavigation { get; set; }
        public virtual Inscripcion? IdInscripcionNavigation { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}

