using System;

namespace Tarea
{
    class Práctica_6
    {
        class Matriz
        {

            public int[,] Generador(int tamaño)
            {
                int[,] matrizgenerada = new int[tamaño, tamaño];
                Random random = new Random();
                int suma_izq = 0, suma_der = 0;
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
                Console.Write("Diagonal Izq");
                for (int i = 0; i < tamaño; i++)
                {
                    Console.Write(" " + matrizgenerada[i, i]);
                    suma_izq = suma_izq + matrizgenerada[i, i];
                }
                int z = tamaño - 1;
                Console.WriteLine();
                Console.Write("Diagonal Dere");
                for (int i = 0; i < tamaño; i++)
                {

                    suma_der = suma_der + matrizgenerada[i, z];
                    Console.Write(" " + matrizgenerada[i, z]);
                    z = tamaño - 1;

                }
                Console.WriteLine("");
                Console.WriteLine("Suma Izq " + suma_izq);
                Console.WriteLine("Suma der " + suma_der);
                int dif = suma_izq - suma_der;
                int abs;
                if (dif < 0)
                {
                    abs = -dif;
                }
                else
                {
                    abs = dif;
                }
                Console.WriteLine("dif " + abs);
                Console.WriteLine("Suma " + (suma_der + suma_izq));

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

