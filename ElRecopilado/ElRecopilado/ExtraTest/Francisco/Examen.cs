using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Examen
    {
        public bool Ejercicio1(int[] x)
        {
            Ejercicio1Examen v = new Ejercicio1Examen();
            return v.Ejercicio1(x);
        }
        public void Ejercicio2(int x)
        {
            Ejercicio2Examen v = new Ejercicio2Examen();
            v.Ejercicio2(x);
        }
        public float Ejercicio3(float x)
        {
            Ejercicio3Examen v = new Ejercicio3Examen();
           return v.Ejercicio3(x);
        }
        public bool Ejercicio4(int FilaReina1, int ColumnaReina1, int FilaReina2, int ColumnaReina2)
        {
            Ejercicio4Examen v = new Ejercicio4Examen();
          return  v.Ejercicio4(FilaReina1, ColumnaReina1, FilaReina2, ColumnaReina2);
        }
        public bool Ejercicio5(string x)
        {
            Ejercicio5Examen v = new Ejercicio5Examen();
           return v.Ejercicio5(x);
        }
        public int[] Ejercicio6(int[] x)
        {
            Ejercicio6Examen v = new Ejercicio6Examen();
           return v.Ejercicio6(x);
        }
        public void Ejercicio7()
        {

        }

    }
}
