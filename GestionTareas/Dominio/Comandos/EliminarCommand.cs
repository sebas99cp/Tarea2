namespace GestionTareas.Dominio.Comandos
{
    public class EliminarCommand : Command
    {
        public Guid Id { get; set; }

        public EliminarCommand(Editor editor, Guid id) : base(editor)
        {
            Id = id;
        }

        public override void Deshacer()
        {
            Editor.Crear(Backup!);
        }

        public override void Ejecutar()
        {
            Backup = Editor.EncontrarPorId(Id);
            Editor.Eliminar(Id);
        }
    }
}
