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


            Examen prueba = new  Examen();
            int[] c = new int[200];
            c[0] = 7;
            c[1] = 7;
            c[2] = 8;
            c[3] =100;
            c[4] = 20;
            c[5] = 70;
            c[6] = 75;
            c[7] = 75;
            c[8] = 8;
            c[10] = 5;

          int[] cf= prueba.Ejercicio6(c);
            foreach (int c4 in cf)
            {
                Console.WriteLine(c4);
            }
          //  KarimGen obj = new KarimGen();    Yo comente
         //   obj.HacerMagiaConChar();          Yo comente
          
        }
        
    }
}
