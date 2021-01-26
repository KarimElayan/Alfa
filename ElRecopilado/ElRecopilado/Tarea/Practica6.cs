using System;

namespace Practicaaa6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rnd.Next(2, 9);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.Write("\n");
            }
            // diagonal izquierda
            Console.WriteLine("Diagonal izquierda es: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        int[] array = new int[5];
                        array[i] = matriz[i, j];
                        Console.Write(array[i] + " ");
                    }
                }
            }
            int sumaDiagonalIz = 0;
            for (int x = 0; x < 5; x++)

            {
                sumaDiagonalIz = sumaDiagonalIz + matriz[x, x];
                Console.Write("\nla suma  de la diagonal Izquierda es:  " + sumaDiagonalIz);



                Console.ReadKey();

            }

            Console.ReadLine();
            Console.Write("Diagonal derecha es: ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == (5 + 1) + 1)
                    {
                        int[] array = new int[5];
                        array[i] = matriz[i, j];
                        Console.Write(array[i] + " ");
                    }
                }
            }
        }
    }
}
