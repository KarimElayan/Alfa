using System;

namespace ElRecopilado.Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica 7 ");
            int indiceFila, indiceCol, tamFilas, tamCol ;
            Console.WriteLine("¿Cuantas Filas tendra tu matriz?");
            tamFilas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuantas Columnas tendra tu matriz?");
            tamCol = Convert.ToInt32(Console.ReadLine());

            int[,] matrizUsuario = new int[tamFilas, tamCol];
            for (indiceFila = 0; indiceFila < tamFilas; indiceFila++)
            {
                for (indiceCol = 0; indiceCol < tamCol; indiceCol++)
                {
                    Console.Write("Ingresa el dato del indice [" + indiceFila + "," + indiceCol + "]: ");
                    matrizUsuario[indiceFila, indiceCol] = Convert.ToInt32(Console.ReadLine());
                    while (matrizUsuario[indiceFila, indiceCol] <= -1 || matrizUsuario[indiceFila, indiceCol] >= 2)
                    {
                        Console.WriteLine("Introdujiste un valor diferente");
                        Console.WriteLine("Vuelve a introducir el valor:");
                        Console.WriteLine("presiona un numero para continuar");
                        matrizUsuario[indiceFila, indiceCol] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("Los Datos que ingresaste son: ");
            for (indiceFila = 0; indiceFila < tamFilas; indiceFila++)
            {
                for (indiceCol = 0; indiceCol < tamCol; indiceCol++)
                {
                    Console.Write(matrizUsuario[indiceFila, indiceCol] + "    ");

                }
                Console.WriteLine();
            }
        }
    }
}
