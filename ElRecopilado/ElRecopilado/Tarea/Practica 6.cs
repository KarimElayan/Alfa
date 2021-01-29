using System;

namespace Practica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int c = 0;
            int n = 0;
            int sum1 = 0;
            int sum2 = 0;
            int valor = sum1 - sum2;
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
            sum1 = 0;
            for (f = 1; f <= n; f++)
            {
                sum1 = sum1 + matris[f, f];
            }
            sum2 = 0;
            c = n;
            for (f = 1; f <= n; f++)
            {
                sum2 = sum2 + matris[f, c];
                c = c - 1;
            }
            valor  = sum1 - sum2;
            Console.WriteLine();
            Console.WriteLine("suma disginal uno es: " + sum1);
            Console.WriteLine("suma disginal uno es: " + sum2);
            Console.WriteLine("valor absoluto: " + valor);
            Console.WriteLine();
        }
    }
}
