using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program : Practica6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ELIJE UN PROGRAMA:");
            Console.WriteLine("1) HOLA MUNDO");
            Console.WriteLine("2) GENERADOR DE MATRICES ALEATORIAS");
            Console.WriteLine("3) SUMA DE DIAGONALES DE UNA MATRIZ");
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
                case "3":
                    Practica6 practica6 = new Practica6();
                    practica6.MatrizPractica5();
                    break;
                default:
                    Console.WriteLine("OPCION INVALIDA");
                    Console.WriteLine("ADIOS");
                    break;
            }
        }
    }
}
