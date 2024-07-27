using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videojuego.Dominio.Propiedades;
using Videojuego.Dominio.Tipos;

namespace Videojuego.Dominio
{
    public class Personaje : IPersonaje
    {
        public string Nombre { get; set; }
        private TipoPersonaje Clase { get; set; }
        public Aspecto? Aspecto { get; set; }
        public int Nivel { get; set; } = 0;
        public double Experiencia { get; set; } = 0;
        public Guid Usuario { get; set; }
        public Guid Id { get; set; }

        public Personaje(string nombre, TipoPersonaje clase, Guid GuidUsuario)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Clase = clase;
            Usuario = GuidUsuario;
        }

        public IPersonaje Clonar()
        {
            Personaje personaje = new Personaje(this.Nombre, this.Clase, this.Usuario);
            personaje.Aspecto = this.Aspecto;
            personaje.Nivel = this.Nivel;
            personaje.Experiencia = this.Experiencia;

            return personaje;
        }
    }
}
