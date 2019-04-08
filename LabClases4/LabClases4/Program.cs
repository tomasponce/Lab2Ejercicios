using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNac = new DateTime();
            bool band = true;
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su dni");
            string a = Console.ReadLine();
            int dni = int.Parse(a);
            while(band)
            {
                Console.WriteLine("Ingrese su fecha de nacimiento en formato DD/MM/YYYY");
                string fechaIngresada = Console.ReadLine();
                if (DateTime.TryParse(fechaIngresada, out fechaNac))
                {
                    band = false;
                }
                else Console.WriteLine("Fecha incorrecta");
            }

            Persona pers = new Persona(nombre, apellido, fechaNac, dni);
            Console.WriteLine(pers.GetAge());
            Console.WriteLine(pers.GetFullName());
            Console.ReadKey();
        }
    }
}
