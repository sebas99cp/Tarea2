namespace Videojuego.Dominio.Propiedades
{
    public class Habilidad
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }
        public Guid Id { get; set; }

        //contructor
        public Habilidad(string nombre, string descripcion, int nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
            Id = Guid.NewGuid();
        }
    }
}
