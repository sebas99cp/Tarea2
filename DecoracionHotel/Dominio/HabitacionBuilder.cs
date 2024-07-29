using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionHotel.Dominio
{
    public class HabitacionBuilder : IHabitacionBuilder
    {
        private Habitacion _habitacion;

        public HabitacionBuilder(int numero)
        {
            _habitacion = new Habitacion(numero);
        }

        public IHabitacionBuilder AgregarFlores(string tipoFlores)
        {
            _habitacion.Flores = tipoFlores;
            return this;
        }

        public IHabitacionBuilder AgregarCena(string tipoCena)
        {
            _habitacion.Cena = tipoCena;
            return this;
        }

        public IHabitacionBuilder AgregarBebida(string tipoBebida)
        {
            _habitacion.Bebida = tipoBebida;
            return this;
        }

        public IHabitacionBuilder AgregarPostre(string tipoPostre)
        {
            _habitacion.Postre = tipoPostre;
            return this;
        }

        public IHabitacion Build()
        {
            return _habitacion;
        }
    }
}
