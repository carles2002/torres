using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Torres_de_Hanoi
{
    class Disco
    {
        public int tam;

        public Disco(int tamano)
        {
            this.tam = tamano;
            Console.WriteLine($"Se ha creado el disco con el tamaño {this.tam}");
        }

    }

}


