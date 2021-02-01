using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EXAMEN
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
            Console.WriteLine("ingrese un numero");
            
            int a = 0;
            int b = 1;
            int x = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write(a + "\n");
                int c = a + b;
                a = b;
                b = c;
                if (a % 2 == 0) { x++; }
            }
            Console.Write("en este arreglo existen: " + x + " numeros primos");

            return new List<int>();
        }

        //PARTE 3
        public static string LetrasPorNumeros(string str)
        {
            Console.WriteLine("ingresar una palabra");
            string A = Console.ReadLine();
            A = A.Replace("a", "Á");
            A = A.Replace("b", "ß");
            A = A.Replace("c", "©");
            A = A.Replace("d", "Ð");
            A = A.Replace("e", "3");
            A = A.Replace("f", "ƒ");
            A = A.Replace("g", "6");
            A = A.Replace("h", "H");
            A = A.Replace("i", "1");
            A = A.Replace("j", "J");
            A = A.Replace("k", "K");
            A = A.Replace("l", "└");
            A = A.Replace("m", "µ");
            A = A.Replace("n", "N");
            A = A.Replace("ñ", "Ñ");
            A = A.Replace("o", "0");
            A = A.Replace("p", "þ");
            A = A.Replace("q", "Q");
            A = A.Replace("r", "R");
            A = A.Replace("s", "$");
            A = A.Replace("t", "7");
            A = A.Replace("u", "ü");
            A = A.Replace("v", "V");
            A = A.Replace("w", "W");
            A = A.Replace("x", "×");
            A = A.Replace("y", "¥");
            A = A.Replace("z", "Z");
            Console.Write(A);

            return "";
        }

        //PARTE 4
        public static string Cifrar(string str, int desp)
        {
            string letras, le, Posi = "";
            string[] abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "X" };
            Console.WriteLine("ingrese una palabra:");
            letras = Console.ReadLine();
            Console.WriteLine("numero de desplazamiento:");
            int n = int.Parse(Console.ReadLine());
            le = letras.ToUpper();
            string[] vs = new string[le.Length];
            for (int j = 0; j <= le.Length - 1; j++)
            {
                vs[j] = le.Substring(j, 1);

            }
            for (int j = 0; j <= vs.Length - 1; j++)
            {
                for (int k = 0; k <= abc.Length - 1; k++)
                {
                    if (vs[j] == abc[k])
                    {
                        Posi = Posi + (k + 1) + ",";
                        int z = k + 1 + n;
                        if (z > 26)
                        {
                            z = z - 27;
                            Console.Write(abc[z]);
                        }
                        else
                        {
                            z = z - 1;
                            Console.Write(abc[z]);
                        }
                    }
                }
            }
            Posi = Posi.Remove(Posi.Length - 1);
            //////////////////////////////////////////////////////////
            ///
            string des, de, Poi = "";
            Console.WriteLine("ingrese una palabra:");
            des = Console.ReadLine();
            Console.WriteLine("ingrese un desplazamiento:");
            int m = int.Parse(Console.ReadLine());
            de = des.ToUpper();
            string[] sv = new string[de.Length];
            for (int i = 0; i <= de.Length - 1; i++)
            {
                sv[i] = de.Substring(i, 1);

            }
            for (int j = 0; j <= sv.Length - 1; j++)
            {
                for (int k = 0; k <= abc.Length - 1; k++)
                {
                    if (sv[j] == abc[k])
                    {
                        Poi = Poi + (k + 1) + ",";
                        int z = k + 1 - m;
                        if (z < 0)
                        {
                            z = z + 25;
                            Console.Write(abc[z]);
                        }
                        else
                        {
                            z = z - 1;
                            Console.Write(abc[z]);
                        }
                    }
                }
            }
            Poi = Poi.Remove(Poi.Length - 1);
            return "";
        }
        public static string Descifrar(string str, int desp)
        {
            return "";
        }

    }
}

 
