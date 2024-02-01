using PlantillaParaCorregir.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaParaCorregir.Servicios
{
    internal interface OperativaInterfaz
    {
        public void agregarCliente(List<ClienteDto> listaAntigua);

        public void borrarCliente(List<ClienteDto> listaAntigua);

        public void ordenarPorEdad(List<ClienteDto> listaAntigua);

    }
}
