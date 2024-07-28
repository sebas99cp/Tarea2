using Videojuego.Dominio;
using Videojuego.Dominio.Propiedades;
using Videojuego.Dominio.Tipos;

namespace Videojuego
{
    public class EjecucionVideojuego
    {
        public static void Main()
        {
            Console.WriteLine("Empezando ejercicio 1:  videojuego");

            //creacion de un usuario
            Usuario usuario1 = new Usuario("Mahecha");
            Console.WriteLine(usuario1.Nickname);

            //creación de personajes
            Arquero arquero1 = new Arquero();
            Guerrero guerrero1 = new Guerrero();
            Mago mago1 = new Mago();

            //Creacion aspectos
            Aspecto aspecto1 = new Aspecto("Aspecto1", "Aspecto1Descripcion");
            Aspecto aspecto2 = new Aspecto("Aspecto2", "Aspecto1Descripcion");

            //Creacion de un personaje
            IPersonaje personaje1 = new Personaje("FlechaVerde", arquero1, usuario1.Id);
            Console.WriteLine("NombrePersonaje: " + personaje1.Nombre);
            Console.WriteLine("Aspecto: " + personaje1.Aspecto?.Nombre);
            Console.WriteLine("Nivel: " + personaje1.Nivel.ToString());
            Console.WriteLine("Experiencia: " + personaje1.Experiencia.ToString());

            IPersonaje personaje2 = personaje1.Clonar();
            personaje2.Experiencia = 50;
            personaje2.Aspecto = aspecto2;
            personaje2.Nivel = 2;

            Console.WriteLine("NombrePersonaje: " + personaje2.Nombre);
            Console.WriteLine("Aspecto: " + personaje2.Aspecto?.Nombre);
            Console.WriteLine("Nivel: " + personaje2.Nivel.ToString());
            Console.WriteLine("Experiencia: " + personaje2.Experiencia.ToString());
        }
    }
}
