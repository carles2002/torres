using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {


        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        //Lista con los discos que hay en la pila
        public List<Disco> objetos = new List<Disco>();

        //Tamaño de la pila (discos que hay actualmente en la pila)
        public int Size = 0;

        //Disco que esta arriba de la pila
        public int Top = 0;



        /* TODO: Implementar métodos */

        //Constructor Pila Vacía
        public Pila()
        {

        }

        //Constructor Pila con discos
        public Pila(int discos, int debug)
        {
            this.Size = discos + debug;
            for (int i = 0; i < discos; i++)
            {
                Console.WriteLine($"Se ha creado un disco, num= {i}");

                this.objetos.Add(new Disco(i));
            }
            this.Top = discos;
        }

        //Coloca un disco en la pila
        public void push(Disco d)
        {
            if (Size == objetos.Count())
            {
                Console.WriteLine("ERROR :La pila ya esta llena, se va a detener el programa");
                Console.ReadKey();
                Environment.Exit(1);
            }
            else
            {
                this.objetos.Add(d);
                this.Top = d.tam;

                Console.WriteLine("Se ha introducido un disco");
            }


        }

        //Extrae el disco de la parte de arriba
        public Disco pop()
        {
            Top = objetos[objetos.Count() - 2].tam;
            Disco poped = objetos[objetos.Count() - 1];
            objetos.RemoveAt(objetos.Count() - 1); 
            return poped;
        }

        //Mirar si la lista está vacía
        public bool isEmpty()
        {
            if (this.objetos.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Muestra los elementos de la pila
        public void mostrar()
        {
            Console.WriteLine("Los objetos de la pila son:");
            for (int i = 0; i < this.objetos.Count(); i++)
            {
                Console.WriteLine(objetos[i].tam);
            }
        }

    }
}
