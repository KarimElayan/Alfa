using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EnClase
{
    public static class Util
    {
        public static void ImprimirArreglo(int[] array)
        {
            Console.Write("[");
            foreach (int item in array)
            {                
                Console.Write($" {item} ");
                //Console.Write(" " + item + " ");
                //Console.Write(" {0} ", item);                
            }
            Console.Write("]");
        }
    }

    public class UtilNotStatic
    {
        public void ImprimirArreglo(int[] array)
        {
            Console.Write("[");
            foreach (int item in array)
            {
                Console.Write($" {item} ");
                //Console.Write(" " + item + " ");
                //Console.Write(" {0} ", item);                
            }
            Console.Write("]");
        }
    }
}
