using System;
using System.Threading;

namespace AppCurso1
{

    class Program
    {
        public static void Dibuja(int cantidad)
        {
            int ladoAbajo = 20;
            int ladoIzquierdo = 50;
            int ladoArriba = 2;
            int ladoDerecho = 2;
            int F, C, A;

            for (A = 1; A <= cantidad; A++)
            {
                for (F = ladoDerecho; F <= ladoIzquierdo; F++)
                {
                    Console.SetCursorPosition(F, ladoAbajo); Console.Write("I");
                    Console.SetCursorPosition(F, ladoArriba); Console.Write("J");

                }
                for (C = ladoArriba; C <= ladoAbajo; C++)
                {
                    Console.SetCursorPosition(ladoDerecho, C); Console.Write("K");
                    Console.SetCursorPosition(ladoIzquierdo, C); Console.Write("X");
                }
                ladoArriba++;
                ladoAbajo--;
                ladoDerecho++;
                ladoIzquierdo--;
            }

            Console.WriteLine();
        }




        static void Main(string[] args)
        {

            for (int tan = 1; tan < 7; tan++)//Este for da las instrucciones de cuantas veces tiene que dibujarse el marco
            {
                Dibuja(tan);//llamada a la funcion
                Thread.Sleep(1000);//velocidad a la que se imprimira cada marco


            }


            Console.WriteLine();
        }


    }
}

