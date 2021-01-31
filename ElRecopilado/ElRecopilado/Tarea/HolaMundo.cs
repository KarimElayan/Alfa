using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    public class HolaMundo
    {
        public void HacerMagia()
        {
            Console.WriteLine("Gustavo Adolfo Bautista Hernandez");
            Console.WriteLine("matricula: cuh51197227");
            Console.WriteLine("Correo: cuh51197227@cuh.mx");
           
        }
    }
}
{
    class practica5y6
{
    static void Main(string[] args)
    {
        int F = 0;
        int C = 0;
        int N = 0;
        int SUMP = 0;
        int SUMS = 0;
        string linea;
        Console.Write("TAMAÑO DE LA MATRIZ:");
        Random rnd = new Random();
        linea = Console.ReadLine();
        N = int.Parse(linea);
        int[,] MAT = new int[N + 1, N + 1];
        for (F = 1; F <= N; F++)
        {
            for (C = 1; C <= N; C++)
            {
                MAT[F, C] = rnd.Next(0, 9);
                Console.SetCursorPosition(C * 4, F + 1);
                Console.Write(MAT[F, C]);
            }
        }
        SUMP = 0;
        for (F = 1; F <= N; F++)
        {
            SUMP = SUMP + MAT[F, F];
        }
        SUMS = 0;
        C = N;
        for (F = 1; F <= N; F++)
        {
            SUMS = SUMS + MAT[F, C];
            C = C - 1;
        }

        Console.WriteLine();
        Console.WriteLine("SUMA DIAGONAL PRINCIPAL ES :" + SUMP);
        Console.WriteLine("SUMA DIAGONAL SECUNDARIA ES:" + SUMS);
        Console.Write("Pulse una Tecla:");
        Console.ReadLine();
    }

}

public class agenda

{




    public static void Main()

    {

        try

        {

            // Declaramos las variables



            long contador = 0;

            string[] datoscontactos = new string[10000];
            string operador, nombre, tlfn, linea, siono, buscar;

            int i = 0, e = 0;


            StreamWriter dat;// Declaramos la Clase para escribir en archivos en la variable datos..
            StreamReader inicio;
            if (!File.Exists("datos.dat"))// Si no existe..
            {
                dat = File.CreateText("datos.dat");// Creamos el archivo..
                dat.Close();// Cerramos el archivo..
            }
            else
            {

                inicio = File.OpenText("datos.dat");

                do
                {

                    linea = inicio.ReadLine();
                    datoscontactos[i] = linea;
                    //Console.WriteLine("{0}",datoscontactos[i]);
                    i += 1;
                    contador += 1;

                }
                while (linea != null);
                inicio.Close();
                contador -= 1;
                Console.WriteLine("{0}", contador);
                //Console.ReadLine();



            }

            // Ejecutar mientras no se pulse 3
            do
            {
                // Limiamos terminal
                Console.Clear();
                Console.WriteLine("***********************************************************");
                Console.WriteLine("*                   AGENDA TELEFÓNICA                     *");
                Console.WriteLine("***********************************************************");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1.- Agregar un nuevo contacto.");
                Console.WriteLine();
                Console.WriteLine("2.- Mostrar lista de contactos.");
                Console.WriteLine();
                Console.WriteLine("3.- Buscar un contacto.");
                Console.WriteLine();
                Console.WriteLine("4.- Borrar contacto.");
                Console.WriteLine();
                Console.WriteLine("5.- Borrar lista completa.");
                Console.WriteLine();
                Console.WriteLine("6.- Salir.");
                Console.WriteLine();


                operador = Convert.ToString(Console.ReadLine());

                if (operador == "1")
                {
                    StreamWriter datos;// Declaramos la Clase para escribir en archivos en la variable datos..

                    Console.Clear();

                    Console.WriteLine("Introduce el nombre del contacto");
                    nombre = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Introduce el telefono de {0}", nombre);
                    tlfn = Convert.ToString(Console.ReadLine());

                    datoscontactos[contador] = nombre + " " + tlfn;

                    datos = File.AppendText("datos.dat");// Abrimos para editar el archivo..
                    datos.WriteLine("{0} ", datoscontactos[contador]);
                    datos.Close();

                    contador += 1;


                }


                // Mostrar lista Completa de contactos

                if (operador == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Lista de contactos....");
                    Console.WriteLine("");
                    StreamReader rdatos;// Declaramos la clase para leer archivos   
                    rdatos = File.OpenText("datos.dat");// Abrimos el archivo para leer linea por linea.

                    do
                    {

                        linea = rdatos.ReadLine();
                        if (linea != null)
                            Console.WriteLine(linea);

                    }
                    while (linea != null);
                    rdatos.Close();
                    Console.WriteLine("");
                    Console.ReadLine();
                }

                // Buscar un contacto..

                if (operador == "3")
                {

                    Console.Clear();
                    Console.WriteLine("Introduce un nombre o número de telefono a buscar");
                    buscar = Convert.ToString(Console.ReadLine());

                    for (i = 0; i < contador; i++)

                        if (datoscontactos[i].IndexOf(buscar) >= 0)
                            Console.WriteLine("{0}", datoscontactos[i]);


                    Console.ReadLine();

                }


                // Eliminar un contacto..
                if (operador == "4")
                {
                    StreamWriter datoss;// Declaramos la Clase para escribir en archivos en la variable datos..

                    Console.Clear();
                    Console.WriteLine("Introduce un nombre o número de telefono Eliminar");
                    buscar = Convert.ToString(Console.ReadLine());

                    for (i = 0; i < contador; i++)
                    {
                        if (datoscontactos[i].IndexOf(buscar) >= 0)
                        {
                            int s;
                            for (s = i; s < contador - 1; s++)
                                datoscontactos[s] = datoscontactos[s + 1];
                            contador--;
                            datoscontactos[contador] = "";
                        }
                    }
                    siono = Convert.ToString(Console.ReadLine());
                    dat = File.CreateText("datos.dat");// Creamos el archivo..
                    dat.Close();// Cerramos el archivo..

                    for (e = 0; e < contador; e++)
                    {
                        datoss = File.AppendText("datos.dat");// Abrimos para editar el archivo..
                        datoss.WriteLine("{0} ", datoscontactos[e]);
                        datoss.Close();

                    }
                    Console.WriteLine("Contacto eliminado correctamente");
                    Console.ReadLine();

                }





                // Borrar lista de contactos.
                if (operador == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Se van a eliminar todos los contactos.. desea continuar?  ( [y]=si,[n]=no )");
                    siono = Convert.ToString(Console.ReadLine());
                    if (siono == "y")
                    {
                        dat = File.CreateText("datos.dat");// Creamos el archivo..
                        dat.Close();// Cerramos el archivo..
                        Array.Clear(datoscontactos, 0, datoscontactos.Length);
                        contador = 0;
                    }


                }



            }
            while (operador != "6");
        }
        catch (Exception error)
        {
            Console.WriteLine("{0}", error.Message);
        }
        Console.ReadLine();

    }




namespace Practica_9_Dniel_Igncio_Gomez_Delgdo
{
    class CURP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe las primeras 2 letras de tu apellido paterno");
            String apellidoP = Console.ReadLine();
            Console.WriteLine("escribe la primera letra de tu apellido materno");
            String Apellidom = Console.ReadLine();
            Console.WriteLine("escribe la primer vocal de tu nombre");
            String nombre = Console.ReadLine();
            //Console.WriteLine(apellidoP+ Apellidom + nombre );
            Console.WriteLine("Escribe tu fecha de nacimiento en este ordes año/mes/dia, usando solo numeros, sin caracteres");
            DateTime dt = DateTime.Now;
            string fecha = Console.ReadLine();
            //Console.WriteLine(apellidoP + Apellidom + nombre + fecha);
            Console.WriteLine("Escribe tu genero H/M");
            String genero = Console.ReadLine();
            switch (genero)
            {
                case "M":
                    genero = "M";
                    break;
                case "H":
                    genero = "H";
                    break;
            }
            Console.WriteLine("escribe la tercera letra de tu apellido paterno");
            String apellidoP1 = Console.ReadLine();
            Console.WriteLine("escribe la tercera letra de tu apellido materno");
            String apellidom1 = Console.ReadLine();
            Console.WriteLine("escribe la segunda letra de tu nombre");
            String nombre1 = Console.ReadLine();

            Console.WriteLine("Escribe tu estado de nacimiento");
            string estado = Console.ReadLine();
            switch (estado)
            {
                case "aguascalientes":
                case "AGUASCALIENTES":
                    estado = "AS";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "baja california":
                case "BAJA CALIFORNIA":
                    estado = "BC";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "baja california sur":
                case "BAJA CALIFORNIA SUR":
                    estado = "BS";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "campeche":
                case "CAMPECHE":
                    estado = "CC";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "chiapas":
                case "CHIAPAS":
                    estado = "CS";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "coahuila":
                case "COAHILA":
                    estado = "CL";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "colima":
                case "COLIMA":
                    estado = "CO";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "distrito federal":
                case "DISTRITO FEDERAL":
                    estado = "DF";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "durango":
                case "DURANGO":
                    estado = "DG";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "guanajuato":
                case "GUANAJUATO":
                    estado = "GT";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "guerrero":
                case "GUERRERO":
                    estado = "GR";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "hidalgo":
                case "HIDALGO":
                    estado = "HG";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "jalisco":
                case "JALISCO":
                    estado = "JC";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "mexico":
                case "MEXICO":
                    estado = "MC";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "michoacan":
                case "MICHOACAN":
                    estado = "MN";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "morelos":
                case "MORELOS":
                    estado = "MS";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "nayarit":
                case "NAYARIT":
                    estado = "NT";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "nuevo leon":
                case "NUEVO LEON":
                    estado = "NL";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "oaxaca":
                case "OAXACA":
                    estado = "OC";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "PUEBLA":
                case "puebla":
                    estado = "PL";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "queretaro":
                case "QUERETARO":
                    estado = "QT";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "quintana roo":
                case "QUINTANA ROO":
                    estado = "QR";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "san luis potosi":
                case "SAN LUIS POTOSI":
                    estado = "SP";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "sinaloa":
                case "SINALOA":
                    estado = "SL";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "sonora":
                case "SONORA":
                    estado = "SR";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "tabasco":
                case "TABASCO":
                    estado = "TC";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "tamaulipas":
                case "TAMAULIPAS":
                    estado = "TS";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "tlaxcala":
                case "TLAXCALA":
                    estado = "TL";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "veracruz":
                case "VERACRUZ":
                    estado = "VZ";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "yucatan":
                case "YUCATAN":
                    estado = "YN";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;
                case "zacatecas":
                case "ZACATECAS":
                    estado = "ZS";
                    Console.WriteLine("tu CURP es " + apellidoP + Apellidom + nombre + fecha + genero + estado + apellidoP1 + apellidom1 + nombre1);
                    break;

            }
        }
    }
}    

            }
}
