using ElRecopilado.EnClase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ElRecopilado.Examen
{
    public static class Examen
    {
        //PARTE 1
        public static List<int> IndexOfCapitals(string str)
        {
            return new List<int>();
        }
        // PARTE 2
        public static List<int> PrimeSerieAlfa(int n)
        {
            byte cantidad;
            int a = 1, b = 1, c, x = 0;
            string auxiliar;
            Console.WriteLine("Ingresa un numero");
            auxiliar = Console.ReadLine();
            cantidad = byte.Parse(auxiliar);
            Console.Write("La serie es" + a + "" + b + "");
            for (int i = 3; i <= cantidad; i++)
            {
                c = a + b;
                Console.Write(c + "");
                a = b;
                b = c;
                if (a % 2 == 0) { x++; }
            }
            Console.Write(" existen: " + x + " numero primo");
            Console.WriteLine();
            return new List<int>();
        }



        //PARTE 3
        public static string LetrasPorNumeros(string str)
        {
            Console.WriteLine("Ingrese una palabra");
            str = Console.ReadLine();
            str = str.Replace("a", "2");
            str = str.Replace("b", "6");
            str = str.Replace("c", "&");
            str = str.Replace("o", "0");
            str = str.Replace("i", "9");
            str = str.Replace("s", "$");
            str = str.Replace("t", "#");
            str = str.Replace("A", "2");
            str = str.Replace("B", "6");
            str = str.Replace("C", "&");
            str = str.Replace("O", "0");
            str = str.Replace("I", "9");
            str = str.Replace("S", "$");
            str = str.Replace("T", "#");
            Console.Write(str);
            return "";
        }


        //PARTE 4
        public static string Cifrar(string str, int desp)
        {
            int b, j;
            Console.WriteLine("Introduce la palabra");
            str = Console.ReadLine();
            j = str.Length;
            char[] ch = new char[j];
            Console.WriteLine("el cifrado es:");
            for (int i = 0; i < j; i++)
            {
                b = (int)str[i];
                ch[i] = (char)(b + 3);
                Console.WriteLine(ch[i]);
            }
            Console.ReadLine();
            return "";
        }

    }
    public static string Descifrar(string str, int desp)
    {
        int b, j;
        Console.WriteLine("Introduce la clave");
        str = Console.ReadLine();
        j = str.Length;
        char[] ch = new char[j];
        Console.WriteLine("el cifrado es:");
        for (int i = 0; i < j; i++)
        {
            b = (int)str[i];
            ch[i] = (char)(b - 3);
            Console.WriteLine(ch[i]);
        }
        Console.ReadLine();
        return "";
    }
}