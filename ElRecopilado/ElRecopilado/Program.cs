using ElRecopilado.EnClase;
using ElRecopilado.ExtraTest.Karim;
using ElRecopilado.ExtraTest.Francisco;  //Yo lo coloque
using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] Array = new int[2,5];
            Array[0,0] = 2;
            Array[0,1] = 7;
            Array[0,2] = 7;
            Array[0,3] = 2;
            Array[0,4] = 3;
            Array[1, 0] = 2;
            Array[1, 1] = 7;
            Array[1, 2] = 7;
            Array[1, 3] = 2;
            Array[1, 4] = 3;

            Ejercicio7Examen prueba = new Ejercicio7Examen();
            prueba.Extra(Array);
           foreach (int c in Array)
            {
                Console.WriteLine(c);
            }
            
            //KarimGen obj = new KarimGen();    yo comente
            //obj.HacerMagiaConChar();          yo comente
          
        }
        
    }
}
