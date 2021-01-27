using System;

namespace practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fila de matriz:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("columna de matriz:");
            int b = int.Parse(Console.ReadLine());

            int[,] bidimencion;
            bidimencion = new int[a, b];

            Random numero = new Random();

            // Llenando de la matriz con numero aleatorios entre 2 y 100
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    bidimencion[i, j] = numero.Next(2, 100);
                }
            }
            Console.WriteLine("Impresion de la matriz");

            // Impresion de la matriz
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(bidimencion[i, j]);
                    if (j + 1 == b) { Console.WriteLine(); } else { Console.Write(" , "); }
                }
            }
            Console.ReadKey(true);
        }
    }
}
