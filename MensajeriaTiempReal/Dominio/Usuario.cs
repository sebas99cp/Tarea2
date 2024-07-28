using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajeria.Dominio;

namespace Mensajeria.Dominio
{
    public class Usuario
    {
        public string Nombre { get; set; }
        private List<IMensajeria> Dispositivos = new List<IMensajeria>();

        //constructor
        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public void AddDispositivo(IMensajeria dispositivo)
        {
            Dispositivos.Add(dispositivo);
        }

        public void RemoveDevice(IMensajeria dispositivo)
        {
            Dispositivos.Remove(dispositivo);
        }

        public void NotificarDispositivos(string mensaje)
        {
            foreach (var dispositivo in Dispositivos)
            {
                dispositivo.Notificar(mensaje);
            }
        }
    }
}
