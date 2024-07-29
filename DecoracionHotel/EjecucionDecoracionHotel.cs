using DecoracionHotel.Dominio;

namespace DecoracionHotel
{
    public class EjecucionDecoracionHotel
    {
        public static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Empezando ejercicio 5 - Decoracion Hotel");

            IHabitacionBuilder builder = new HabitacionBuilder(1);
            Director director = new Director(builder);

            IHabitacion habitacion = director.ConstruirHabitacionPersonalizada(1, "Rosas rojas", "Pizza", "Vino caliente", "Tiramisu");
            Console.WriteLine("Habitación Construida:");
            Console.WriteLine(habitacion);
        }
    }
}