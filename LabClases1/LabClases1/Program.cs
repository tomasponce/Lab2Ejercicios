using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A instanciaA = new A();
            B instanciaB = new B();
            instanciaA.MostrarNombre();
            instanciaA.M1();
            instanciaA.M2();
            instanciaA.M3();
            instanciaB.MostrarNombre();
            instanciaB.M1();
            instanciaB.M2();
            instanciaB.M3();
            instanciaB.M4();
            Console.ReadKey();
        }
    }
}
