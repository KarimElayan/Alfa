using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elije opcion:");
            Console.WriteLine("1. IndexOfCapitals");
            Console.WriteLine("2. PrimeSerieAlfa");
            Console.WriteLine("3. LetrasPorNumeros");
            Console.WriteLine("4. Cifrar");
            Console.WriteLine("5. Descifrar");

            String texto;
            texto = Console.ReadLine();

            switch (texto)
            {
                case "1":
                    Examen.Examen.IndexOfCapitals("");
                    break;
                case "2":
                    Examen.Examen.PrimeSerieAlfa(0);
                    break;
                case "3":
                    Examen.Examen.LetrasPorNumeros("");
                    break;
                case "4":
                    Examen.Examen.Cifrar("", 0);
                    break;
                case "5":
                    Examen.Examen.Descifrar("", 0);
                    break;
                case "6":
                    Examen.Examen.Descifrar("", 0);
                    break;
                case "7":
                    HolaMundo holaMundo = new HolaMundo();
                    holaMundo.HacerMagia();
                    break;
            




            
                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }


        }
    }
}
