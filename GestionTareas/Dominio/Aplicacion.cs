using GestionTareas.Dominio.Comandos;

namespace GestionTareas.Dominio
{
    public class Aplicacion
    {
        public Editor Editor { get; set; }
        public HistorialComandos Historial { get; set; }

        public Aplicacion()
        {
            Editor = new Editor();
            Historial = new HistorialComandos();
        }

        public void EjecutarComando(Command comando) 
        {
            comando.Ejecutar();
            Historial.Push(comando);
        }

        public void DeshacerComando()
        {
            var comando = Historial.Pop();
            if (comando != null)
            {
                comando.Deshacer();
            }
        }
    }
}
