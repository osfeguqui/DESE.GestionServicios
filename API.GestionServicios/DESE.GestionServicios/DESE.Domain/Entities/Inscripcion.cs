namespace DESE.Domain.Entities
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? FechaInscripcion { get; set; }
        public string? EstadoInscripcion { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
        public virtual ICollection<Seguimiento> Seguimientos { get; set; }
    }
}
