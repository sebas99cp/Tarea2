﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria.Dominio
{
    public interface IMensajeria
    {
        void Notificar(string mensaje);
    }
}
