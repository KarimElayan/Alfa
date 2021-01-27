using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elije opcion:");
            Console.WriteLine("1 Hola Mundo");
            Console.WriteLine("2 practica 5");
            String texto;
            texto = Console.ReadLine();

            switch (texto)
            {
                case "1":
                    HolaMundo holaMundoObj = new HolaMundo();
                    holaMundoObj.HacerMagia();
                    break;
                case "2":
                    Practica5 practica5Obj = new Practica5();
                    practica5Obj.generar_matriz(0);
                    break;



                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }


        }
    }
}
