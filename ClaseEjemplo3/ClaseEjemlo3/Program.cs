using System;


namespace ClaseEjemlo3
{
    class Program
    { 

    
        static void Main(string[] args)
        {
            byte cantidadNumeros, K;
            int NUM;
            string Linea;
            Console.WriteLine("Cuantos Numeros");
            Linea = Console.ReadLine();
            cantidadNumeros = byte.Parse(Linea);

            Random Aleatorio = new Random();


            for (K = 1; K <= cantidadNumeros; K++)
            {
                NUM = Convert.ToInt32(Aleatorio.Next(0,100));
                Console.WriteLine($"El Numero generado es{ NUM}");

                if (((NUM > 0) & (NUM < 100)))
                    Console.WriteLine($"El codigo de {NUM} es {Convert.ToString((char)NUM)}");
                else Console.WriteLine("Numero generado fuera de rango");

            }
        }
    }
}
