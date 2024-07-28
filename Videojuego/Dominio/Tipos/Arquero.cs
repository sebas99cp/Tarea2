using Videojuego.Dominio.Propiedades;

namespace Videojuego.Dominio.Tipos
{
    public class Arquero : TipoPersonaje
    {
        //propiedades
        public static string NombreClase { get; set; } = "Arquero";
        public Habilidad[] habilidades { get; set; }

        //constructor
        public Arquero()
        {
            Id = Guid.NewGuid();
            habilidades = new Habilidad[]
            {
                new Habilidad("Disparo certero", "Dispara una flecha con gran precisión", 1),
                new Habilidad("Flecha envenenada", "Dispara una flecha envenenada", 2),
                new Habilidad("Flecha de fuego", "Dispara una flecha que explota al impactar", 3)
            };
        }
    }
}
