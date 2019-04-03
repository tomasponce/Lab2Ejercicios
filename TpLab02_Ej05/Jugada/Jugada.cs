using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Jugada
    {


        public int Numero
        { get; set; }

        public bool Adivino
        { get; set; }

        public int Intentos
        { get ; set ; }


        public Jugada(int maxNumero)
        {
            Intentos = 0;
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }
        public bool Comparar (int nro)
        {
         
            if (Numero == nro)
            {
                Adivino= true;


            }
            else
            {
                Adivino = false;
            };
            Intentos = Intentos+1;
            return Adivino;

            
        }

    }
}
