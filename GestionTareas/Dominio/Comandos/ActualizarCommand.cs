namespace GestionTareas.Dominio.Comandos
{
    public class ActualizarCommand : Command
    {
        public Tarea Tarea { get; set; }

        public ActualizarCommand(Editor editor, Tarea tarea) : base(editor)
        {
            Tarea = tarea;
        }
        public override void Deshacer()
        {
            Editor.Actualizar(Backup!);
        }

        public override void Ejecutar()
        {
            Backup = Editor.EncontrarPorId(Tarea.Id);
            Editor.Actualizar(Tarea);
        }
    }
}
