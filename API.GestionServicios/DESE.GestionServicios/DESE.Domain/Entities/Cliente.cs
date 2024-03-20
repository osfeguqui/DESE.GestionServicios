namespace DESE.Domain.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int? NumeroDocumentoIdentidad { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Empresa { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? OtrosDetalles { get; set; }

        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
