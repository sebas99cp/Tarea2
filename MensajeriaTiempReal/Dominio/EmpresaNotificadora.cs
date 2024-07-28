using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria.Dominio
{
    public class EmpresaNotificadora
    {
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        //Suscribir a un usuario
        public void SuscribirUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        //Desuscribir a un usuario
        public void DesuscribirUsuario(Usuario usuario)
        {
            Usuarios.Remove(usuario);
        }

        //notificar a todos los usuarios
        public void NotificarUsuarios(string mensaje)
        {
            foreach (var usuario in Usuarios)
            {
                usuario.NotificarDispositivos(mensaje);
            }
        }

    }
}
