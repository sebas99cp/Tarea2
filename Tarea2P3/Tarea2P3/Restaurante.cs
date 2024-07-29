using GestionRestaurante;
using GestionRestaurante.Dominio.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tarea2P3
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionOrden oGestionOrden = new GestionOrden();
            List<string> lstResult = new List<string>();
            List<Pedidos> lstPedido = new List<Pedidos>();
            List<Productos> lstProductos = new List<Productos>();
            string Result = string.Empty;

            Console.WriteLine("Bienvenido Seleccione los productos que desea agregar a su orden");
            Console.WriteLine("1. Comida");
            Console.WriteLine("2. Bebida");
            Console.WriteLine("3. Postre");


            int opcion = int.Parse(Console.ReadLine());

            lstResult = oGestionOrden.Gestion(opcion, lstProductos, lstPedido);


            Console.WriteLine("Seleccione el producto que desea agregar");

            for (int i = 0; i < lstResult.Count; i++)
            {
                Console.WriteLine(lstResult[i]);
            }

            opcion = int.Parse(Console.ReadLine());

            oGestionOrden.AgregarProducto(opcion, lstPedido);

            bool ctnu = false;

            while (!ctnu)
            {
                Console.WriteLine("Seleccione la opción que desea");

                Console.WriteLine("1. Comida");
                Console.WriteLine("2. Bebida");
                Console.WriteLine("3. Postre");
                Console.WriteLine("4. Salir");
                Console.WriteLine("5. Ver Orden");

                opcion = int.Parse(Console.ReadLine());

                if (opcion != 4)
                {
                    lstResult = oGestionOrden.Gestion(opcion, lstProductos, lstPedido);


                    for (int i = 0; i < lstResult.Count; i++)
                    {
                        Console.WriteLine(lstResult[i]);
                    }

                    opcion = int.Parse(Console.ReadLine());

                    if (opcion != 4)
                    {
                        oGestionOrden.AgregarProducto(opcion, lstPedido);
                    }
                    else 
                    {
                        ctnu = true;
                    }
                }
                
            }
        }
    }
}
