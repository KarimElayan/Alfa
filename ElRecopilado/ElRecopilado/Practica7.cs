using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado
{
        class matriz
        {
            private int[,] mat;

            public void Cargar()
            {
                mat = new int[3, 3];
                Random aleatorio = new Random();
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        mat[f, c] = aleatorio.Next(0, 2);

                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write(mat[f, c] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                matriz ma = new matriz();
                ma.Cargar();
                ma.Imprimir();
            }



        }
}

