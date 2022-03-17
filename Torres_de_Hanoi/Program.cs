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




            


            Console.WriteLine(hanoi.iterativo(discos, INI, AUX, FIN));

            Console.ReadKey();



        }
    }
}
