using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Guadalupe
{
    class Examen
    {
        public bool Ejercicio5(string palabra)
        {
            bool palindromo = false;
            string inverso, caracter;
            int i;
            Console.WriteLine("palabra que desea invertir");
            palabra = Convert.ToString(Console.ReadLine());
            i = palabra.Length;
            inverso = "";
            for (int x = i - 1; x >= 0; x--)
            {
                caracter = palabra.Substring(x, 1);
                inverso = inverso + caracter;
            }
            Console.WriteLine("inverso de la palabra");
            Console.WriteLine(inverso);
            if (palabra == inverso)
            {
                palindromo = true;
                Console.WriteLine(palindromo);

            }
            else
            {
                palindromo = false;
                Console.WriteLine(palindromo);

            }
            Console.ReadKey();
            return palindromo;
        }
        public float Ejercicio3(float n)
        {
            string numero = n.ToString();
            int total = 0;
            if (n >= 0)
            {
                int nentero = int.Parse(numero.Split(".")[0]);
                float ndecimal = float.Parse("0," + numero.Split(".")[1]);
                string nn = nentero.ToString();
                Console.WriteLine(nentero);
                Console.WriteLine(ndecimal);
                foreach (char numero2 in nn)
                {
                    total += int.Parse(numero2.ToString());

                }
                int total2 = total;
                n = total2 * ndecimal;
                Console.WriteLine($"la suma de los digitos de {numero} es: {total}");
                Console.WriteLine($"la multiplicacion es: {n}");
                Console.ReadLine();
            }
            else
            {
                int nentero = int.Parse(numero.Split(".")[0]);
                int nentero1 = nentero - nentero - nentero;
                float ndecimal = float.Parse("0," + numero.Split(".")[1]);
                string nn = nentero1.ToString();
                Console.WriteLine(nentero);
                Console.WriteLine(nentero1);
                Console.WriteLine(ndecimal);
                ////// resta 
                String[] arr = nn.Split(new char[] { ' ' });
                int total2 = total;
                float mul = total2 * ndecimal;
                Console.WriteLine($"la suma de los digitos de {numero} es: {total}");
                Console.WriteLine($"la multiplicacion es: {mul}");
                Console.ReadLine();

            }
            return n;

        }
        public int[] Ejercicio6(int[] numeros)
        {
            int[] arrint = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                arrint[i] = Convert.ToInt32(numeros[i]);
            }
            Array.Sort(arrint);
            int n = arrint.Length;
            int n2 = n - 1;
            int n3 = n2 - 1;
            Console.WriteLine(arrint[n2]);
            Console.WriteLine(arrint[n3]);
            Console.WriteLine(arrint[0]);
            return numeros;

        }
        public void Ejercicio2(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int y = 0; y < n - i; y++)
                    Console.Write(" ");

                for (int a = 0; a < (i * 2) - 1; a++)
                    Console.Write("*");

                Console.WriteLine();
            }
            
        }

    }

}
    
        


 

