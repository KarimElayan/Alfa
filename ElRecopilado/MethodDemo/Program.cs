using System;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           Console.WriteLine("Hello World!");
            //int x = 5;    
           int x = ObtenerNumeroRandomEntre0y100();

           Console.WriteLine($"<<<<<<<<{x}: {EsPar(x)}>>>>>>>>>");

        }

        private static int ObtenerNumeroRandomEntre0y100()
        {
            return 8;
        }

        private static bool EsPar(int x)
        {
            return (x % 2 == 0);// ? $"ES UN PAR" : $"NO ES UN PAR";
        }
    }
    
}
