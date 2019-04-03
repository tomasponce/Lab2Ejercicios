using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1;



namespace Clase3
{
    public class JugadaConAyuda:Jugada
    {
        public JugadaConAyuda(int MaxNumero) : base(MaxNumero) { }
        public bool Comparar(int nro)
        {

            if (Numero == nro)
            {
                Adivino = true;


            }
            else
            {
                if( nro>Numero && (nro-Numero) >= 100)
                {
                    Console.WriteLine("El numero se encuentra muy lejos");

                }
                else 
                 if( nro==Numero+5 || nro==Numero-5)
                {
                    Console.WriteLine("El numero esta a 5 numeros");

                }

                Adivino = false;
                
            };
            Intentos = Intentos + 1;
            return Adivino;


        }




    }
}
