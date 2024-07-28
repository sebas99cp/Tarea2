namespace GestionTareas.Dominio
{
    public class Editor
    {
        public List<Tarea> Tareas { get; set; }
        public Editor()
        {
            Tareas = new List<Tarea>();
        }

        public Tarea Crear(Tarea item)
        {
            Tareas.Add(item);
            return item;
        }

        public void Eliminar(Guid id)
        {
            var tarea = Tareas.FirstOrDefault(x => x.Id == id);
            if (tarea != null)
            {
                Tareas.Remove(tarea);
            }
        }

        public void Actualizar(Tarea item)
        {
            var tarea = Tareas.FirstOrDefault(x => x.Id == item.Id);
            if (tarea != null)
            {
                tarea.FechaActualizacion = DateTime.UtcNow;
                var index = Tareas.IndexOf(tarea);
                Tareas[index] = item;
            }
        }

        public void Completar(Guid id)
        {
            var tarea = Tareas.FirstOrDefault(x => x.Id == id);
            if (tarea != null)
            {
                tarea.FechaActualizacion = DateTime.UtcNow;
                tarea.Estado = "Finalizada";
            }
        }

        public Tarea? EncontrarPorId(Guid id)
        {
            var tarea = Tareas.FirstOrDefault(x => x.Id == id);
            if (tarea != null)
            {
                return Mapeo(tarea);
            }
            return tarea;
        }

        private Tarea Mapeo(Tarea tarea)
        {
            return new Tarea
            {
                FechaActualizacion = tarea.FechaActualizacion,
                Descripcion = tarea.Descripcion,
                Estado = tarea.Estado,
                FechaCreacion = tarea.FechaCreacion,
                Id = tarea.Id,
                Nombre = tarea.Nombre,
            };
        }

        public void Describir()
        {
            Console.WriteLine("--- Describiendo tareas almacenadas ---");
            for(var index = 0; index < Tareas.Count;  index++)
            {
                Console.WriteLine("* Item: " + index);
                Console.WriteLine("\tId: " + Tareas[index].Id);
                Console.WriteLine("\tEstado: " + Tareas[index].Estado);
                Console.WriteLine("\tNombre: " + Tareas[index].Nombre);
                Console.WriteLine("\tDescripcion: " + Tareas[index].Descripcion);
                Console.WriteLine("\tFecha Creacion: " + Tareas[index].FechaCreacion);
                Console.WriteLine("\tFecha Actualizacion: " + Tareas[index].FechaActualizacion);
            }
            Console.WriteLine();
        }
    }
}
