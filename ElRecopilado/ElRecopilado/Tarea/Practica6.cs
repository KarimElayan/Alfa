using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    class Practica6
    {
        public void Practica6Imprimir()
        {
            int[,] recibido2;
            int RestaDeDiagonales;
            int SumaDiagonal1;
            int SumaDiagonal2;

            Console.WriteLine();
            Console.WriteLine("Coloca un numero entero (2-100): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Practica5 MatrizGenerada = new Practica5();
           // Diagonal1 Diagonal = new Diagonal1();
           // Diagonal2 Diagonal2 = new Diagonal2();

            if (numero > 1 && numero < 101)
            {
                Console.WriteLine("====MATRIZ DADA====");
                recibido2 = MatrizGenerada.DesarrolloDeMatriz(numero);
                for (int x = 0; x < numero; x++)
                {
                    for (int y = 0; y < numero; y++)
                    {
                        Console.Write(recibido2[x, y] + ((y == (numero - 1)) ? " " : ","));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("====IMPRESION DE DIAGONAL IZQUIERDA====");
                DiagonalIzquierdaImprimir(recibido2, numero);
                Console.WriteLine("==SUMA==");
                SumaDiagonal1 = DiagonalIzquierdaSuma(recibido2, numero);
                Console.WriteLine("La suma es: " + SumaDiagonal1);
                Console.WriteLine();
                Console.WriteLine("====IMPRESION DE DIAGONA DERECHA====");
                DiagonalDerechaImprimir(recibido2, numero);
                Console.WriteLine("==SUMA==");
                SumaDiagonal2=DiagonalDerechaSuma(recibido2, numero);
                Console.WriteLine("La suma es: " + SumaDiagonal2);
                Console.WriteLine();
                Console.WriteLine("=====DIFEREMCIA ABSOLUTA DE LAS DOS DIAGONALES=====");
                RestaDeDiagonales = SumaDiagonal1 - SumaDiagonal2;
                Console.WriteLine("La diferencia entre las dos diagonales es: " + Math.Abs(RestaDeDiagonales));
            }
            else
            {
                Console.WriteLine("Numero fuera de rango");
            }

        }
        //DIAGONAL IZQUIERDA
        public void DiagonalIzquierdaImprimir(int[,] Matriz, int valor)
        {
            int[,] DiagonalImprimir = Matriz;

            for (int x = 0; x < valor; x++)
            {
                for (int y = 0; y < valor; y++)
                {
                    if (x == y)
                    {
                        Console.Write(DiagonalImprimir[x, y]);
                        break;
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
        public int DiagonalIzquierdaSuma(int[,] Matriz, int valor)
        {
            int[,] DiagonalSuma = Matriz;
            int suma = 0;

            for (int x = 0; x < valor; x++)
            {
                for (int y = 0; y < valor; y++)
                {
                    if (x == y)
                    {
                        suma = suma + DiagonalSuma[x, y];
                        break;
                    }
                }
            }
            return suma;
        }
        //DIAGONAL DERECHA
        public void DiagonalDerechaImprimir(int[,] Matriz, int valor)
        {
            int[,] DiagonalImprimir = Matriz;
            int TerminarBucle;
            valor = valor - 1;
            TerminarBucle = valor;

            for (int x = 0; x <= valor; x++)
            {
                for (int y = valor; y > -1; y--)
                {
                    if (y == TerminarBucle)
                    {
                        Console.Write(DiagonalImprimir[x, y]);
                        break;
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                TerminarBucle--;
                Console.WriteLine();
            }
        }
        public int DiagonalDerechaSuma(int[,] Matriz, int valor)
        {
            int[,] DiagonalSuma = Matriz;
            int suma = 0;
            int TerminarBucle;
            valor = valor - 1;
            TerminarBucle = valor;

            for (int x = 0; x <= valor; x++)
            {
                for (int y = valor; y > -1; y--)
                {
                    if (y == TerminarBucle)
                    {
                        suma = suma + DiagonalSuma[x, y];
                        break;
                    }
                }
                TerminarBucle--;
            }
            return suma;
        }

    }
}
