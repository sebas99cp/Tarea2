using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionHotel.Dominio
{
    public class Habitacion : IHabitacion
    {
        public int Numero { get;  set; }
        public string? Flores { get;  set; }
        public string? Cena { get;  set; }
        public string? Bebida { get;  set; }
        public string? Postre { get;  set; }

        public Habitacion(int numero)
        {
            Numero = numero;
            Flores = null;
            Cena = null;
            Bebida = null;
            Postre = null;
        }

        public void ActualizarDecoracion(string flores, string cena, string bebida, string postre)
        {
            Flores = flores;
            Cena = cena;
            Bebida = bebida;
            Postre = postre;
        }

        public string Descripcion()
        {
            return $"Habitación {Numero}\n" +
                   $"Flores: {Flores}\n" +
                   $"Cena: {Cena}\n" +
                   $"Bebida: {Bebida}\n" +
                   $"Postre: {Postre}";
        }

        public decimal Costo()
        {
            decimal costo = 0;

            if (Flores != null) costo += 40000; 
            if (Cena != null) costo += 12000; 
            if (Bebida != null) costo += 50000; 
            if (Postre != null) costo += 30000; 

            return costo;
        }

        public override string ToString()
        {
            return Descripcion() + $"\nCosto Total: ${Costo()}";
        }

    }
}
