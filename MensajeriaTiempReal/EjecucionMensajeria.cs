using Mensajeria.Dominio;

namespace Mensajeria
{
    public class EjecucionMensajeria
    {
        public static void Main()
        {
            Console.WriteLine("Empezando ejercicio 2 - Mensajería");

            EmpresaNotificadora empresaNotificadora = new EmpresaNotificadora();

            //creación de usuario 1
            var usuario1 = new Usuario("Juan");
            var dispositivo1 = new Dispositivo("Dispositivo1");
            var dispositivo2 = new Dispositivo("Dispositivo2");
            var dispositivo3 = new Dispositivo("Dispositivo3");

            //Adición y eliminaciion de dispositivos en tiempo de "Ejecución"
            usuario1.AddDispositivo(dispositivo1);
            usuario1.AddDispositivo(dispositivo2);
            usuario1.AddDispositivo(dispositivo3);
            usuario1.RemoveDevice(dispositivo3);

            //creación de usuario 2
            var usuario2 = new Usuario("Pedro");
            var dispositivoUsu2 = new Dispositivo("Dispositivo1");

            //Adición y eliminaciion de dispositivos en tiempo de "Ejecución"
            usuario2.AddDispositivo(dispositivoUsu2);

            //Suscripción de usuarios
            empresaNotificadora.SuscribirUsuario(usuario1); //2 dispositivos
            empresaNotificadora.SuscribirUsuario(usuario2); //1 dispositivo

            //Total de mensajes esperados: 3
            empresaNotificadora.NotificarUsuarios("Hola a todos");
        }
    }
}
