using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Ejercicio2Examen
    {
        public void Ejercicio2(int Parametro)
        {
            int Recorrido=Parametro;
            for (int x=1; x <= Parametro; x++)
            {
                Recorrido--;
                for (int z = 1; z <= Recorrido; z++)
                {
                    Console.Write(" ");
                }
                for (int y=1; y <= x; y++)
                {
                   Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
