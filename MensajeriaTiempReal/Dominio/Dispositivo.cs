using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria.Dominio
{
    public class Dispositivo : IMensajeria
    {
        public string Nombre { get; set; }

        public Dispositivo(string nombre)
        {
            Nombre = nombre;
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Dispositivo {Nombre} received message: {mensaje}");
        }
    }
}
