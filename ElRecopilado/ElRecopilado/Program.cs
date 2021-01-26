using ElRecopilado.Tarea;

using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            Practica5 ImprimirPractica5 = new Practica5();
            ImprimirPractica5.Practica5Imprimir();
            Practica6 ImprimirPractica6 = new Practica6();
            ImprimirPractica6.Practica6Imprimir();



            Console.WriteLine("Elije opcion:");
            Console.WriteLine("1 Hola Mundo");
            String texto;
            texto = Console.ReadLine();

            switch (texto)
            {
                case "1":
                    HolaMundo holaMundoObj = new HolaMundo();
                    holaMundoObj.HacerMagia();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }



        }
    }
}
