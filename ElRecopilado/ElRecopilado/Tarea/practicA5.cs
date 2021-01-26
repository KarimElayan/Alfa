using System;

namespace practica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            Random r = new Random();
            Console.WriteLine("la matriz 5x5");
            for (int fi = 0; fi < 5; fi++)
            {
                for (int col = 0; col < 5; col++)
                {
                    matriz[fi, col] = r.Next(-50, 50);
                }
            }

            for (int fi = 0; fi < 5; fi++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(matriz[fi, col] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
            

    }
}
