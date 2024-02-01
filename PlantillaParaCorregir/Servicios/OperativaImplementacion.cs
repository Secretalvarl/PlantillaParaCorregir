using PlantillaParaCorregir.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaParaCorregir.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void agregarCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto nuevoCliente = crearNuevoCliente();

            listaAntigua.Add(nuevoCliente);

        }



        public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            Console.WriteLine("Escriba el email de la cuenta a borrar: ");
            string cuentaABorrar = Console.ReadLine();

            ClienteDto clienteABorrar = listaAntigua.Find(n => n.Email == cuentaABorrar);

            if (clienteABorrar != null)
            {
                listaAntigua.Remove(clienteABorrar);
                Console.WriteLine("Cliente borrado");
            }
        }

        public void ordenarPorEdad(List<ClienteDto> listaAntigua)
        {
            for (int i = 0;i < listaAntigua.Count;i++)
            {
                for(int j = 0;j < listaAntigua.Count -1 -i; j++) 
                {
                    if (listaAntigua[j + 1].Edad > listaAntigua[j].Edad)
                    {
                        ClienteDto aux = listaAntigua[j];
                        listaAntigua[j] = listaAntigua[j + 1];
                        listaAntigua[j + 1] = aux;
                    }
                
                }
            }

            
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Escriba el id");
            nuevoCliente.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su nombre");
            nuevoCliente.Nombre = Console.ReadLine();

            Console.WriteLine("Escriba sus apellidos");
            nuevoCliente.Apellidos = Console.ReadLine();

            Console.WriteLine("Escriba la edad");
            nuevoCliente.Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su email");
            nuevoCliente.Email = Console.ReadLine();

            return nuevoCliente;

        }


    }
}
