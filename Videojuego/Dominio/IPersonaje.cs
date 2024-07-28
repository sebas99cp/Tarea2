using Videojuego.Dominio.Propiedades;

namespace Videojuego.Dominio
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        Aspecto Aspecto { get; set; }
        int Nivel { get; set; }
        double Experiencia { get; set; }
        Guid Usuario { get; set; }
        Guid Id { get; set; }

        IPersonaje Clonar();
    }
}
