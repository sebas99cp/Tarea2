using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionHotel.Dominio
{
    public interface IHabitacion 
    {
        string Descripcion();
        decimal Costo();
    }
}
