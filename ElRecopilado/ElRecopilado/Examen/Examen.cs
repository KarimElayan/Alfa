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
                return new List<int>();
            }
            // PARTE 2 
            public static List<int> PrimeSerieAlfa(int n)
            {

            int s,
                primero = 0,
                segundo = 1,
                siguiente;
            Console.WriteLine("Parte 2");
            Console.WriteLine("Digite el digito numerico para hacer la sucesion numerica:");
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i <= 1)
                {
                    siguiente = i;
                }
                else
                {
                    siguiente = primero + segundo;
                    primero = segundo;
                    segundo = siguiente;
                    if (siguiente <= 100)
                    {
                        Console.WriteLine("{0}", siguiente);
                    }
                }
            }
            return new List<int>();
            }
            //PARTE 3 
            public static string LetrasPorNumeros(string str)
            {
            String textoOrigen, NewTexto;

            Console.WriteLine("Parte 3 ");
            Console.WriteLine("Ingrese su texto");
            textoOrigen = Console.ReadLine();
            NewTexto = textoOrigen.Replace("a", "4")
                          .Replace("o", "0")
                          .Replace("i", "1")
                          .Replace("s", "$")
                          .Replace("t", "#")
                          .Replace("u", "n")
                          .Replace("r", "rr")
                          .Replace("e", "S");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Este es tu texto:" + NewTexto);
            return "";
            }
            //PARTE 4 
            public static string Cifrar(string str, int desp)
            {
            Console.WriteLine("Parte 4");
            string Texto, Desplazamiento, Posicion = "";
            string[] Abecedario = new string[]
            { "A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Console.WriteLine("Ingrese su texto:");
            Texto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de dezplasamientos a realizar:");
            int n = int.Parse(Console.ReadLine());
            Desplazamiento = Texto.ToUpper();
            string[] cambios = new string[Desplazamiento.Length];
            for (int i = 0; i <= Desplazamiento.Length - 1; i++)
            {
                cambios[i] = Desplazamiento.Substring(i, 1);

            }
            for (int x = 0; x <= cambios.Length - 1; x++)
            {
                for (int y = 0; y <= Abecedario.Length - 1; y++)
                {
                    if (cambios[x] == Abecedario[y])
                    {
                        Posicion = Posicion + (y + 1) + ",";
                        int z = y + 1 + n;
                        if (z > 26)
                        {
                            z = z - 27;
                            Console.Write(Abecedario[z]);
                        }
                        else
                        {
                            z = z - 1;
                            Console.Write(Abecedario[z]);
                        }
                    }
                }
            }
            return "";
            }
            public static string Descifrar(string str, int desp)
            {
                return "";
            }
    }
}
