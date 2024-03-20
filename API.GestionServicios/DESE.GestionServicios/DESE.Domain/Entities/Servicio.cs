namespace DESE.Domain.Entities
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public int? IdDiagnostico { get; set; }
        public string? NombreServicio { get; set; }
        public string? Descripcion { get; set; }
        public string? AreaEspecialidad { get; set; }
        public decimal? Costo { get; set; }
        public string? DuracionEstimada { get; set; }

        public virtual Diagnostico? IdDiagnosticoNavigation { get; set; }

    }
}
