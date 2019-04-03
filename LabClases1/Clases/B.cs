using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B : A
    {
        public void M4()
        { Console.WriteLine("metodo del hijo convocado"); }
        public B() : base("Instancia de B")
        { }


    }
}