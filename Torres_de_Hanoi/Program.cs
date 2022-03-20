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
            //Pedir ajustes del juego 
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

            //Preguntar en caso de haber muchos discos
            if (discos >= 13)
            {
                Console.WriteLine("ATENCIÓN: La cantidad de discos es muy grande y podría provocar tiempos de carga muy largos, ¿desea continuar? s/n");
                string res = Console.ReadLine();
                if (res == "n")
                {
                    Environment.Exit(1);
                }
            };


            Console.WriteLine("Se van a crear " + discos + " discos");
            Console.WriteLine("¿Empezar el juego?   s/n");
            if (Console.ReadLine() == "n")
            {
                Environment.Exit(1);
            }

            //Crear objetos 
            Pila INI = new Pila(discos, true);
            Pila AUX = new Pila(discos, false);
            Pila FIN = new Pila(discos, false);
            Hanoi hanoi = new Hanoi();









            //Inicicar resolucion y mostrar por pantalla los movimientos
            Console.WriteLine("El numero de movimientos necesarios ha sido: " + hanoi.iterativo(discos, INI, AUX, FIN, paso));
            Console.ReadKey();



        }
    }
}
