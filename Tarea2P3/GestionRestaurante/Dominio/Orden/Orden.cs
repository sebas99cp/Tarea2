using GestionRestaurante.Dominio.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante.Dominio.Orden
{
    public class Orden
    {


        public List<Pedidos> AddPedido(Pedidos oTipoComida, List<Pedidos> lstPedido)
        {
            lstPedido.Add(oTipoComida);
            return lstPedido;
        }

        public string RevisarPedido(List<Pedidos> lstPedido)
        {
            string result = "Orden \n";
            foreach (Pedidos oTipoComida in lstPedido)
            {
                result += "Producto: " + oTipoComida.Nombre + "\n";
                result += "Tipo: " + oTipoComida.Tipo + "\n";
                result += "Estado: " + TipoEstado.InicioOrden.ToString() + "\n";
            }

            return result;
        }
    }
}
