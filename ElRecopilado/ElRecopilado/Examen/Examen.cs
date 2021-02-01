using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Examen
    {
        //PARTE 1
        public static List<int> IndexOfCapitals(string letra)
        {

            Console.WriteLine("ingrese una frase o palabra");
            string frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                letra = frase.Substring(i, 1);
                if (letra == "A")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (A)");
                else if (letra == "B")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (B)");
                else if (letra == "C")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (C)");
                else if (letra == "D")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (D)");
                else if (letra == "E")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (E)");
                else if (letra == "F")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (F)");
                else if (letra == "G")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (G)");
                else if (letra == "H")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (H)");
                else if (letra == "I")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (I)");
                else if (letra == "J")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (J)");
                else if (letra == "K")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (K)");
                else if (letra == "L")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (L)");
                else if (letra == "M")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (M)");
                else if (letra == "N")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (N)");
                else if (letra == "Ñ")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (Ñ)");
                else if (letra == "O")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (O)");
                else if (letra == "P")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (P)");
                else if (letra == "Q")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (Q)");
                else if (letra == "R")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (R)");
                else if (letra == "S")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (S)");
                else if (letra == "T")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (T)");
                else if (letra == "U")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (U)");
                else if (letra == "V")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (V)");
                else if (letra == "W")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (W)");
                else if (letra == "X")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (X)");
                else if (letra == "Y")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (Y)");
                else if (letra == "Z")
                    Console.WriteLine("En la posicion: " + i + " esta la letra (Z)");
                
            }
            return new List<int>();


        }
        // PARTE 2
        public static List<int> PrimeSerieAlfa(int n)
        {

            int x = 0, y = 1, z = 1, num, res, con = 0;
            Console.WriteLine("ingrese un valor numerico del 1 al 100: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1");
            for (int i = 1; i < n; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
                num = z;
                res = num % 2;
                if (res != 0)
                    con = con + 1;

            }
            Console.WriteLine("La cantidad de numeros primos es: " + con);

            return new List<int>();
        }

        //PARTE 3
        public static string LetrasPorNumeros(string cadena)
        {

            Console.WriteLine("Ingrese una palabra:");
            cadena = Console.ReadLine();
            cadena = cadena.Replace("a", "4");
            cadena = cadena.Replace("o", "0");
            cadena = cadena.Replace("i", "1");
            cadena = cadena.Replace("s", "$");
            cadena = cadena.Replace("t", "#");

            Console.WriteLine(cadena);

            return "";
        }

        //PARTE 4
        public static string Cifrar(string str, int desp)
        {
            int t, o, letras, x, z, frase;
            Console.WriteLine("Cifrador de mensajes");
            Console.WriteLine("ingresa un valor");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa una frase");
            string cadena = Console.ReadLine();
            Console.WriteLine("La frese cifrada es:");
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t + x);
                Console.Write(ch[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Desifrar un mensajes");
            Console.WriteLine("ingresa un valor");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa una frase");
            string cade = Console.ReadLine();
            Console.WriteLine("La frese descifrada:");
            frase = cade.Length;
            char[] cha = new char[frase];
            for (int j = 0; j < frase; j++)
            {
                o = (int)cade[j];
                cha[j] = (char)(o - z);
                Console.WriteLine(cha[j]);
            }
            return "";

        }
    }
}

            
