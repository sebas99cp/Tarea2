namespace GestionTareas.Dominio.Comandos
{
    public class CompletarCommand : Command
    {
        public Guid Id { get; set; }

        public CompletarCommand(Editor editor, Guid id) : base(editor)
        {
            Id = id;
        }

        public override void Deshacer()
        {
            Editor.Actualizar(Backup!);
        }

        public override void Ejecutar()
        {
            Backup = Editor.EncontrarPorId(Id);
            Editor.Completar(Id);
        }
    }
}
