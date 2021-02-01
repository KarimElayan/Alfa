using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EXAMEN
{
    class Examen
    {
        //PARTE 1
        public static List<int> IndexOfCapitals(string str)
        {
            Console.WriteLine("ingresar un texto a str");
            str=Console.ReadLine();

            for (int j = 0; j < str.Length; j++)
            {
                if (System.Char.IsUpper(str[j]) == true)
                {
                    Console.WriteLine("EN LA POSICION: " + j + " ESTA LA LETRA MAYUSCULA: " + str[j]);
                }
            }
            return new List<int>();
        }
        // PARTE 2
        public static List<int> PrimeSerieAlfa(int n)
        {
            int i, NumeroUno = 1, NumeroDos = 1, SumaNumeros = 0, Contador = 0;
            Console.Write("INGRESAR UN NUMERO: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("SERIE ->  " + NumeroUno + "|" + NumeroDos + "|");

            List<int> NumeroPrimos = new List<int>();

            for (i = 3; i <= n; i++)
            {
                SumaNumeros = NumeroUno + NumeroDos;
                Console.Write(SumaNumeros + "|");
                NumeroUno = NumeroDos;
                NumeroDos = SumaNumeros;
            }

            Console.WriteLine();
            Console.WriteLine();

            for (i = 2; i <= n; i++)
            {
                if (i % 2 != 0)

                {
                    NumeroPrimos.Add(i);
                    Console.WriteLine("LOS NUMEROS PRIMOS SON: " + i);
                }
            }
            Console.ReadLine();

            return new List<int>();
        }

        //PARTE 3
        public static string LetrasPorNumeros(string str)
        {
            Console.WriteLine("ingresa un texto para cambiar");
            str = Console.ReadLine();
            Console.WriteLine(str.Replace("a", "4").Replace("o", "0").Replace("i", "1").Replace("s", "$").Replace("t", "#"));           
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
