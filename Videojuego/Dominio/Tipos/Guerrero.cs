using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videojuego.Dominio.Propiedades;

namespace Videojuego.Dominio.Tipos
{
    public class Guerrero : TipoPersonaje
    {
        //propiedades
        public static string NombreClase { get; set; } = "Guerrero";
        public Habilidad[] habilidades { get; set; }

        //constructor
        public Guerrero()
        {
            Id = Guid.NewGuid();
            habilidades = new Habilidad[]
            {
                new Habilidad("Espada de fuego", "Ataca con una espada que quema al enemigo", 1),
                new Habilidad("Espada de hielo", "Ataca con una espada que congela al enemigo", 2),
                new Habilidad("Espada de trueno", "Ataca con una espada que electrocuta al enemigo", 3)
            };
        }
    }
}
