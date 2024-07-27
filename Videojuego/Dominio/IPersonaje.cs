using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videojuego.Dominio.Propiedades;
using Videojuego.Dominio.Tipos;

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
