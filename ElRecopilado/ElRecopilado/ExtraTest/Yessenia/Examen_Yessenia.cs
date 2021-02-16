using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Yessenia
{
    class Examen
    {
        public string Ejercicio1(string x)
        {
            
           
            char[] delimitador = { ',', ' ' };
            String[] te = x.Split(delimitador);
            int j = te.Length;

            for (int i = 0; i < j; i++)
            {
                Console.Clear();
                if (j <= 1)
                {
                    Console.WriteLine("False");
                }
                else if (j > 1)
                {
                    if (te[i] == "7")
                    {
                        if (te[i + 1] != "")
                        {
                            if (te[i + 1] != "7")
                            {
                                Console.WriteLine("False");
                                break;
                            }
                            else if (te[i + 1] == "7")
                            {
                                Console.WriteLine("True");
                                break;
                            }
                        }
                    }
                    else if (te[i] != "7")
                    {
                        Console.WriteLine("False");
                    }

                }
            }
            return x;

        }
        public int Ejercicio2(int num)
        {
            
          
            Console.Clear();

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < num - i; j++)
                    Console.Write(" ");

                for (int k = 0; k < (i * 2) - 1; k++)
                    Console.Write("*");

                Console.WriteLine();
            }
            return num;

        }
        public float Ejercicio3(float cadena)
        {
            int nume = 0;
            int aux, mul, res;
            
            string cad = Convert.ToString(cadena);
            if (cad[0] == '-')
            {
               
                
                String[] arreglo = cad.Split('.');
                aux = int.Parse(arreglo[0]);
                while (aux > 0)
                {
                    nume = -nume + aux % 10;
                    aux = aux / 10;
                }
                mul = int.Parse(arreglo[1]);
                res = mul * nume;
                Console.WriteLine("Respuesta: " + res);
            }
            else if (cad[0] != '-')
            {
                String[] arreglo = cad.Split('.');
                aux = int.Parse(arreglo[0]);
                while (aux > 0)
                {
                    nume = nume + aux % 10;
                    aux = aux / 10;
                }
                mul = int.Parse(arreglo[1]);
                res = mul * nume;
                Console.WriteLine("Respuesta: " + res);
            }
            Console.ReadKey();
            return cadena;

        }
        public string Ejercicio5(string original)
        {
            string reverso, tem;
            Console.Write("la palabra es palindromo :");
            original = original.Replace(" ", "");
            original = original.ToUpper();
            reverso = "";
            for (int i = original.Length - 1; i >= 0; i--)
            {
                tem = original.Substring(i, 1);
                reverso = reverso + tem;
            }
            if (original == reverso)
                Console.WriteLine("TRUE");
            else if (original != reverso)
                Console.WriteLine("FALSE");
            return original;

        }
        public int[] Ejercicio6(int[] vector)
        {
            
            int auxi, mayor = 0, xa, y, z;
           

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("ingrese el valor " + (i + 1) + " : ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < vector.Length; i++)
            {
                for (int ja = i + 1; ja < vector.Length; ja++)
                {
                    if (vector[i] > vector[ja])
                    {
                        auxi = vector[i];
                        vector[i] = vector[ja];
                        vector[ja] = auxi;
                    }
                }
            }

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }
            }
            y = mayor;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < mayor)
                {
                    mayor = vector[i];
                }
            }
            xa = mayor;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i - 1];
                }
            }
            z = mayor;
            Console.Write("valor mas alto, penultimo mas alto y el menor: ");
            Console.Write("{" + y + "," + z + "," + xa + "}");
            return vector;

        }

    }
}

