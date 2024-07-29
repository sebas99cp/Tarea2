using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionHotel.Dominio
{
    internal class Director
    {
        private IHabitacionBuilder _builder;

        public Director(IHabitacionBuilder builder)
        {
            _builder = builder;
        }

        public IHabitacion ConstruirHabitacionPersonalizada(int numero, string flores, string cena, string bebida, string postre)
        {
            return _builder
                .AgregarFlores(flores)
                .AgregarCena(cena)
                .AgregarBebida(bebida)
                .AgregarPostre(postre)
                .Build();
        }

        public IHabitacion ModificarHabitacion(IHabitacion habitacion, string flores, string cena, string bebida, string postre)
        {
            if (habitacion is Habitacion hab)
            {
                hab.ActualizarDecoracion(flores, cena, bebida, postre);
            }
            return habitacion;
        }
    }
}
