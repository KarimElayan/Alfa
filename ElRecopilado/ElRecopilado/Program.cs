
<<<<<<< HEAD
using ElRecopilado.Tarea;

=======
﻿using ElRecopilado.EnClase;
using ElRecopilado.EnClase.Tareas;
using ElRecopilado.Tarea;
>>>>>>> origin/main
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Practica5 ImprimirPractica5 = new Practica5();
            ImprimirPractica5.Practica5Imprimir();
            Practica6 ImprimirPractica6 = new Practica6();
            ImprimirPractica6.Practica6Imprimir();



            Console.WriteLine("Elije opcion:");
            Console.WriteLine("1 Hola Mundo");
            String texto;
            texto = Console.ReadLine();
=======
            MenuClase();
            //MenuTarea();
>>>>>>> origin/main


        }
        private static void MenuTarea()
        {
        }
        private static void MenuClase()
        {

            int opc = 7;
            //String texto = "Prueba de colores";
            String texto = "Static vs Not Static";
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
                case 5:
                    Practica5 prac5 = new Practica5();
                    prac5.HacerMagia();
                    break;
                case 6:
                    Practica6 prac6 = new Practica6();
                    prac6.HacerMagia();
                    break;
                case 7:
                    int[] xxx = new int[] { 9, 8, 5, 4, 8, 7, 4, 1, 2, 3, 6 };
                    Console.WriteLine("NOT Static\r\n");
                    UtilNotStatic utilNotStaticObj = new UtilNotStatic();
                    utilNotStaticObj.ImprimirArreglo(xxx);
                    Console.WriteLine("Static\r\n");
                    Util.ImprimirArreglo(xxx);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("Adios");
                    break;
            }
<<<<<<< HEAD
<<<<<<< HEAD



=======
>>>>>>> origin/main
=======
            
>>>>>>> origin/Elayan_Karim
        }
    }
}
