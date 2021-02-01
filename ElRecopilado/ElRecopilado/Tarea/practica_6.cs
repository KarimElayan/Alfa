using System;

namespace PRACTICA_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = rnd.Next(2, 9);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.Write("\n");
            }
            // diagonal izquierda
            Console.WriteLine("---Diagonal izquierda es---: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        int[] array = new int[3];
                        array[i] = matriz[i, j];
                        Console.Write(array[i] + " ");
                    }
                }
            }
            //suma de la diagonal izquierda
            int sumaDiagonalIzquierda = 0;
            for (int x = 0; x < 3; x++)

            {
                sumaDiagonalIzquierda = sumaDiagonalIzquierda + matriz[x, x];
                Console.Write("\nsuma diagonal Izquierda es:  " + sumaDiagonalIzquierda);



                Console.ReadKey();

            }

            Console.ReadLine();

            // diagonal derecha
            Console.Write("---diagonal derecha es---: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == (3 - 1) - 1)
                    {
                        int[] array = new int[3];
                        array[i] = matriz[i, j];
                        Console.Write(array[i] + " ");
                    }
                }
            }


            //suma de la diagonal derecha

            int sumaDiagonalDerecha = 0;
            for (int x = 0; x < 3; x++)
            {
                sumaDiagonalDerecha = sumaDiagonalDerecha + matriz[x, 2 - x];
                Console.Write("\nsuma diagonal Derecha es:  " + sumaDiagonalDerecha);


                Console.ReadKey();
            }
            Console.ReadLine();



        }
    }
}
