using System;

public class Class1
{
	public Class1()
	{
        //PARTE 1
        public static List<int> IndexOfCapitals(string str)
        {

            {
                static void Main(string[] args)
                {
                    String[,] Matriz = new String[,]
                   {
                { "A","t","j", "B","C", "p"},
                {"r", "E","G","g","y" ,"H"},
                { "i","l", "J","K", "o", "ñ"},
                { "z", "N", "w","O","&", "v"},
                { "P", "q","f","a","f","S"},
                { "w", "d", "V", "W","ñ","e"},
                {"X", "p","Z","j","f","P" }
                   };
                    for (int x = 0; x < 6; x++)
                    {
                        for (int y = 0; y < 6; y++)
                        {
                            Console.Write(Matriz[x, y] + ",");
                        }
                        Console.WriteLine();
                    }
                    for (int x = 0; x < Matriz.GetLength(0); x++)
                    {
                        for (int y = 0; y < Matriz.GetLength(1); y++)
                        {
                            switch (Matriz[x, y])
                            {
                                case "A":
                                case "B":
                                case "C":
                                case "D":
                                case "E":
                                case "F":
                                case "G":
                                case "H":
                                case "I":
                                case "J":
                                case "K":
                                case "L":
                                case "M":
                                case "N":
                                case "Ñ":
                                case "O":
                                case "P":
                                case "Q":
                                case "R":
                                case "S":
                                case "T":
                                case "U":
                                case "V":
                                case "W":
                                case "X":
                                case "Y":
                                case "Z":

                            }
                            Console.Write(Matriz[x, y] + ",");
                        }
                    }

                    //return new List<int>();
                }

            }
        }
    }
}

