using System;

namespace Clases

{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Dni { get; set; }
        public Persona(string nombre , string apellido, int edad, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;

        }
        ~Persona()
        {
            Console.WriteLine("Se destruira el objeto");
        }

        public void GetFullName()
        {
            Console.WriteLine(Nombre + Apellido);

        }
        public void GetAge()
        {
            Console.WriteLine(Edad);

        }
    }
}

