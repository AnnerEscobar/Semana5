using System;
using System.Threading;

namespace Ejemplo2Clase
{
    class Program
    {

        public static string Mid(string parametro, int starIndex, int Length)//Funcion Mid que acepta tres parametros 
        {
            string result = parametro.Substring(starIndex, Length);

            return result;

        }

        static void Main(string[] args)
        {
            string Nombre;
            string Caracter;
            int Movimiento = 0;
            int Inicio = 0;
            int tamCadena = 0;
            int Limite = 0;
            Console.Write("Ingrese su nombre: ");//Se le pide al usuario su nombre
            Nombre = Console.ReadLine();//Se lee el nombre y se guarda en la variable Nom
            Console.SetCursorPosition(1,12);//se le asigna un lugar al cursor para la impresion
            Console.Write(Nombre);//IMprime el nombre antes de iniciar la animacion

            tamCadena = Nombre.Length;// se le asigna como valor la cantidad de caracteres que hayan
            Limite = 50;//Con esta variable indicamos la posicion en que quedar en realcion horizontal
            Nombre = Nombre.ToUpper();//Transformar de minusculas a mayusculas

            for(Inicio = Nombre.Length; Inicio >= 1; Inicio--)//controla los caracteres que se van imprimiendo
            {
                Caracter = Mid(Nombre, Inicio-1, 1);//Enviandole parametros a la funcion


                for(Movimiento = tamCadena; Movimiento <= Limite; Movimiento++)//Este ciclo controla las posiciones donde se imprime cada letra
                {
                    Console.SetCursorPosition(Movimiento,12);//Ubica la impresion en un area determinada(vertical)
                    Console.Write(" " + Caracter);//IMprime las letras
                    Thread.Sleep(25);//Controla la velociad del desplazamiento

                }

                Limite --;
                tamCadena --;
            }

            Console.WriteLine();

        }
    }
}
