using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionHotel.Dominio
{
    public interface IHabitacionBuilder
    {
        IHabitacionBuilder AgregarFlores(string tipoFlores);
        IHabitacionBuilder AgregarCena(string tipoCena);
        IHabitacionBuilder AgregarBebida(string tipoBebida);
        IHabitacionBuilder AgregarPostre(string tipoPostre);
        IHabitacion Build();

    }
}
