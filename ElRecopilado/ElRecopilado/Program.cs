using ElRecopilado.Tarea;
using ElRecopilado.Examen;
using System;

namespace ElRecopilado
{
    class Program 
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            int op;

            Console.WriteLine("====MENU DE PROGRAMAS EXAMEN====");
            Console.WriteLine("1) IndexOfCapitals");
            Console.WriteLine("2) PrimeSerieAlfa");
            Console.WriteLine("3) LetrasPorNumeros");
            Console.WriteLine("4) Cifrar");
            Console.WriteLine("5) Descifrar");

            Console.WriteLine();
            Console.Write("SELECCIONE UN NUMERO: ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (op)
            {
                case 1:
                    Examen.Examen.IndexOfCapitals("");
                    break;
                case 2:
                    Examen.Examen.PrimeSerieAlfa(0);
                    break;
                case 3:
                    Examen.Examen.LetrasPorNumeros("");
                    break;
                case 4:
                    Examen.Examen.Cifrar("", 0);
                    break;
                case 5:
                    Examen.Examen.Descifrar("", 0);
                    break;
                default:
                    Console.WriteLine("INGRESO UN NUMERO ERRONEO...");
                    break;
            }
        }
    }
}
