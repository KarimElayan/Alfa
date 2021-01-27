using System;

namespace Practica_5
{
    class MainClass
    {
        static void Main(string[] args)

        {
            string a;
            int x, y;

            Console.WriteLine(".: MATRIZ :.");
            Console.WriteLine("Ingresa un valor del 2 al 100 para crear una matriz.");
            a = Console.ReadLine();
            x = Convert.ToInt32(a);
            y = Convert.ToInt32(a);

            Console.WriteLine();
            Console.WriteLine("La matriz aleatoria es: ");
            int[,] numero = new int[x, y];
            Random aleatorio = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    numero[i, j] = aleatorio.Next(-50, 50);
                    Console.Write("   " + numero[i, j]);

                }

                Console.WriteLine();
            }
            Console.WriteLine("Programador");

            Console.Write("int[,] numero = new int[,]");
            for (int i = 0; i < x; i++)
            {
                Console.Write("{ ");

                for (int j = 0; j < y; j++)
                {

                    numero[i, j] = aleatorio.Next(-50, 50);
                    Console.Write("  " + numero[i, j]);
                }
                Console.Write(" } ");
            }
            Console.Write(";");
        }
    }
}


