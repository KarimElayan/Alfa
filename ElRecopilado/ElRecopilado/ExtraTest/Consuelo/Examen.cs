using System;

namespace ElRecopilado.ExtraTest.Consuelo
{
    class Examen
    {
        public static bool Ejercicio1(int[] arreglo)
        {
            bool respuesta = false;
            bool resuelto = false;
            int estado = 0;
            foreach (int item in arreglo)
            {
                if (item != 7)
                {
                    switch (estado)
                    {
                        case 1:
                            resuelto = true;
                            break;
                        case 2:
                            estado = 3;
                            break;
                    }
                }
                else

                {
                    switch (estado)
                    {
                        case 0:
                            estado = 1;
                            break;
                        case 1:
                            estado = 2;
                            respuesta = true;
                            break;
                        case 3:
                            estado = 1;
                            respuesta = false;
                            break;
                    }
                }
                if (resuelto)
                    break;
            }
            Console.WriteLine(respuesta);
            return respuesta;
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
                    for (int a = 0; a < (i*2)-1; a++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("El numero no es valido");
            }
        }
        public float Ejercicio3(float Valor)
        {
            string digitos = Convert.ToString(Valor);
            if (Valor > 0)
            {
                int suma = 0;
                for (int i = 0; i < digitos.Length - 1; i++)
                {
                    if (digitos[i] != '.')
                    {
                        suma += digitos[i] - '0';
                    }
                }
                int p = digitos[digitos.Length - 1] - '0';
                suma = (suma * p);
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
                int p = digitos[digitos.Length - 1] - '0';
                resta = (resta * p);
                Console.WriteLine(resta);
                return Convert.ToSingle(resta);
            }
        }
       public Boolean Ejercicio5(String cadena)
        {
            bool retorno = false;
            int contador;
            contador = cadena.Length;
            if (cadena.Length < 2)
            {
                Console.WriteLine(retorno);
                return retorno;
            }
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == cadena[cadena.Length - contador])
                {
                    i--;
                    retorno = true;
                    Console.WriteLine(retorno);
                    return retorno;
                }
            }

            return Ejercicio5(cadena.Substring(1, cadena.Length - 2));
        }

    }
}
