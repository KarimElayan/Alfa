using System;

namespace ExamenGlobal
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int opc = 0;
            do
            {
                Console.WriteLine(".....EXAMEN.....");
                Console.WriteLine("Menu");
                Console.WriteLine("Ingrese un valor: ");
                Console.WriteLine("1) Ejercicio 1");
                Console.WriteLine("2) Ejercicio 2");
                Console.WriteLine("3) Ejercicio 3");
                Console.WriteLine("4) Ejercicio 4");
                Console.WriteLine("5) Ejercicio 5");
                Console.WriteLine("6) Ejercicio 6");
                opc = Convert.ToUInt16(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        string x;
                        Console.WriteLine("Ingrese un arreglo de enteros: ");
                        x = Console.ReadLine();
                        string cadena = x;
                        char[] delimitador = { ',', ' ' };
                        String[] te = cadena.Split(delimitador);
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
                        break;

                    case 2:
                        Console.Clear();
                        int num;
                        do
                        {
                            Console.Write("Ingrese la altura de la piramide entre 1 y 20: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 1 || num > 20)
                                Console.WriteLine("Ingrese un valor correcto");
                        } while (num < 1 || num > 20);
                        Console.Clear();

                        for (int i = 1; i <= num; i++)
                        {
                            for (j = 0; j < num - i; j++)
                                Console.Write(" ");

                            for (int k = 0; k < (i * 2) - 1; k++)
                                Console.Write("*");

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        int nume = 0;
                        int aux, mul, res;
                        Console.WriteLine("ingresa un valor");
                        string cad = Convert.ToString(Console.ReadLine());
                        if (cad[0] == '-')
                        {
                            cad = cad.Replace("-", "");
                            String[] arreglo = cad.Split('.');
                            aux = int.Parse(arreglo[0]);
                            while (aux > 0)
                            {
                                nume = -nume - aux % 10;
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
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Disculpe, no pude resolverlo.");
                        break;

                    case 5:
                        Console.Clear();
                        string original, reverso, tem;
                        Console.Write("Ingrese una palabra : ");
                        original = Convert.ToString(Console.ReadLine());
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
                        break;

                    case 6:

                        Console.Clear();
                        int[] vector = new int[100];
                        int tam, auxi, mayor = 0, xa, y, z;
                        Console.Write("Cantidad de valores a ingresar :");
                        tam = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        for (int i = 0; i < tam; i++)
                        {
                            Console.Write((i + 1) + " : ");
                            vector[i] = Convert.ToInt32(Console.ReadLine());
                        }


                        for (int i = 0; i < tam; i++)
                        {
                            for (int ja = i + 1; ja < tam; ja++)
                            {
                                if (vector[i] > vector[ja])
                                {
                                    auxi = vector[i];
                                    vector[i] = vector[ja];
                                    vector[ja] = auxi;
                                }
                            }
                        }

                        for (int i = 0; i < tam; i++)
                        {
                            if (vector[i] > mayor)
                                mayor = vector[i];
                        }
                        y = mayor;

                        for (int i = 0; i < tam; i++)
                        {
                            if (vector[i] < mayor)
                                mayor = vector[i];
                        }
                        xa = mayor;

                        for (int i = 0; i < tam; i++)
                        {
                            if (vector[i] > mayor)
                                mayor = vector[i - 1];
                        }
                        z = mayor;
                        Console.Write("Respuesta: ");
                        Console.Write("{" + y + "," + z + "," + xa + "}");
                        break;


                }
            } while (opc > 6 || opc < 1);
        }
    }

}
