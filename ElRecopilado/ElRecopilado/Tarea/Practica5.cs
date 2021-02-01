using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    class Practica5
    {
        public void GenerarMatriz(int tamaño)
        {
            int ContarFila, ContarColumna;

            Console.Write("INGRESE EL TAMAÑO DE SU MATRIZ CUADRADA: ");
            tamaño = int.Parse(Console.ReadLine());
                
            if (tamaño <= 0)
            {
                Console.WriteLine("INGRESE UN VALOR CORRECTO...");
            }
            else
            {
                int[,] matriz = new int[tamaño,tamaño];
                Random NumeroAleatorio = new Random();
                Console.WriteLine();
                Console.WriteLine("SU MATRIZ ES DE: " + tamaño + "x" + tamaño);
                Console.WriteLine();

                for (ContarFila = 0; ContarFila < tamaño; ContarFila++)
                {
                    for (ContarColumna = 0; ContarColumna < tamaño; ContarColumna++)
                    {
                        matriz[ContarFila, ContarColumna] = NumeroAleatorio.Next(9);
                        Console.Write(" " + matriz[ContarFila, ContarColumna]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                int SumaDiagonalDerecha = 0;
                int SumaDiagonalIzquierda = 0;
                int DiferenciaEntreDiagonales;
                int contador = 0;
                Console.WriteLine("LOS VALORES DE LA DIAGONAL DERECHA SON: ");
                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        if (i == j)
                        {
                            SumaDiagonalDerecha = SumaDiagonalDerecha + matriz[i, j];
                            contador++;
                            Console.Write("EL NUMERO " + contador + " VALE: " + matriz[i, j]);
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine("LA SUMA DE LA DIAGONAL DERECHA ES: " + SumaDiagonalDerecha);
                Console.WriteLine();

                Console.WriteLine("LOS VALORES DE LA DIAGONAL IZQUIERDA SON: ");
                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        if (i + j == tamaño - 1)
                        {
                            SumaDiagonalIzquierda = SumaDiagonalIzquierda + matriz[i, j];
                            contador++;
                            Console.Write("EL NUMERO " + contador + " VALE: " + matriz[i, j]);
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine("LA SUMA DE LA DIAGONAL IZQUIERDA ES: " + SumaDiagonalIzquierda);
                Console.WriteLine();

                DiferenciaEntreDiagonales = SumaDiagonalDerecha - SumaDiagonalIzquierda;
                Console.Write("LA DIFERENCIA ENTE DIAGONALES ES DE: " + Math.Abs(DiferenciaEntreDiagonales));
                Console.ReadLine();
            }
        }
    } 
}
