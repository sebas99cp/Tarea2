using GestionTareas.Dominio.Comandos;

namespace GestionTareas.Dominio
{
    public class HistorialComandos
    {
        public List<Command> Historial { get; set; }

        public HistorialComandos()
        {
            Historial = new List<Command>();
        }

        public void Push(Command command)
        {
            Historial.Add(command);
        }

        public Command? Pop()
        {
            var item = Historial.LastOrDefault();
            if (item != null)
            {
                Historial.RemoveAt(Historial.Count - 1);
            }
            return item;
        }
    }
}
