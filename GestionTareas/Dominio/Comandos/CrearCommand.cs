namespace GestionTareas.Dominio.Comandos
{
    public class CrearCommand : Command
    {
        public Tarea Tarea { get; set; }

        public CrearCommand(Editor editor, Tarea tarea) : base(editor)
        {
            Tarea = tarea;
        }

        public override void Deshacer()
        {
            Editor.Eliminar(Backup!.Id);
        }

        public override void Ejecutar()
        {
            Tarea.Id = Guid.NewGuid();
            Tarea.FechaCreacion = DateTime.UtcNow;
            var tareaNueva = Editor.Crear(Tarea);
            Backup = tareaNueva;
        }
    }
}
