using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EXAMEN
{
    class EXAMEN
    {

        static void Main(string[] args)
        {
            int caso = 0;
            int num = 0;
            String texto, Cambio;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bienvenido");
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1.--Posicion de mayusculas en una Cadena");
                Console.WriteLine("2.--Numeros Primos en una serie");
                Console.WriteLine("3.--Remplazo de letras");
                Console.WriteLine("4 Cifrar mensaje");
                Console.WriteLine("5.--Decifrar mensaje");
                Console.WriteLine("6.-- Salir");
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
                        Cas = Console.ReadLine();
                        num = int.Parse(Cas);

                        Prim = PrimeSerieAlfa(num);

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
                    case 4:
                        Console.WriteLine("Introduce Una cadena de texto");
                        texto = Console.ReadLine();
                        Console.WriteLine("Introduce Una Clave");
                        Cas = Console.ReadLine();
                        num = int.Parse(Cas);
                        Cambio = Cifrar(texto, num);
                        Console.WriteLine("Mensaje Cifrado: " + Cambio);
                        break;
                    case 5:
                        Console.WriteLine("Introduce Una cadena de texto");
                        texto = Console.ReadLine();
                        Console.WriteLine("Introduce Una Clave");
                        Cas = Console.ReadLine();
                        num = int.Parse(Cas);
                        Cambio = Decifrar(texto, num);
                        Console.WriteLine("Mensaje desifrado" + Cambio);
                        break;
                }

            } while (caso != 6);


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
        public static string Cifrar(string Cadena2, int rec)
        {
            int temp = 0;
            String Inc = "";
            for (int i = 0; i < Cadena2.Length; i++)
            {
                Char X = Cadena2[i];
                temp = (int)X;
                for (int j = 0; j < rec; j++)
                {


                    if (temp == 65)
                    {

                        temp = 90;
                    }
                    else if (temp == 97)
                    {

                        temp = 122;
                    }
                    else
                    {
                        temp--;
                    }

                }
                Inc += (char)temp;
            }
            return Inc;
        }
        public static string Decifrar(string Cadena2, int rec)
        {
            int temp = 0;
            String Inc = "";
            for (int i = 0; i < Cadena2.Length; i++)
            {
                Char X = Cadena2[i];
                temp = (int)X;
                for (int j = 0; j < rec; j++)
                {


                    if (temp == 90)
                    {

                        temp = 65;
                    }
                    else if (temp == 122)
                    {

                        temp = 97;
                    }
                    else
                    {
                        temp++;
                    }

                }
                Inc += (char)temp;
            }
            return Inc;
        }






    }
}
