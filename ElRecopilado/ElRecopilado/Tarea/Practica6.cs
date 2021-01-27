using System;

namespace Practica_6
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string a;
            int x, z, sum, suma, r;
            sum = 0;
            suma = 0;
            Console.WriteLine(".: MATRIZ :.");

            do
            {
                Console.Write("Ingresa un valor del 2 al 100 para crear una matriz: ");
                a = Console.ReadLine();
                x = Convert.ToInt32(a);
                z = x - 1;
            } while (x < 2 || x > 100);
            Console.WriteLine("La matriz aleatoria es: ");
            int[,] numero = new int[x, x];
            Random aleatorio = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    numero[i, j] = aleatorio.Next(-50, 50);
                    Console.Write("   " + numero[i, j]);

                }
                Console.WriteLine();

            }

            Console.WriteLine("Diagonal IZQUIERDA...");
            for (int i = 0; i < x; i++)
            {
                Console.Write("  " + numero[i, i]);
                sum = sum + numero[i, i];
            }
            Console.WriteLine();
            Console.Write("La suma de la diagonal IZQUIERDA es: " + sum);
            Console.WriteLine();

            Console.WriteLine("Diagonal DERECHA...");
            for (int i = 0; i < x; i++)
            {
                Console.Write("  " + numero[i, z - i]);
                suma = suma + numero[i, z - i];
            }
            Console.WriteLine();
            Console.WriteLine("La suma de la diagonal izquierda es: " + suma);
            r = (sum) - (suma);
            Console.Write("La diferencia entre las diagonales es :" + r);

        }
    }
}


