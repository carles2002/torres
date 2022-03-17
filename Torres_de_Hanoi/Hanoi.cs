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
            
            if (b.objetos.Count() <= 0)
            {
                
                Disco A = a.pop();

                b.push(A);
            }
            else if (a.objetos.Count() <= 0)
            {
                
                Disco B = b.pop();
                a.push(B);


            }
            else if (a.objetos[a.objetos.Count() - 1].tam > b.objetos[b.objetos.Count() - 1].tam)
            {
                
                Disco A = a.pop();
                b.push(A);
            }
            else if (a.objetos[a.objetos.Count() - 1].tam < b.objetos[b.objetos.Count() - 1].tam)
            {
                
                Disco B = b.pop();
                a.push(B);
            }
            else
            {
                Console.WriteLine("ERROR: No se han podido mover los discos");
            }

        }
        //--------------------------------------------------------
        //AQUÍ SE REALIZA EL ALGORITMO
        //--------------------------------------------------------

        

        public int iterativo(int n, Pila ini, Pila fin, Pila aux, bool paso)
        {
            if (paso == false)
            {
                int m = 0;

                //Si el numero de discos es impar
                if (n % 2 != 0)
                {

                    while (ini.isEmpty() == false || aux.isEmpty() == false)
                    {

                        m++;
                        mover_disco(ini, fin);
                        if (fin.objetos.Count() == n) { return m; };

                        m++;
                        mover_disco(ini, aux);
                        if (fin.objetos.Count() == n) { return m; };

                        m++;
                        mover_disco(aux, fin);
                        if (fin.objetos.Count() == n) { return m; };

                    }
                }

                //Si el numero de discos es par
                if (n % 2 == 0)
                {
                    while (ini.isEmpty() == false || aux.isEmpty() == false)
                    {

                        m++;
                        mover_disco(ini, aux);
                        if (fin.objetos.Count() == n) { return m; };

                        m++;
                        mover_disco(ini, fin);
                        if (fin.objetos.Count() == n) { return m; };

                        m++;
                        mover_disco(aux, fin);
                        if (fin.objetos.Count() == n) { return m; };


                    }
                }

                return m;
            }
            //PASO ACTIVADO
            else
            {

                

                int m = 0;

                //Si el numero de discos es impar
                if (n % 2 != 0)
                {

                    while (ini.isEmpty() == false || aux.isEmpty() == false)
                    {
                        Console.Clear(); ini.mostrarC(aux,fin);
                        Console.ReadKey();
                        m++;
                        mover_disco(ini, fin);
                        if (fin.objetos.Count() == n) { return m; };

                        Console.Clear(); ini.mostrarC(aux, fin);
                        Console.ReadKey();
                        m++;
                        mover_disco(ini, aux);
                        if (fin.objetos.Count() == n) { return m; };

                        Console.Clear(); ini.mostrarC(aux, fin);
                        Console.ReadKey();
                        m++;
                        mover_disco(aux, fin);
                        if (fin.objetos.Count() == n) { return m; };

                    }
                }

                //Si el numero de discos es par
                if (n % 2 == 0)
                {
                    while (ini.isEmpty() == false || aux.isEmpty() == false)
                    {
                        Console.Clear(); ini.mostrarC(aux, fin);
                        Console.ReadKey();
                        m++;
                        mover_disco(ini, aux);
                        if (fin.objetos.Count() == n) { return m; };

                        Console.Clear(); ini.mostrarC(aux, fin);
                        Console.ReadKey();
                        m++;
                        mover_disco(ini, fin);
                        if (fin.objetos.Count() == n) { return m; };

                        Console.Clear(); ini.mostrarC(aux, fin);
                        Console.ReadKey();
                        m++;
                        mover_disco(aux, fin);
                        if (fin.objetos.Count() == n) { return m; };


                    }
                }

                return m;
            }
            
        }

    }
}
