using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    class Practica5
    {
        public void GenerarMatriz(int fila)
        {
            int columna, ContarFila, ContarColumna;
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
                Console.WriteLine("SU MATRIZ ES DE: " + fila + " x " + fila);
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
            }
        }
    }
}
