using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Keep the console window open in debug mode.
            //  Console.WriteLine("Press any key to exit.");
            // Console.ReadKey();

            Console.WriteLine("Pulse una tecla para iniciar el programa");
           // Console.ReadKey();

           
            Pila Inicio= new Pila(3);
           
            Inicio.mostrar();

            Pila Aux = new Pila();
            Aux.mostrar();

            Hanoi Hanoi = new Hanoi();
            Hanoi.mover_disco(Inicio, Aux);
            Aux.mostrar();

            Console.ReadKey();

             
            
        }
    }
}
