using System;

namespace ElRecopilado.Tarea
{
    class Practica5
    {
        static void Main(string[] args)
        {
            int indiceFila, indiceCol, tamFilasCol;
            Console.WriteLine("Matriz De usuario");
            Console.WriteLine("Favor de usar un rango entre el 2 y el 100 para usar la matriz");
            Console.WriteLine("y");
            Console.WriteLine("Tambien usar un rango de numeros entre el -50 y el 50 para usar el programa");

            Console.WriteLine("¿Cuantas Filas y Columnas tendra tu matriz?");
            tamFilasCol = Convert.ToInt32(Console.ReadLine());


            int[,] matrizUsuario = new int[tamFilasCol, tamFilasCol];

            if (tamFilasCol >= 2 && tamFilasCol <= 100)
            {

                for (indiceFila = 0; indiceFila < tamFilasCol; indiceFila++)
                {
                    for (indiceCol = 0; indiceCol < tamFilasCol; indiceCol++)
                    {
                        Console.Write("Ingresa el dato del indice [" + indiceFila + "," + indiceCol + "]: ");
                        matrizUsuario[indiceFila, indiceCol] = Convert.ToInt32(Console.ReadLine());
                         
                    }
                }


                Console.WriteLine("Los Datos que ingresaste son: ");
                for (indiceFila = 0; indiceFila < tamFilasCol; indiceFila++)
                {
                    for (indiceCol = 0; indiceCol < tamFilasCol; indiceCol++)
                    {
                        Console.Write(matrizUsuario[indiceFila, indiceCol] +"," + " ");

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Numero Fuera de Rango. Solo Rangos del 2 al 100. Vuelve a Iniciar el programa.");
            };

            

        }
    }
}
