namespace GestionTareas.Dominio.Comandos
{
    public abstract class Command
    {
        public Editor Editor { get; set; }
        public Tarea? Backup { get; set; }

        public Command(Editor editor) 
        {
            Editor = editor;
        }

        public abstract void Ejecutar();
        public abstract void Deshacer();
    }
}
