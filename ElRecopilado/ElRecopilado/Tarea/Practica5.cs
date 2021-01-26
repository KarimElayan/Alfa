using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    class Practica5
    {
        public void GenerarMatriz(int fila)
        {
            int columna, ContarFila, ContarColumna, longitud;
            Console.Write("INGRESE EL TAMAÑO DE SU MATRIZ CUADRADA: ");
            fila = int.Parse(Console.ReadLine());
                columna = fila;
            if (fila <= 0)
            {
                Console.WriteLine("INGRESE UN VALOR CORRECTO...");
            }
            else
            {
                int[,] matriz = new int[fila, columna];
                Random NumeroAleatorio = new Random();
                Console.WriteLine();
                Console.WriteLine("SU MATRIZ ES DE: " + fila + "x" + fila);
                Console.WriteLine();

                for (ContarFila = 0; ContarFila < fila; ContarFila++)
                {
                    for (ContarColumna = 0; ContarColumna < columna; ContarColumna++)
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
                int contador=0;

                Console.WriteLine("LOS VALORES DE LA DIAGONAL DERECHA SON: ");
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
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
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        if (i + j == fila-1)
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
