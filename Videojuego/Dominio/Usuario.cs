namespace Videojuego.Dominio
{
    public class Usuario
    {
        //constructor
        public Usuario(string nickname)
        {
            Id = Guid.NewGuid();
            Nickname = nickname;
        }
        public Guid Id { get; set; }
        public string Nickname { get; set; }
    }
}
