using GestionTareas.Dominio;
using GestionTareas.Dominio.Comandos;

namespace GestionTareas
{
    public class EjecucionGestionTareas
    {
        public static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Empezando ejercicio 4 - Gestion Tareas");
            var aplicacion = new Aplicacion();

            // Crear Tarea 1
            Console.WriteLine("Creando Tarea 1");
            var tarea1 = new Tarea()
            {
                Descripcion = "Barrer",
                Nombre = "Tarea 1"
            };
            var command1 = new CrearCommand(aplicacion.Editor, tarea1);
            aplicacion.EjecutarComando(command1);
            aplicacion.Editor.Describir();

            // Crear Tarea 2
            Console.WriteLine("Creando Tarea 2");
            var tarea2 = new Tarea()
            {
                Descripcion = "Trapear",
                Nombre = "Tarea 2"
            };
            var command2 = new CrearCommand(aplicacion.Editor, tarea2);
            aplicacion.EjecutarComando(command2);
            aplicacion.Editor.Describir();

            //Completar Tarea 1
            Console.WriteLine("Completando Tarea 1");
            var command3 = new CompletarCommand(aplicacion.Editor, tarea1.Id);
            aplicacion.EjecutarComando(command3);
            aplicacion.Editor.Describir();

            //Deshacer Comando 3
            Console.WriteLine("Deshaciendo Completar Tarea 1");
            aplicacion.DeshacerComando();
            aplicacion.Editor.Describir();

            //Actualizar Tarea 2
            Console.WriteLine("Actualizando Tarea 2");
            tarea2.Descripcion = "Trapear actualizado";
            var command4 = new ActualizarCommand(aplicacion.Editor, tarea2);
            aplicacion.EjecutarComando(command4);
            aplicacion.Editor.Describir();

            //Eliminar Tarea 1
            Console.WriteLine("Eliminando Tarea 1");
            var command5 = new EliminarCommand(aplicacion.Editor, tarea1.Id);
            aplicacion.EjecutarComando(command5);
            aplicacion.Editor.Describir();
        }
    }
}
