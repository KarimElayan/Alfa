using System;

namespace Tarea
{
    class Práctica_5
    {
        class Matriz
        {

            public int[,] Generador(int tamaño)
            {
                int[,] matrizgenerada = new int[tamaño, tamaño];
                Random random = new Random();
                Console.WriteLine("Matriz Generada :)");
                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        matrizgenerada[i, j] = random.Next(-50, 50);
                        Console.Write(matrizgenerada[i, j] + "   ");

                    }
                    Console.WriteLine();

                }





                return matrizgenerada;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el tamaño de la matriz 'Cuadrada'");
            String texto;
            texto = Console.ReadLine();
            int Tamaño = Int32.Parse(texto);
            Matriz Mt = new Matriz();
            Mt.Generador(Tamaño);


        }
    }
}





