namespace DESE.Domain.Entities
{
    public class Seguimiento
    {
        public int IdSeguimiento { get; set; }
        public int? IdInscripcion { get; set; }
        public DateTime? FechaSeguimiento { get; set; }
        public string? ActividadRealizada { get; set; }
        public string? Resultados { get; set; }

        public virtual Inscripcion? IdInscripcionNavigation { get; set; }
    }
}
