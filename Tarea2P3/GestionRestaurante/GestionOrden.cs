using GestionRestaurante.Dominio.Orden;
using GestionRestaurante.Dominio.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante
{
    public class GestionOrden
    {
        
        List<Productos> lstroductos = new List<Productos>();
        Productos oProductos = new Productos();
        Orden oOrden = new Orden();
        public List<Pedidos> AddPedido(Pedidos oPedidos, List<Pedidos> lstPedido)
        {
            string Result = string.Empty;

            
            lstPedido = oOrden.AddPedido(oPedidos, lstPedido);

            return lstPedido;
        }

        public string MostrarPedido(List<Productos> lstPedido)
        {
            string result = "Orden \n";
            foreach (Productos oProductos in lstPedido)
            {
                //result += "Producto: " + oTipoComida.Nombre + "\n";
                //result += "Cantidad: " + oTipoComida.Cantidad + "\n";
            }

            return result;
        }

        public List<Productos>  ValidarProductos(Productos otipo)
        {
            List<Productos> lstProducto = new List<Productos>();

            if (otipo.Nombre == "Comida")
            {
                Productos oProductos = new Productos();

                oProductos.Nombre = "Salmon";
                oProductos.Tipo = "Comida";
                lstProducto.Add(oProductos);

                oProductos = new Productos();
                oProductos.Nombre = "Pasta";
                oProductos.Tipo = "Comida";
                lstProducto.Add(oProductos);

                oProductos = new Productos();
                oProductos.Nombre = "Steak";
                oProductos.Tipo = "Comida";
                lstProducto.Add(oProductos);
            }
            else if (otipo.Nombre == "Bebida")
            {
                Productos oProductos = new Productos();

                oProductos.Nombre = "Gaseosa";
                oProductos.Tipo = "Bebida";
                lstProducto.Add(oProductos);
                
                oProductos = new Productos();
                oProductos.Nombre = "Vino";
                oProductos.Tipo = "Bebida";
                lstProducto.Add(oProductos);

                oProductos = new Productos();
                oProductos.Nombre = "Cerveza";
                oProductos.Tipo = "Bebida";
                lstProducto.Add(oProductos);
            }
            else if (otipo.Nombre == "Postre")
            {
                Productos oProductos = new Productos();

                oProductos.Nombre = "Arequipe";
                oProductos.Tipo = "Postre";
                lstProducto.Add(oProductos);

                oProductos = new Productos();
                oProductos.Nombre = "Waffle";
                oProductos.Tipo = "Postre";
                lstProducto.Add(oProductos);

                oProductos = new Productos();
                oProductos.Nombre = "Helado";
                oProductos.Tipo = "Postre";
                lstProducto.Add(oProductos);
            }


            return lstProducto;
        }

        public List<string> Gestion(int opcion, List<Productos> lstProductos, List<Pedidos> lstPedido)
        {
            List<string> Result = new List<string>();
            Productos oProductos = new Productos();

            switch (opcion)
            {
                case 1:
                    oProductos.Nombre = "Comida";
                    lstroductos = ValidarProductos(oProductos);
                    for (int i = 0; i < lstroductos.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + lstroductos[i].Nombre);
                    }
                    
                    break;
                case 2:
                    oProductos.Nombre = "Bebida";
                    lstroductos = ValidarProductos(oProductos);
                    for (int i = 0; i < lstroductos.Count; i++)
                    {
                        Result.Add(i + 1 + ". " + lstroductos[i].Nombre);
                    }
                    
                    break;
                case 3:
                    oProductos.Nombre = "Postre";
                    lstroductos = ValidarProductos(oProductos);
                    for (int i = 0; i < lstroductos.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + lstroductos[i].Nombre);
                    }
                    break;

                case 4:
                    
                    break;

                case 5:
                    string result = oOrden.RevisarPedido(lstPedido);

                    Result.Add(result);

                    break;

            }


            return Result;
        }
        public List<Pedidos> AgregarProducto(int opcion, List<Pedidos> lstPedido)
        {
            string result = string.Empty;

            for (int i = 0; i < lstroductos.Count; i++)
            {
                if (opcion == i + 1)
                {
                    Pedidos oPedidos = new Pedidos();

                    oPedidos.Nombre = lstroductos[i].Nombre;
                    oPedidos.Tipo = lstroductos[i].Tipo;
                    lstPedido = AddPedido(oPedidos, lstPedido);
                }
            }

            return lstPedido;
        }
    }
}
