using System;

namespace practica_9
{
    class Program
    {
        static void Main(string[] args)
        {
			string ax;
			string bx;
			string cadena1;
			string cadena2;
			string cadena3;
			string cadena4;
			string cadena5;
			string cadena6;
			string f;
			string k;
			string la;
			string s;
			int size;
			int size1;
			string zw;
			// primer appellido
			Console.WriteLine(" ingresar tu primer apellido");
			ax = Console.ReadLine();
			size1 = ax.Length;
			cadena1 = ax.Substring(0, 2);
			// segundo appellido
			Console.WriteLine(" ingrear sengundo appellido");
			bx = Console.ReadLine();
			size = bx.Length;
			cadena2 = bx.Substring(0, 2);
			// primer nombre
			Console.WriteLine(" ingrear primer nombre");
			la = Console.ReadLine();
			size = la.Length;
			cadena3 = la.Substring(-1, 1--1);
			// ingresar segundo nombre
			Console.WriteLine(" ingrear tu segundo nombre");
			zw = Console.ReadLine();
			size = zw.Length;
			cadena4 = zw.Substring(-1, 2--1);
			// fecha de nacimiento 
			Console.WriteLine(" ingrear fecha de nacimiento año/mes/dia");
			k = Console.ReadLine();
			size = k.Length;
			cadena5 = k.Substring(2, 8 - 2);
			// definir el tipo de sexo
			Console.WriteLine("sexo M o H");
			s = Console.ReadLine();
			// ingreasar tu estado 
			Console.WriteLine(" ingrear tu estado");
			f = Console.ReadLine();
			size = f.Length;
			cadena6 = f.Substring(-1, 2--1);
			Console.WriteLine(" imprimir curp:    " + (cadena1 + cadena2 + cadena3 + cadena4 + cadena5 + cadena6));
		}

	}

}
     