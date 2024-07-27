using Videojuego.Dominio.Propiedades;

namespace Videojuego.Dominio.Tipos
{
    public class TipoPersonaje
    {
        public string NombreClase { get; set; }
        public Habilidad[] Habilidades { get; set; }
        public Guid Id { get; set; }
    }
}
