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
            Console.WriteLine("Se ha iniciado el programa");
            Console.WriteLine("¿Quiere activar la descripción de pasos?   s/n");
            bool paso = false;
            if (Console.ReadLine() == "s")
            {
                paso = true;
                Console.Write("Se ha activado el paso");
                Console.Write(" ");
            }

            Console.WriteLine("¿Con cuantos discos quiere jugar?");
            int discos = int.Parse(Console.ReadLine());
            Console.WriteLine("Se van a crear " + discos + " discos");
            Console.WriteLine("¿Empezar el juego?   s/n");
            if (Console.ReadLine() == "n")
            {
                Environment.Exit(1);
            }

            Pila INI = new Pila(discos, true);
            Pila AUX = new Pila(discos, false);
            Pila FIN = new Pila(discos, false);
            Hanoi hanoi = new Hanoi();

            INI.mostrarC(AUX, FIN);
            Console.ReadKey();







            Console.WriteLine("El numero de movimientos necesarios ha sido: "+hanoi.iterativo(discos, INI, AUX, FIN, paso));

            Console.ReadKey();



        }
    }
}
