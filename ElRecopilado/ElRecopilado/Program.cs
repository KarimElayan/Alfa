using ElRecopilado.EnClase;
using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuClase();
            //MenuTarea();


        }
        private static void MenuTarea()
        {
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
        private static void MenuClase()
        {
            int opc = 3;
            //String texto = "Prueba de colores";
            String texto = "Sopa de letras";
            Console.WriteLine($"Se ejecuta la opc: {opc}) {texto}");

            switch (opc)
            {
                case 1:
                    HolaMundo holaMundoObj = new HolaMundo();
                    holaMundoObj.HacerMagia();
                    break;
                case 2:
                    UsarColores usarColores = new UsarColores();
                    usarColores.HacerMagia();
                    break;
                case 3:
                    SopaDeLetras sopa = new SopaDeLetras();
                    sopa.HacerMagia();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }
        }
    }
}
