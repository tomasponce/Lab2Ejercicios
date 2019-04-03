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
            A instancia1 = new A();
            B instancia2 = new B();
            instancia1.MostrarNombre();
            instancia1.M1();
            instancia1.M2();
            instancia1.M3();
            instancia2.MostrarNombre();
            instancia2.M1();
            instancia2.M2();
            instancia2.M3();
            instancia2.M4();
        }
    }
}

