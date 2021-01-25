using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    class Practica5
    {
        public void Practica5Imprimir()
        {
            int numero;
            int[,] recibido;
           // DesarrolloDeMatriz MATRIZ = new DesarrolloDeMatriz();

            Console.WriteLine("Coloca un numero entero (2-100): ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 1 && numero < 101)
            {
                recibido = DesarrolloDeMatriz(numero);
                Console.WriteLine("====FORMATO PARA USUARIO====");
                for (int x = 0; x < numero; x++)
                {
                    for (int y = 0; y < numero; y++)
                    {
                        Console.Write(recibido[x, y] + ((y == (numero - 1)) ? " " : ","));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("====FORMATO PARA PROGRAMADOR====");
                Console.Write("int[,] matrizGenerada = new int[,]{");
                for (int x = 0; x < numero; x++)
                {
                    Console.Write("{");
                    int y;
                    for (y = 0; y < numero; y++)
                    {
                        Console.Write(recibido[x, y] + ((y == (numero - 1)) ? "" : ","));
                    }
                    Console.Write((x == (numero - 1)) ? "}" : "},");

                }
                Console.Write("};");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Numero fuera de rango");
            }

        }
        public int[,] DesarrolloDeMatriz(int numero2)
        {
            int[,] matriz = new int[numero2, numero2];
            Random aleatorio = new Random();
            for (int x = 0; x < numero2; x++)
            {
                for (int y = 0; y < numero2; y++)
                {
                    matriz[x, y] = aleatorio.Next(-50, 50);

                }

            }
            return matriz;
        }

    }
}
