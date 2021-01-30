using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas, tamañofilas, tamañocolumnas, sumaf, sumac;
            Console.WriteLine("fila de matriz:");
            tamañofilas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("columna de matriz:");
            tamañocolumnas = Convert.ToInt32(Console.ReadLine());
            int[,] bidimencion;
            bidimencion = new int[tamañofilas, tamañocolumnas];
            for (filas = 0; filas < tamañofilas; filas++)
            {
                for (columnas = 0; columnas < tamañocolumnas; columnas++)
                {
                    Console.Write("Ingresa los datos solo 1 y 0[" + filas + "," + columnas + "]" + "]: ");
                    bidimencion[filas, columnas] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Impresion de la matriz");
            for (filas = 0; filas < tamañofilas; filas++)
            {
                for (columnas = 0; columnas < tamañocolumnas; columnas++)
                    Console.Write("[" + bidimencion[filas, columnas] + "]");
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.ReadKey(true);
            Console.WriteLine("Longitud del rio"); 
        }
    }
}