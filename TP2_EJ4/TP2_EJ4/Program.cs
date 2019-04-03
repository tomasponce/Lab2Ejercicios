using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;


namespace TP2_EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su dni");
            string a = Console.ReadLine();
            int dni = int.Parse(a);
            Console.WriteLine("Ingrese su edad");
            string b = Console.ReadLine();
            int edad = int.Parse(b);




            Persona persona = new Persona(nombre,apellido,edad,dni);
            persona.GetFullName();
            persona.GetAge();



        }
    }
}
