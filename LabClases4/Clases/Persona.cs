using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Dni { get; set; }

        public Persona(string nom, string ap, DateTime fecha, int dni)
        {
            Nombre = nom;
            Apellido = ap;
            FechaNacimiento = fecha;
            Dni = dni;
        }

        ~Persona()
        {
            Console.WriteLine("Se destruyó el objeto");
        }

        public int GetAge()
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;
            DateTime cumpleañosAhora = FechaNacimiento.AddYears(edad);
            if (DateTime.Today.CompareTo(cumpleañosAhora)<0)
                edad--;
            return edad;
        }

        public string GetFullName()
        {
            return Nombre + " " + Apellido;
        }
    }
}
