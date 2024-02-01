using PlantillaParaCorregir.Dtos;
using PlantillaParaCorregir.Servicios;

namespace PlantillaParaCorregir.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            MenuInterfaz alpha = new MenuImplementacion();
            OperativaInterfaz omega = new OperativaImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = alpha.menuYSeleccion();
                switch(opcionSeleccionada) 
                { 
                    case 0:
                        Console.WriteLine("Menu cerrado");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Añadir nuevo mcliente");
                        omega.agregarCliente(listaClientes);
                        break; 
                    case 2:
                        omega.borrarCliente(listaClientes);
                        break;
                    case 3:
                        foreach(ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine("listado de usuarios:" + cliente.ToString());
                        }
                        break; 
                    case 4:
                        omega.ordenarPorEdad(listaClientes);
                        foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine("listado de usuarios ordenados :" + cliente.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no es valida");
                        break;
                }
            }
        }
    }
}