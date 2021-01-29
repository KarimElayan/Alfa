using System;

namespace Practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int c = 0;
            int n = 0;
            string linea;

            Console.Write("tamaño de la matriz: ");
            Random rnd = new Random();
            linea = Console.ReadLine();
            n = int.Parse(linea);
            int[,] matris = new int[n + 1, n + 1];
            for (f = 1; f <= n; f++)
            {
                for (c = 1; c <= n; c++)
                {
                    matris[f, c] = rnd.Next(0, 100);
                    Console.SetCursorPosition(c * 4, f + 1);
                    Console.Write(matris[f, c]);

                }
            }
            Console.WriteLine();
        }
        
        
    }
}
