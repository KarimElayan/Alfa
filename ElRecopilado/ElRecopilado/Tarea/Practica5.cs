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
                        matriz[tamaño_linea,tamaño_fila] = numero.Next(-50,50);
                        Console.Write(" "+matriz[tamaño_linea, tamaño_fila]);
                    }
                    Console.WriteLine();
                }
                
            }
            else
            {
                Console.WriteLine("ingresar valores entre el 2 y el 100");
            }



        }
    }
}
