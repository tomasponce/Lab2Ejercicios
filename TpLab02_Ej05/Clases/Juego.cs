using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1;
using Clase2;
using Clase3;



namespace Clase2
{
    public class Juego
    {
       
        private int Record
        { get; set; }

        public void ComenzarJuego()
        {
            bool continuar;
            Record = 100000;
            do
            {
                bool comparacion;
              
                    int nro = PreguntarMaximo();

                // Jugada jugada = new Jugada(nro);
                JugadaConAyuda jugada = new JugadaConAyuda(nro);
                do
                {
                    int intento = PreguntarNumero();
                    comparacion = jugada.Comparar(intento);
                } while (comparacion == false);
                CompararRecord(jugada.Intentos);
                 continuar = Continuar();
            } while (continuar == true);



        }
      
        private void CompararRecord (int intentos)
        {
            if( intentos < Record)
            {
                
                Record = intentos;
                Console.WriteLine("Se logro un nuevo record de " + Record);


            }
            else
            {
                Console.WriteLine("No se logro ningun record nuevo ,Record actual: " + Record);


            }

        }
        private bool Continuar()
        {
            bool respuesta;
            Console.WriteLine("Desea jugar otra partida?, Ingrese Si o ingrese No");

            string rta = Console.ReadLine();
            
            if (rta=="si")
            {
                respuesta = true;

            }
            else 
       
            {
                respuesta = false;
            }
      
            return respuesta;
        }
        private int PreguntarMaximo()
        {
                 Console.WriteLine("Ingrese el numero maximo para adivinar");
                string a = Console.ReadLine();

                int nro = int.Parse(a);

            return nro;

        }
        private int PreguntarNumero()
        {
            Console.WriteLine(" Ingrese el numero que crea que sera el correcto");
            string a = Console.ReadLine();
            int nro = int.Parse(a);
            return nro;


         

        }





    }
}
