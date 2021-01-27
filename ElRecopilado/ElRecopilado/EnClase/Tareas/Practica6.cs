using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EnClase.Tareas
{
    class Practica6 : Practica5
    {
        public new void HacerMagia()
        {
            Console.WriteLine("Hola desde 6");
            string[,] x;
            x = GenerarMatriz(4);

            SopaDeLetras sobj = new SopaDeLetras();
            sobj.printArreglos(x);
        }


    }
}
