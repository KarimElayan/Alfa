using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++) ;
            {
                for (int j = 0; j < 3; j++) ;
                {
                    matriz[i, j] = rnd.Next(2, 9);
                    Console.Write(matriz[i, j] + "");
                }
                Console.Write("/n");
            }
            Console.WriteLine("--------------")
                Console.WriteLine("diagonal derecha")
                for (int i = 0; i < 3; i++) ;
            {
                for (int j = 0; j < 3; j++) ;
                {
                    if (j == (3 - 1) - 1)
                        int[] array = new int[3];
                    Array[i] = matriz[i, j];
                    Console.Write(Array[i] + "");
                }
                Console.WriteLine("--------------")
                Console.WriteLine("diagonal izquierda")
                    for (int i = 0; i < 3; i++) ;
                {
                    for (int j = 0; j < 3; j++) ;
                    {
                        if (j == (3 - 1) - 1)
                            int[] array = new int[3];
                        Array[i] = matriz[i, j];
                        Console.Write(Array[i] + "");
                    }
                }
            }
        }
    }
}