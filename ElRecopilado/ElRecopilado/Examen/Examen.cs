using ElRecopilado.EnClase;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Examen
{
    public static class Examen
    {
        //PARTE 1
        public static List<int> IndexOfCapitals(string str)
        {
            Console.Write("INGRESE UN TEXTO PARA LOCALIZAR LAS LETRAS MAYUSCULAS: ");
            str = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (System.Char.IsUpper(str[i]) == true)
                {
                    Console.WriteLine("EL TEXTO TIENE LA MAYUSCULA: " + str[i] + " EN LA POSICION: " + i);
                }
            }
            return new List<int>();
        }
        // PARTE 2
        public static List<int> PrimeSerieAlfa(int n)
        {
            int i, PrimerNumero = 1, SegundoNumero = 1, SumaNumeros = 0;
            Console.Write("INRESE UN NUMERO: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("===================");
            Console.Write("SERIE ->  " + PrimerNumero + "|" + SegundoNumero + "|");

            List<int> NumeroPrimos = new List<int>();
                        
            for (i = 3; i <= n; i++)
            {
                SumaNumeros = PrimerNumero + SegundoNumero;
                Console.Write(SumaNumeros + "|");
                PrimerNumero = SegundoNumero;
                SegundoNumero = SumaNumeros;
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
            Console.Write("INRESE UN TEXTO PARA REMPLAZAR LETRAS POR NUMEROS: ");
            str = Console.ReadLine();
            Console.WriteLine(str.Replace("a", "4").Replace("o", "0").Replace("i", "1").Replace("s", "$").Replace("t", "#"));
            return "";
        }

        //PARTE 4
        public static bool ASSCII(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
        public static string Cifrar(string str, int desp)
        {
            int t, letras;
            Console.Write("INGRESE EL TEXTO A CIFRAR: ");
            str = Console.ReadLine();
            Console.Write("INGRESE EL VALOR DE DESPLAZAMIENTO: ");
            desp = int.Parse(Console.ReadLine());

            letras = str.Length;
            char[] ch = new char[letras];

            for (int i = 0; i < letras; i++)
            {
                t = (int)str[i];
                ch[i] = (char)(t + desp-1);
                Console.Write(ch[i]);
            }

            return "";
        }
        public static string Descifrar(string str, int desp)
        {
            int t, letras;
            Console.Write("INGRESE EL TEXTO A CIFRAR: ");
            str = Console.ReadLine();
            Console.Write("INGRESE EL VALOR DE DESPLAZAMIENTO: ");
            desp = int.Parse(Console.ReadLine());

            letras = str.Length;
            char[] ch = new char[letras];

            for (int i = 0; i < letras; i++)
            {
                t = (int)str[i];
                ch[i] = (char)(t - desp-1);
                Console.Write(ch[i]);
            }
            return "";
        }

    }
}