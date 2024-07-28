using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videojuego.Dominio.Propiedades;

namespace Videojuego.Dominio.Tipos
{
    public class Mago : TipoPersonaje
    {
        //propiedades
        public static string NombreClase { get; set; } = "Mago";
        public Habilidad[] habilidades { get; set; }

        //constructor
        public Mago()
        {
            Id = Guid.NewGuid();
            habilidades = new Habilidad[]
            {
                new Habilidad(descripcion: "Lanzar hechizo de fuego", nombre: "Lanzar hechizo de fuego", nivel: 1),
                new Habilidad(descripcion: "Lanzar hechizo de hielo", nombre: "Lanzar hechizo de hielo", nivel: 2),
                new Habilidad(descripcion: "Lanzar hechizo de trueno", nombre: "Lanzar hechizo de trueno", nivel: 3)
            };
        }
    }
}
