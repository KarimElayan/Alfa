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

        }
        private static void MenuClase()
        {
            int opc;

            //String texto = "Prueba de colores";
            //String texto = "Listas de Dinos";
            Console.WriteLine("Elige una opcion:");
            Console.WriteLine("1.- Hola mundo:");
            Console.WriteLine("2.- Usar colores:");
            Console.WriteLine("3.- Sopa de letras :");
            Console.WriteLine("4.- Listas:");
            Console.WriteLine("5.- IndexOfCapitals:");
            Console.WriteLine("6.- PrimeSerieAlfa:");
            Console.WriteLine("7.- LetrasPorNumeros:");
            Console.WriteLine("8.- Cifrar:");
            opc = int.Parse(Console.ReadLine());

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
                case 4:
                    Listas lista = new Listas();
                    lista.HacerMagia();
                    Cola cola = new Cola();
                     cola.HacerMagia();
                    Pila pila = new Pila();
                    pila.HacerMagia();
                    break;
                case 5:
                    Examen.Examen.IndexOfCapitals("");

                    break;
                case 6:
                    Examen.Examen.PrimeSerieAlfa(0);
                    break;
                case 7:
                    Examen.Examen.LetrasPorNumeros(" ");
                    break;
                case 8:
                    Examen.Examen.Cifrar("", 0);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }
        }
    }
}