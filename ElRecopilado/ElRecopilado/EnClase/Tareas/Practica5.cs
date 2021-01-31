using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EnClase.Tareas
{
    class Practica5
    {
        public void HacerMagia()
        {
            Console.WriteLine("Generador de matriz cuadrada de 4x4");
            GenerarMatriz(4);
        }

        public string[,] GenerarMatriz(int size)
        {
            string[,] matriz = new string[size, size];

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    matriz[x, y] = x.ToString();//random number
                }
            }            
            return matriz;
        }
    }
}
