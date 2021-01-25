using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ELIJE UN PROGRAMA:");
            Console.WriteLine("1) HOLA MUNDO");
            Console.WriteLine("2) GENERADOR DE MATRICES ALEATORIAS");
            String texto;
            texto = Console.ReadLine();
            Console.Clear();

            switch (texto)
            {
                case "1":
                    HolaMundo holaMundoObj = new HolaMundo();
                    holaMundoObj.HacerMagia();
                    break;
                case "2":
                    Practica5 practica5 = new Practica5();
                    practica5.GenerarMatriz(0);
                    break;
                default:
                    Console.WriteLine("OPCION INVALIDA");
                    Console.WriteLine("ADIOS");
                    break;
            }
        }
    }
}
