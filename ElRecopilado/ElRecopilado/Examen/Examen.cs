using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Examen
{
    class Examen
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
            Console.WriteLine("Ingrese una palabra");
            str = Console.ReadLine();
            str = str.Replace("a", "4");
            str = str.Replace("o", "0");
            str = str.Replace("i", "1");
            str = str.Replace("s", "$");
            str = str.Replace("t", "#");
            str = str.Replace("A", "4");
            str = str.Replace("O", "0");
            str = str.Replace("I", "1");
            str = str.Replace("S", "$");
            str = str.Replace("T", "#");

            Console.Write(str);
            return "";
        }

        //PARTE 4
        public static string Cifrar(string str, int desp)
        {
            string  le, Posi = "";
            string[] abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "X" };
            Console.WriteLine("ingrese una palabra:");
            str = Console.ReadLine();
            Console.WriteLine("ingrese un desplazamiento:");
            desp = int.Parse(Console.ReadLine());
            le = str.ToUpper();
            string[] vs = new string[le.Length];
            for (int i = 0; i <= le.Length - 1; i++)
            {
                vs[i] = le.Substring(i, 1);

            }
            for (int j = 0; j <= vs.Length - 1; j++)
            {
                for (int k = 0; k <= abc.Length - 1; k++)
                {
                    if (vs[j] == abc[k])
                    {
                        Posi = Posi + (k + 1) + ",";
                        int z = k + 1 + desp;
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
          
            return "";
        }
        public static string Descifrar(string str, int desp)
        {
  
            string[] abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "X" };
            string  de, Poi = "";
            Console.WriteLine("ingrese una palabra:");
            str = Console.ReadLine();
            Console.WriteLine("ingrese un desplazamiento:");
            desp = int.Parse(Console.ReadLine());
            de = str.ToUpper();
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
                        int z = k + 1 - desp;
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
    }
}
