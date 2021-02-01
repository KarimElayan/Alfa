using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado
{
    class EXAMEN
    {
        public static class Program
        {
            //PARTE 1
            public static List<int> IndexOfCapitals(string str)
            {
                List<int> PosicionesDeMayusculas = new List<int>();
                List<bool> ListaDeverdadDeCaracteres = new List<bool>();
                foreach (char ObtencionDeCaracteres in str)
                {
                    //listaDeCaracteres;
                    if (ObtencionDeCaracteres == 'A' || ObtencionDeCaracteres == 'B' || ObtencionDeCaracteres == 'C' ||
                        ObtencionDeCaracteres == 'D' || ObtencionDeCaracteres == 'E' || ObtencionDeCaracteres == 'F' ||
                        ObtencionDeCaracteres == 'G' || ObtencionDeCaracteres == 'H' || ObtencionDeCaracteres == 'I' ||
                        ObtencionDeCaracteres == 'J' || ObtencionDeCaracteres == 'K' || ObtencionDeCaracteres == 'L' ||
                        ObtencionDeCaracteres == 'M' || ObtencionDeCaracteres == 'N' || ObtencionDeCaracteres == 'Ñ' ||
                        ObtencionDeCaracteres == 'O' || ObtencionDeCaracteres == 'P' || ObtencionDeCaracteres == 'Q' ||
                        ObtencionDeCaracteres == 'R' || ObtencionDeCaracteres == 'S' || ObtencionDeCaracteres == 'T' ||
                       ObtencionDeCaracteres == 'U' || ObtencionDeCaracteres == 'V' || ObtencionDeCaracteres == 'W' ||
                        ObtencionDeCaracteres == 'X' || ObtencionDeCaracteres == 'Y' || ObtencionDeCaracteres == 'Z')
                    {
                        ListaDeverdadDeCaracteres.Add(true);
                    }
                    else
                    {
                        ListaDeverdadDeCaracteres.Add(false);
                    }
                }
                for (int y = 0; y < ListaDeverdadDeCaracteres.Count; y++)
                {
                    if (ListaDeverdadDeCaracteres[y] == true)
                    {
                        PosicionesDeMayusculas.Add(y);
                    }
                }
                return PosicionesDeMayusculas;

            }
            // PARTE 2
            public static List<int> PrimeSerieAlfa(int n)
            {
                int a, b, limite, i, auxiliar;
                Console.WriteLine("Ingrese la cantidad de numeros que desea mostrar");
                limite = int.Parse(Console.ReadLine());
                a = 0;
                b = 1;
                for (i = 0; i < limite; i++)
                {
                    auxiliar = a;
                    a = b;
                    b = auxiliar + a;
                    Console.WriteLine(a);
                }
                Console.ReadKey();
                return new List<int>();
            }
            //PARTE 3
            public static string LetrasPorNumeros(string str)
            {
                Console.WriteLine("Añadir tu palabra");
                string A = Console.ReadLine();
                A = A.Replace("a", "4");
                A = A.Replace("b", "b");
                A = A.Replace("c", "c");
                A = A.Replace("d", "d");
                A = A.Replace("e", "3");
                A = A.Replace("f", "f");
                A = A.Replace("g", "6");
                A = A.Replace("h", "h");
                A = A.Replace("i", "1");
                A = A.Replace("j", "j");
                A = A.Replace("k", "k");
                A = A.Replace("l", "l");
                A = A.Replace("m", "m");
                A = A.Replace("n", "n");
                A = A.Replace("o", "0");
                A = A.Replace("p", "p");
                A = A.Replace("q", "q");
                A = A.Replace("r", "r");
                A = A.Replace("s", "5");
                A = A.Replace("t", "7");
                A = A.Replace("u", "u");
                A = A.Replace("v", "v");
                A = A.Replace("w", "w");
                A = A.Replace("x", "x");
                A = A.Replace("y", "y");
                A = A.Replace("z", "2");
                Console.Write(A);
                return "";
            }

            //PARTE 4
            public static string Cifrar(string str, int desp)
            {

                return "";
            }
            public static string Descifrar(string str, int desp)
            {
                return "";
            }

        }
    }


}
