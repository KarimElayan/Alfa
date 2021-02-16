using ElRecopilado.EnClase;
using ElRecopilado.ExtraTest.Karim;
using ElRecopilado.ExtraTest.Johan;
using ElRecopilado.Tarea;
using System;

namespace ElRecopilado
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[] {1,2,7,7,8,7 };

            Examen numero7 = new Examen();
            numero7.Ejercicio1(arr);

            Examen piramide = new Examen();
            piramide.Ejercicio2(6);

            Examen SumaDij = new Examen();
            SumaDij.Ejercicio3(-54.2f);

            Examen Palindromo = new Examen();
            Palindromo.Ejercicio5("Ana aNA");
        }
        
    }
}
