using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    public class HolaMundo
    {
        public void HacerMagia()

        {
            Console.WriteLine("HOLA MUNDO!");
            Console.WriteLine("Angela Belem Jimenez Ramales");
            Console.WriteLine("CUH51197172");
            Console.WriteLine("CUH51197172@cuh.mx");
        }
    }
}
class Matriz
{
    private int[,] mat;

    public void Ingresar()
    {
        mat = new int[3, 4];
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                string linea;
                linea = Console.ReadLine();
                mat[f, c] = int.Parse(linea);
            }
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write(mat[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Matriz ma = new Matriz();
        ma.Ingresar();
        ma.Imprimir();

    }


}
class Program
{
    static void Main(string[] args)
    {
        int i, j, filas = 0, columnas = 0, sumadiagonal = 0;
        Console.WriteLine("filas?");
        filas = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("columnas?");
        columnas = Convert.ToInt16(Console.ReadLine());
        Random aleatorio = new Random();
        int[,] matriz = new int[filas, columnas];
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = aleatorio.Next(0, 10);
                //Console.WriteLine("Ingrese numero en la posicion {0},{1}",i.ToString(),j.ToString());
            }
        }

        Console.WriteLine("MATRIZ");
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Diagonal");
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.Write(matriz[i, j].ToString() + " ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("La suma de la diagonal es: ");
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j)
                {
                    //sumadiagonal =matriz[i,j] + matriz[i,j];
                    Console.Write(matriz[i, j].ToString() + " ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}