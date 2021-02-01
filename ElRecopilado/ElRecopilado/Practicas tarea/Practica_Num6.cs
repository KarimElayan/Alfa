using System;

namespace ElRecopilado.Tarea
{
    public class Practica6   
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int SUMIzq;
            //int SUMDer;  //variable para sumar la linea derecha 
            // int Resta; //variable para restar la linea izquierda y derecha de la matriz 
           // int C = 0;
            
            Console.WriteLine("******************************************");
            Console.WriteLine("      Matriz de usuario de 3 x 3          ");
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Ingresa el dato del indice [" + c + "," + f + "]: ");
                    matriz [f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Los Datos que ingresaste son: ");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(matriz [f, c] + "," + " " );
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            SUMIzq = 0;
            for (int f = 0; f < 3; f++)
            {
                SUMIzq = SUMIzq +  matriz[f, f];
            }
            Console.WriteLine("La suma de la diagonal izquierda es  :" + SUMIzq);
            Console.WriteLine();

            //En esta parte quice sumar la linea de la matriz en la derecha pero no me compilaba y me daba error en la suma no se a que se deba
            // lo intente pero ni me funciono
             //SUMDer = 0;
             //C = 3;
             //for (int c = 1; c <= 3; c++)
             //{
               //SUMDer = SUMDer + matriz [c, C ];
               //C = C - 1;
              //}
             //Console.WriteLine("La suma de la diagonal derecha es  :" + SUMDer);
             //Resta = SUMIzq - SUMDer;
            //Console.WriteLine("La resta de las dos diagonales (izquierda y derecha) es: " + Resta);



        }
           
    }
}
