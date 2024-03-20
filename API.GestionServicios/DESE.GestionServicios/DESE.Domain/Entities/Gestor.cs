namespace DESE.Domain.Entities
{
    public class Gestor
    {
        public int IdGestor { get; set; }
        public int? NumeroDocumentoIdentidad { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Especialidad { get; set; }
        public string? HorarioDisponibilidad { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }

        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
    }
}
