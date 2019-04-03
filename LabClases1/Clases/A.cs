using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases


{
    using static System.Console;
    public class A
    {

        public string NombreInstancia { get; set; }



        public A()
        {
            NombreInstancia = "Instancia sin nombre";

        }
        public A(string n)
        {
            NombreInstancia = n;
        }
        public void MostrarNombre()
        {
            WriteLine(NombreInstancia);

        }
        public void M1()
        { WriteLine("El metodo M1 ha sido invocado"); }
        public void M2()
        { WriteLine("El metodo M2 ha sido invocado"); }
        public void M3()
        { WriteLine("El metodo M3 ha sido invocado"); }

    }
}

