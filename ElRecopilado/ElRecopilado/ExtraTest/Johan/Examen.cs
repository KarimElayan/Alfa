using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Johan
{
    class Examen
    {
        public bool Ejercicio1(int[] arreglo)
        {
            bool SieteContinuo = false;

            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                if (arreglo[i] == 7 && arreglo[i + 1] != 7)
                {
                    SieteContinuo = true;
                }
                else if (arreglo[i] == 7 && arreglo[i + 1] == 7)
                {
                    SieteContinuo = true;
                }
                else
                {
                    SieteContinuo = false;
                }
            }
                
            return !SieteContinuo;
        }
        public void Ejercicio2(int numero)
        {
            if (numero > 0 && numero < 21)
            {
                for (int i = 1; i <= numero; i++)
                {
                    for (int j = 0; j < numero - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < (i * 2) - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("EL PARAMETRO NO ES VALIDO...");
                Console.WriteLine("DEBE SER UN NUMERO ENTRE 1 Y 20");
            }
        }
        public float Ejercicio3(float numero)
        {
            string digitos = Convert.ToString(numero);
            if (numero > 0)
            {
                int suma = 0;
                for (int i = 0; i < digitos.Length - 1; i++)
                {
                    if (digitos[i] != '.')
                    {
                        suma += digitos[i] - '0';
                    }
                }
                int multiplicacion = digitos[digitos.Length - 1] - '0';
                suma = (suma * multiplicacion);
                Console.WriteLine(suma);
                return Convert.ToSingle(suma);
            }
            else
            {
                int resta = digitos[1] - '0';
                for (int i = 2; i < digitos.Length - 1; i++)
                {
                    if (digitos[i] != '.')
                    {
                        resta -= digitos[i] - '0';
                    }
                }
                int multiplicacion = digitos[digitos.Length - 1] - '0';
                resta = (resta * multiplicacion);
                Console.WriteLine(resta);
                return Convert.ToSingle(resta);
            }
        }
        public bool Ejercicio5(string cadena)
        {
            bool palindromo = false;

            char[] temp = cadena.ToCharArray();
            Array.Reverse(temp);
            string Ncadena = new string(temp);

            if (cadena.ToLower().Equals(Ncadena.ToLower()))
            {
                palindromo = true;
                Console.WriteLine(palindromo);
            }
            else
            {
                palindromo = false;
                Console.WriteLine(palindromo);
            }
            return palindromo;
        }
    }
}
