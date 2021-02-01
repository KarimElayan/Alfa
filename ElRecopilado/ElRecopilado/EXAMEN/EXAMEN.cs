using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXAMEN2
{
    class Program
    {

        static void Main(string[] args)
        {
            int caso = 0;
            String texto, Cambio;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("HELLO BIENVENIDO");
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1.--Posicion de mayusculas en una Cadena");
                Console.WriteLine("2.--Numeros Primos en una serie");
                Console.WriteLine("3.--Remplazo de letras");
                String Cas = Console.ReadLine();
                caso = int.Parse(Cas);
                switch (caso)
                {
                    case 1:
                        Console.WriteLine("Introduce Una cadena de texto");
                        texto = Console.ReadLine();
                        List<int> Pos2 = new List<int>();
                        Pos2 = IndexOfCapitals(texto);
                        Console.WriteLine("");
                        for (int i = 0; i < Pos2.Count(); i++)
                        {
                            Console.Write(Pos2[i] + " ");
                        }
                        break;

                    case 2:
                        List<int> Prim = new List<int>();

                        Prim = PrimeSerieAlfa(15);

                        for (int i = 0; i < Prim.Count(); i++)
                        {
                            Console.WriteLine(Prim[i] + " Primo");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Introduce Una cadena de texto");
                        texto = Console.ReadLine();
                        Cambio = LetrasPorNumeros(texto);
                        Console.WriteLine(Cambio);

                        break;
                }

            } while (caso != 5);

        }
        public static List<int> IndexOfCapitals(String Cadena)
        {

            List<int> Pos = new List<int>();

            for (int i = 0; i < Cadena.Length; i++)
            {
                Char X = Cadena[i];
                Boolean va = char.IsUpper(X);
                if (va)
                {
                    Console.Write(X + " ");
                    Pos.Add(i);
                }
            }
            return Pos;
        }

        public static List<int> PrimeSerieAlfa(int n)
        {
            List<int> Pri = new List<int>();
            if (n > 1 && n < 100)
            {
                int f = 0;
                int N1 = 1;
                int N2;
                for (int i = 0; i < n; i++)
                {
                    N2 = f;
                    f = N1 + f;
                    N1 = N2;
                    Console.Write(f + " ");


                    Boolean esPrimo = true;

                    if (f == 1) { esPrimo = false; }
                    for (int j = 2; j < f; j++)
                    {

                        if (f % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo)
                    {
                        Pri.Add(f);
                    }

                }
                return Pri;
            }
            else
            {
                Pri.Add(0);
                Console.Write("El numero no esta entre 1 y 100 :(");
                return Pri;
            }
        }
        public static string LetrasPorNumeros(string str)
        {
            String Cambio = "";
            for (int i = 0; i < str.Length; i++)
            {
                Char X = str[i];
                if (X == 'a' || X == 'A')
                { Cambio += "4"; }
                else if (X == 'o' || X == 'O')
                { Cambio += "0"; }
                else if (X == 'i' || X == 'I')
                { Cambio += "1"; }
                else if (X == 'S' || X == 's')
                { Cambio += "$"; }
                else if (X == 'T' || X == 't')
                { Cambio += "#"; }
                else { Cambio += X; }
            }
            return Cambio;
        }
        break;
           
                case 4:
          static void Main(string[] args)
        {
            string letras, le, Posi = "";
            string[] abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "X" };
            Console.WriteLine("ingrese una palabra:");
            letras = Console.ReadLine();
            Console.WriteLine("ingrese un desplazamiento:");
            int n = int.Parse(Console.ReadLine());
            le = letras.ToUpper();
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


        }


    }
}