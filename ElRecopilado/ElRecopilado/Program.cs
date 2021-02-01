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
            int opc ;
           
            //String texto = "Prueba de colores";
            String texto = "Listas de Dinos";
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
                    Cola cola = new Cola();---------
                    cola.HacerMagia();
                    Pila pila = new Pila();
                    pila.HacerMagia();
                    break;
                case 5:
                    EXAMEN.Examen.IndexOfCapitals("");

                    break;
                case 6:
                    EXAMEN.Examen.PrimeSerieAlfa(0);
                    break;
                case 7:
                    EXAMEN.Examen.LetrasPorNumeros(" ");
                    break;
                case 8:
                    EXAMEN.Examen.Cifrar("",0);
                    break;
                


                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }
        }
    }
}
