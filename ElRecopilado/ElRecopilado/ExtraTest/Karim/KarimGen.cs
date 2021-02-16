using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Karim
{
    class KarimGen
    {
        public void HacerMagiaConChar()
        {
            Console.WriteLine("Hola");
            char c;

            for (int i = 32; i < 255; i++)
            {
                Console.WriteLine($"el numero es {i}: y el simbolo es {(char)i}");
            }
        }
    }
}
