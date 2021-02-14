using System;

namespace Examen_Mendoza_Morales_Angel_Vicente
{
    class Examen
    {
        static void Main(string[] args)
        {

            int[] lista = { 1, 3, 5, 5 };
            bool repetidos = false;
            for (var x = 0; x < lista.Length; x++)
            {
                int a = lista[x];
                int c = x + 1;

                for (int y = c; y < lista.Length; y++)
                {
                    int b = lista[y];
                    if (a == b)
                    {
                        repetidos = true;
                        //mensaje
                        System.Console.WriteLine("-------------------");
                        System.Console.WriteLine("*****verdadero*****");
                        System.Console.WriteLine("-------------------");
                    }
                }
            }
            if (repetidos == false)
            {
                //mensaje
                System.Console.WriteLine("---------------");
                System.Console.WriteLine("*****falso*****");
                System.Console.WriteLine("---------------");
            }
        }
        //------------------------- EJERCICIO 2 -------------------------------------------
        public void Ejercicio2()
        {
                    int val = 10;

        for (int i = 0; i < val; i++)

        {

            Console.WriteLine(new String(' ', val-i-1) + new String('*', i+i+1));

        }

        Console.ReadLine();
        }
        //------------------------- EJERCICIO 3 -------------------------------------------
        public void Ejercicio3()
        {
            int n = 123; 
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        //------------------------- EJERCICIO 4 -------------------------------------------
        public bool Ejercicio4(int R1, int CR1, int R2, int CR2)
        {
            bool V = false;
            if (R1 <= 0 || R1 >= 9 || CR1 <= 0 || CR1 >= 9 || R2 <= 0 || R2 >= 9 || CR2 <= 0 || CR2 >= 9)
            {
                return false;
            }

            int IN1 = R1 - 1;
            int CN1 = R1 - 1;
            int DE1 = R1 - 1;
            int CD1 = CR1 - 1;
            int[,] Tablero = new int[8, 8];
            Tablero[R1 - 1, CR1 - 1] = 1;
            Tablero[R2 - 1, CR2 - 1] = 2;

            for (int x = 0; x < 8; x++)
            {
                if (Tablero[x, CR1 - 1] == 2)
                {
                    return V = true;
                }
                if (Tablero[R1 - 1, x] == 2)
                {
                    return V = true;
                }
            }


            for (int x = 0; x < 8; x++)
            {

                if (Tablero[DE1, CD1] == 2)
                {
                    return V = true;
                }
                DE1--;
                CD1--;

                if (DE1 == -1 || CD1 == -1)
                {
                    break;
                }
            }
            for (int x = 0; x < 8; x++)
            {

                if (Tablero[IN1, CN1] == 2)
                {
                    return V = true;
                }
                IN1++;
                CN1++;
                if (IN1 == 8 || CN1 == 8)
                {
                    break;
                }
            }


            IN1 = R1 - 1;
            CN1 = CR1 - 1;
            DE1 = R1 - 1;
            CD1 = CR1 - 1;


            for (int x = 0; x < 8; x++)
            {

                if (Tablero[DE1, CN1] == 2)
                {

                    return V = true;
                }
                DE1--;
                CN1++;
                if (DE1 == -1 || CN1 == 8)
                {
                    break;
                }
            }
            for (int x = 0; x < 8; x++)
            {

                if (Tablero[IN1, CD1] == 2)
                {
                    return V = true;
                }
                IN1++;
                CD1--;
                if (CD1 == -1 || IN1 == 8)
                {
                    break;
                }
            }


            return V;
        }
        //------------------------- EJERCICIO 5 -------------------------------------------
        public void Ejercicio5()
        {

            string cadena = "";

            Console.Write("Ingrese Numero :");
            int n = int.Parse(Console.ReadLine());
            string x = Convert.ToString(n);

            Console.WriteLine("Introduce una palabra  : ");
            String palabra = Console.ReadLine();
            if (esPalindroma(palabra)) Console.WriteLine("Es palíndroma");
            else Console.WriteLine("NO es palíndroma");
            do
            {
                int r = n % 10;
                cadena = string.Concat(cadena, r);
                n = n / 10;

            } while (n != 0);

            if (cadena == x)
                Console.Write("Es palindromo ");
            else
                Console.Write("No es palindromo ");
            Console.Read();
        }

        static Boolean esPalindroma(String cadena)
        {

            if (cadena.Length < 2) return true;
            if (cadena[0] == cadena[cadena.Length - 1]) return esPalindroma(cadena.Substring(1, cadena.Length - 2));
            return false;
        }
        //------------------------- EJERCICIO 6 -------------------------------------------
        public void Ejercicio6()
        {
            int[] valor = { 4, 5, 16, 223, 19, 20, 78, 75 };

            Array.Sort(valor);

            int maximo = valor[valor.Length - 1];
            int minimo = valor[0];
            int intrmedio = valor[valor.Length - 3];


            Console.WriteLine("mayor: " + maximo);
            Console.WriteLine("intermedio: " + intrmedio);
            Console.WriteLine("menor: " + minimo);
        }
    }
    
}
