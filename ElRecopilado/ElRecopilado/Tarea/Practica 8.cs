using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de contactos:");
            int personas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            String[] Nombre = new string[personas];
            String[] Apellido = new string[personas];
            String[] Numero = new string[personas];
            String[] Correo = new string[personas];
            String[] Favorito = new string[personas];
            int cont = 1;
            for (int x = 0; x < personas; x++)
            {
                Console.WriteLine("Ingrese el nombre del contacto" + cont);
                Nombre[x] = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del contacto" + cont);
                Apellido[x] = Console.ReadLine();
                Console.WriteLine("Ingrese el numero del contacto" + cont);
                Numero[x] = Console.ReadLine();
                Console.WriteLine("Ingrese el correo del contacto" + cont);
                Correo[x] = Console.ReadLine();
                Console.WriteLine("Ingrese si el contacto es favorito" + cont);
                Favorito[x] = Console.ReadLine();
                cont++;
                Console.Clear();

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            Console.Write("NOMBRE");
            Console.SetCursorPosition(0, 0);
            Console.Write("APELLIDO");
            Console.SetCursorPosition(20, 0);
            Console.Write("NUMERO");
            Console.SetCursorPosition(40, 0);
            Console.Write("CORREO");
            Console.SetCursorPosition(80, 0);
            Console.Write("FAVORITO");

            for (int x = 0; x < personas; x++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 1 + x);
                Console.WriteLine(Nombre[x]);
                Console.SetCursorPosition(0, 1 + x);
                Console.WriteLine(Apellido[x]);
                Console.SetCursorPosition(20, 1 + x);
                Console.WriteLine(Numero[x]);
                Console.SetCursorPosition(40, 1 + x);
                Console.WriteLine(Correo[x]);
                Console.SetCursorPosition(80, 1 + x);
                Console.WriteLine(Favorito[x]);
            }
            Console.ReadLine();
        }
    }
}