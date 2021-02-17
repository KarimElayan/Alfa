using System;
using System.Collections.Generic;
using System.Text;


namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            {
                // par2
            }
            static void Main(string[] args)
            {

                Console.WriteLine("Programa que crea una pirámide de asteriscos");
            inicio:
                Console.WriteLine("inserta en número el nivel de la pirámide, mayor a cero");
                try
                {
                    int nivel = int.Parse(Console.ReadLine());
                    if (nivel != 0)
                    {

                        int a;
                        int espacios;
                        for (int i = 1; i <= nivel; i++)
                        {
                            StringBuilder final = new StringBuilder();

                            espacios = nivel - i;
                            a = i + (i - 1);
                            for (int i1 = 0; i1 < espacios; i1++)
                                final.Append(" ");

                            for (int i2 = 0; i2 < a; i2++)
                                final.Append("*");

                            Console.WriteLine(final.ToString());

                        }
                    }
                    else
                    {
                        System.Console.Clear();
                        goto inicio;
                    }

                }
                catch (Exception)
                {
                    System.Console.Clear();
                    Console.WriteLine("El programa solo acepta números enteros");
                    goto inicio;

                }

                Console.WriteLine("" + "\n" + "Programa creado por Estrada");
                Console.WriteLine("" + "\n" + "Aprieta una tecla para salir");
                Console.ReadLine();
            }
            {
                //parte4

                String[,] Matriz = new String[,]
                {
                { "n", "n","n", "a","n", "n","n", "a"},
                {"a", "n","n", "a","n", "n","a", "n"},
                { "n", "1r","n", "a","n", "a","n", "n"},
                {"n", "n","a", "a","a", "n","n", "n"},
                { "a", "a","a", "2r","a", "a","a", "a"},
                {"n", "n","a", "a","a", "n","n", "n"},
                { "n", "a","n", "a","n", "a","n", "n"},
                {"a", "n","n", "a","n", "n","a", "n"},

                };
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        Console.Write(Matriz[x, y] + ",");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("posisiones");
                {

                }
                Console.Write(Matriz[5, 4]);
                Console.Write(Matriz[6, 2]);
                bool comparador = true;
            }
            {

                {
                    //parte5
                    Console.WriteLine("Introduce una palabra y te diré si es palíndroma :) ");
                    String palabra = Console.ReadLine();
                    if (esPalindroma(palabra)) Console.WriteLine("Es palíndroma");
                    else Console.WriteLine("NO es palíndroma");
                }
                static Boolean esPalindroma(String cadena)
                {
                    Console.WriteLine("Función llamada con => " + cadena);
                    if (cadena.Length < 2) return true;
                    Console.WriteLine("Vamos a comparar => " + cadena[0]);
                    Console.WriteLine("Con => " + cadena[cadena.Length - 1]);
                    if (cadena[0] == cadena[cadena.Length - 1]) return esPalindroma(cadena.Substring(1, cadena.Length - 2));
                    return false;
                }
            }

            {

                {
                    Console.WriteLine("Introduce una palabra y te diré si es palíndroma :) ");
                    String palabra = Console.ReadLine();
                    if (esPalindroma(palabra)) Console.WriteLine("Es palíndroma");
                    else Console.WriteLine("NO es palíndroma");
                }
                static Boolean esPalindroma(String cadena)
                {
                    Console.WriteLine("Función llamada con => " + cadena);
                    if (cadena.Length < 2) return true;
                    Console.WriteLine("Vamos a comparar => " + cadena[0]);
                    Console.WriteLine("Con => " + cadena[cadena.Length - 1]);
                    if (cadena[0] == cadena[cadena.Length - 1]) return esPalindroma(cadena.Substring(1, cadena.Length - 2));
                    return false;
                }
            }
            {
                // parte7
                String[,] Matriz = new String[,]
                        {
                { "1", "0","0", "1"},
                {"1", "0","0", "1"},
                { "0", "0","0", "1"},
                { "1", "1", "0","1" },
                { "1", "0","1","0" },
                { "0", "1", "1", "0"},
                {"0", "0","0","1" }
                        };
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        Console.Write(Matriz[x, y] + ",");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("NUEVA Matriz");

                for (int x = 0; x < Matriz.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz.GetLength(1); y++)
                    {
                        switch (Matriz[x, y])
                        {
                            case "0":
                                Matriz[x, y] = Matriz[x, y] = "1";
                                break;


                        }
                        Console.Write(Matriz[x, y] + ",");
                    }
                }
            }
        }
    }
}

            


