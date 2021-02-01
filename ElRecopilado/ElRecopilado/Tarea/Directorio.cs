using System;
using System.IO;

public class agenda

{

    public static void Main()

    {

        try

        {
            long a = 0;
            string[] contacto = new string[1000];
            string operador, telefono, x, y, z, buscar, correo;

            int i = 0;

            StreamWriter dat;
            StreamReader inicio;
            if (!File.Exists("datos.dat"))
            {
                dat = File.CreateText("datos.dat");
                dat.Close();
            }
            else
            {

                inicio = File.OpenText("datos.dat");

                do
                {

                    y = inicio.ReadLine();
                    contacto[i] = y;
                    i += 1;
                    a += 1;

                }
                while (y != null);
                inicio.Close();
                a -= 1;
                Console.WriteLine(a);
            }
            do
            {
                Console.Clear();
                Console.WriteLine("AGENDA TELEFÓNICA");
                Console.WriteLine("1) Agregar un nuevo contacto.");
                Console.WriteLine("2) Buscar un contacto. ");
                Console.WriteLine("3) Mostrar lista de contactos.");
                Console.WriteLine("4) Borrar contacto.");
                Console.Write("Seleccione una opcion.");
                operador = Convert.ToString(Console.ReadLine());


                if (operador == "1")
                {
                    StreamWriter datos;
                    Console.Clear();
                    Console.Write("Nuevo contacto:");
                    Console.Write("Ingrese el nombre: ");
                    x = Console.ReadLine();
                    Console.WriteLine("Introduce el numero telefonico");
                    telefono = Console.ReadLine();
                    Console.Write("Ingrese el correo electronico: ");
                    correo = Console.ReadLine();

                    contacto[a] = "Nombre: " + x + "  Telefono:  " + telefono + "  Correo: " + correo;

                    datos = File.AppendText("datos.dat");
                    datos.WriteLine(contacto[a]);
                    datos.Close();
                    a += 1;
                }

                if (operador == "2")
                {
                    Console.Clear();
                    Console.Write("Introduce el nombre del contacto que buscas: ");
                    buscar = Console.ReadLine();

                    for (int m = 0; m < a; m++)
                        if (contacto[m].IndexOf(buscar) >= 0)
                            Console.WriteLine(contacto[m]);
                    Console.ReadLine();
                }

                if (operador == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Lista de contactos....");
                    StreamReader dato;
                    dato = File.OpenText("datos.dat");

                    do
                    {

                        y = dato.ReadLine();
                        if (y != null)
                            Console.WriteLine(y);

                    }
                    while (y != null);
                    dato.Close();
                    Console.WriteLine("");
                    Console.ReadLine();


                }
                if (operador == "4")
                {
                    StreamWriter datos;
                    Console.Clear();
                    Console.WriteLine("Introduce el nombre del contacto a eliminar");
                    buscar = Convert.ToString(Console.ReadLine());

                    for (int j = 0; j < a; j++)
                    {
                        if (contacto[j].IndexOf(buscar) >= 0)
                        {

                            for (int s = j; s < a - 1; s++)
                                contacto[s] = contacto[s + 1];
                            a--;
                            contacto[a] = "";
                        }
                    }
                    z = Console.ReadLine();
                    dat = File.CreateText("datos.dat");
                    dat.Close();

                    for (int o = 0; o < a; o++)
                    {
                        datos = File.AppendText("datos.dat");
                        datos.WriteLine(contacto[o]);
                        datos.Close();

                    }
                    Console.WriteLine("Contacto eliminado correctamente");
                    Console.ReadLine();

                }

            }
            while (operador != "6");
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
        Console.ReadLine();

    }

}
