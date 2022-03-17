using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            Console.WriteLine("Se va a mover un disco");
            if (b.objetos.Count() <= 0)
            {
                Console.Write("Case 1");
                Disco A = a.pop();

                b.push(A);
            }
            else if (a.objetos.Count() <= 0)
            {
                Console.Write("Case 2");
                Disco B = b.pop();
                a.push(B);


            }
            else if (a.objetos[a.objetos.Count() - 1].tam > b.objetos[b.objetos.Count() - 1].tam)
            {
                Console.Write("Case 3");
                Disco A = a.pop();
                b.push(A);
            }
            else if (a.objetos[a.objetos.Count() - 1].tam < b.objetos[b.objetos.Count() - 1].tam)
            {
                Console.Write("Case 4");
                Disco B = b.pop();
                a.push(B);
            }
            else
            {
                Console.WriteLine("ERROR: No se han podido mover los discos");
            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            Console.WriteLine(ini.isEmpty());
            Console.WriteLine(aux.isEmpty());
            Console.WriteLine(fin.isEmpty());
            int m = 0;
            Console.WriteLine("Entrado en el iterador");
            Console.ReadLine();
            //Si el numero de discos es impar
            if (n % 2 != 0)
            {
                Console.WriteLine("IMPAR");
                while( ini.isEmpty() == false || aux.isEmpty() == false)
                {
                    ini.mostrar("INI");
                    aux.mostrar("AUX");
                    fin.mostrar("FIN");
                    m++;
                    mover_disco(ini, fin);
                    ini.mostrar("INI");
                    aux.mostrar("AUX");
                    fin.mostrar("FIN");
                    m++;
                    mover_disco(ini, aux);
                    ini.mostrar("INI");
                    aux.mostrar("AUX");
                    fin.mostrar("FIN");
                    m++;
                    mover_disco(aux, fin);
                    Console.WriteLine("IMP MOV");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("PAR");
            //Si el numero de discos es par
            if (n % 2 == 0)
            {
                while (ini.isEmpty() == false || aux.isEmpty() == false)
                {
                    Console.WriteLine("------------------------");
                    ini.mostrar("INI");
                    aux.mostrar("AUX");
                    fin.mostrar("FIN");
                    m++;
                    mover_disco(ini, aux);
                    ini.mostrar("INI");
                    aux.mostrar("AUX");
                    fin.mostrar("FIN");
                    m++;
                    mover_disco(ini, fin);
                    ini.mostrar("INI");
                    aux.mostrar("AUX");
                    fin.mostrar("FIN");
                    m++;
                    mover_disco(aux, fin);
                    Console.WriteLine("PAR MOV");
                    Console.ReadLine();

                }
            }

            return m;
        }

    }
}
