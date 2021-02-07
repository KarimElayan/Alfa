using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x, y;
            int opc = 0;
            float division, multiplicacion, suma, resta,d1,d2;
            do
            {
                Console.WriteLine("  CALCULADORA");
                Console.WriteLine(".....MENU.....");
                Console.WriteLine("Ingresa un valor numerico: ");
                Console.WriteLine("1) SUMA");
                Console.WriteLine("2) RESTA");
                Console.WriteLine("3) MULTIPLICACION");
                Console.WriteLine("4) DIVISION");
                Console.WriteLine("5) RAIZ CUADRADA");


                opc = Convert.ToUInt16(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("SUMA");
                        Console.WriteLine("Ingrese el primer valor: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        suma = x + y;
                        Console.WriteLine("La suma es: " + suma);
                        break;

                    case 2:
                        Console.WriteLine("RESTA");
                        Console.WriteLine("Ingrese el primer valor: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        resta = x - y;
                        Console.WriteLine("La resta es: " + resta);
                        break;

                    case 3:
                        Console.WriteLine("MULTIPLICACION");
                        Console.WriteLine("Ingrese el primer valor: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        multiplicacion = x * y;
                        Console.WriteLine("La multiplicacion es: " + multiplicacion);
                        break;

                    case 4:
                        Console.WriteLine("DIVISION");
                        Console.WriteLine("Ingrese el primer valor: ");
                        d1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        d2 = Convert.ToInt32(Console.ReadLine());
                        division = d1 / d2;
                        Console.WriteLine("La division es: " + division);
                        break;

                    case 5:
                        Console.WriteLine("RAIZ CUADRADA");
                        Console.WriteLine("Ingrese el primer valor: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        double raiz1 = Math.Sqrt(x);
                        Console.WriteLine("La raiz cuadrada de " + x + " es: " + raiz1);
                        break;


                }
                Console.WriteLine("Ingrese un valor valido ");

            } while (opc > 5 || opc < 1);
        }
    }
}
