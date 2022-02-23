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
            if (b.objetos.Count()<= 0)
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
            else if (a.objetos[a.objetos.Count() - 1].tam < b.objetos[b.objetos.Count() - 1].tam)
            {
                Console.Write("Case 3");
                Disco A = a.pop();
                b.push(A);
            }
            else if (a.objetos[a.objetos.Count() - 1].tam > b.objetos[b.objetos.Count() - 1].tam)
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
            return 0;
        }

    }
}
