using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaParaCorregir.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuYSeleccion()
        {
            int opcion;

            Console.WriteLine("---------------------------");
            Console.WriteLine("|0. Cerrar menu           |");
            Console.WriteLine("|1. Añadir cliente        |");
            Console.WriteLine("|2. Borrar cliente        |");
            Console.WriteLine("|3. Ver clientes          |");
            Console.WriteLine("|4. Ver clientes ordenados|");
            Console.WriteLine("---------------------------");

            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
