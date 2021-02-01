using System;

namespace Examen
{
    class Program
    {
        //PARTE 3
        public static string LetrasPorNumeros(string str)
        {

            String[,] Matriz = new String[,]
            {
                { "A", "B","C", "D"},
                {"F", "E","G", "H"},
                { "I", "J","K", "L"},
                { "M", "N", "Ñ","O" },
                { "P", "Q","R","S" },
                { "T", "U", "V", "W"},
                {"X", "Y","Z","." }
            };
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(Matriz[x, y] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine("NUEVO ABECEDARIO");

            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    switch (Matriz[x, y])
                    {
                        case "A":
                            Matriz[x, y] = Matriz[x, y] = "4";
                            break;
                        case "E":
                            Matriz[x, y] = Matriz[x, y] = "3";
                            break;
                        case "I":
                            Matriz[x, y] = Matriz[x, y] = "1";
                            break;
                        case "O":
                            Matriz[x, y] = Matriz[x, y] = "0";
                            break;
                        case "U":
                            Matriz[x, y] = Matriz[x, y] = "9";
                            break;
                    }
                    Console.Write(Matriz[x, y] + ",");
                }
            }

        }
    }
         return "";
}
