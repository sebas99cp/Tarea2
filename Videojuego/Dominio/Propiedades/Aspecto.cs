namespace Videojuego.Dominio.Propiedades
{
    public class Aspecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid Id { get; set; }

        public Aspecto(string nombre, string descripcion)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
