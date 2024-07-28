namespace GestionTareas.Dominio
{
    public class Tarea
    {
        public Guid Id { get; set; }
        public string Estado { get; set; } = "Activa";
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; } = null;
    }
}
