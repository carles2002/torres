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
            int discos = 4;

            Pila INI = new Pila(discos, true);
            Pila AUX = new Pila(discos, false);
            Pila FIN = new Pila(discos, false);
            Hanoi hanoi = new Hanoi();




            


            Console.WriteLine(hanoi.iterativo(discos, INI, AUX, FIN));

            Console.ReadKey();



        }
    }
}
