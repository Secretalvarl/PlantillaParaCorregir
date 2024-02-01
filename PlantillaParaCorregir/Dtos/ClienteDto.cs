using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaParaCorregir.Dtos
{
    internal class ClienteDto
    {
        int id;
        string nombre;
        string apellidos;
        int edad;
        string email;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }

        public ClienteDto (int id, string nombre, string apellidos, int edad, string email) 
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.email = email;
        }

        public ClienteDto()
        {

        }

        public string ToString()
        {
            string[] dividirApellidos = apellidos.Split(" ");

            string apellido1 = dividirApellidos[0];
            string apellido2 = dividirApellidos[1];

            string nombreAlCompletito = apellido1 + " " + apellido2 + " " + nombre;

            string cliente = id + "\n " + nombreAlCompletito + "\n " + edad + "\n " + email;

            return cliente;
                
        }
    }
}
