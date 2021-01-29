using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    class Practica5
    {
        public void generar_matriz(int linea)
        {
            int fila;
            int tamaño_linea, tamaño_fila;
            int SumaDiagonalIzquierda = 0;
            int SumaDiagonalDerecha = 0;

            Console.WriteLine("ingresar un numero entero entre el 2 y 100");
            linea = int.Parse(Console.ReadLine());
            fila = linea;
            if (linea >= 2 && linea <= 100) 
            {
                int[,] matriz = new int[linea, fila];
                Random numero = new Random();
                Console.WriteLine();
                for (tamaño_linea = 0; tamaño_linea < linea; tamaño_linea++) 
                {
                    for (tamaño_fila = 0; tamaño_fila<fila; tamaño_fila++)
                    {
                        matriz[tamaño_linea,tamaño_fila] = numero.Next(9);
                        Console.Write(" "+matriz[tamaño_linea, tamaño_fila]);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < linea; i++)
                {
                    for (int j = 0; j < linea; j++)
                    {
                        if (i == j)
                        {Console.WriteLine();
                            SumaDiagonalIzquierda = SumaDiagonalIzquierda + matriz [i,j]; 
                           Console.WriteLine(""+matriz[i, j]);
                           Console.WriteLine(SumaDiagonalIzquierda);
                        }
                    }
                }

                 for (int i = 0; i < linea; i++)
                {
                    for (int j = 0; j < linea; j++)
                    {
                        if (i + j == linea-1)
                        {Console.WriteLine();
                            SumaDiagonalDerecha = SumaDiagonalDerecha + matriz [i,j]; 
                           Console.WriteLine(""+matriz[i, j]);
                           Console.WriteLine(SumaDiagonalDerecha);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ingresar valores entre el 2 y el 100");
            }



        }
    }
}
