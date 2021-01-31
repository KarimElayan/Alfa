using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    public class HolaMundo
    {
        public void HacerMagia()
        {
            Console.WriteLine("Gustavo Adolfo Bautista Hernandez");
            Console.WriteLine("matricula: cuh51197227");
            Console.WriteLine("Correo: cuh51197227@cuh.mx");
           
        }
    }
}
{
    class practica5y6
{
    static void Main(string[] args)
    {
        int F = 0;
        int C = 0;
        int N = 0;
        int SUMP = 0;
        int SUMS = 0;
        string linea;
        Console.Write("TAMAÑO DE LA MATRIZ:");
        Random rnd = new Random();
        linea = Console.ReadLine();
        N = int.Parse(linea);
        int[,] MAT = new int[N + 1, N + 1];
        for (F = 1; F <= N; F++)
        {
            for (C = 1; C <= N; C++)
            {
                MAT[F, C] = rnd.Next(0, 9);
                Console.SetCursorPosition(C * 4, F + 1);
                Console.Write(MAT[F, C]);
            }
        }
        SUMP = 0;
        for (F = 1; F <= N; F++)
        {
            SUMP = SUMP + MAT[F, F];
        }
        SUMS = 0;
        C = N;
        for (F = 1; F <= N; F++)
        {
            SUMS = SUMS + MAT[F, C];
            C = C - 1;
        }

        Console.WriteLine();
        Console.WriteLine("SUMA DIAGONAL PRINCIPAL ES :" + SUMP);
        Console.WriteLine("SUMA DIAGONAL SECUNDARIA ES:" + SUMS);
        Console.Write("Pulse una Tecla:");
        Console.ReadLine();
    }
}
}
