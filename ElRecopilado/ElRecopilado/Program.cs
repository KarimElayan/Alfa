using ElRecopilado.EnClase;
using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuClase();
            //MenuTarea();
            TryCatchClase x = new TryCatchClase();
            x.HacerMagia();

        }
        private static void MenuTarea()
        {           
        }
        private static void MenuClase()
        {
            int opc = 4;
            //String texto = "Prueba de colores";
            String texto = "Listas de Dinos";
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
                case 4:
                    Listas lista = new Listas();
                    lista.HacerMagia();
                    Cola cola = new Cola();
                    cola.HacerMagia();
                    Pila pila = new Pila();
                    pila.HacerMagia();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }
        }
    }
}
