using System;

namespace Practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numero;
            //se dice que tiene 5 filas y 5 columnas
            numero = new int[5, 5];
            Random aleatorio = new Random();
            //valores de la matriz 
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    {
                        numero[fila, columna] = aleatorio.Next(-50, 50);
                    }
                    Console.WriteLine("Ingresa un numero solo del 2 al 100:  ");
                    numero[fila, columna] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            //hacer la matriz en pantalla para usuario
            Console.WriteLine("--------------")
                Console.writeLine("Matriz usuario")
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Console.Write(" " + numero[fila, columna]);
                }
                Console.WriteLine();
            }
            //hacer la matriz en pantalla para programador 
            Console.WriteLine("---------------------");
            Console.WriteLine("Matriz generada");
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Console.Write(numero[fila, columna]);
                }
                Console.WriteLine();
            }
        }
    }
}