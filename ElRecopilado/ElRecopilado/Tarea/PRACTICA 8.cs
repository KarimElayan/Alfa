using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTICA_8
{
    class Class1Agenda;
    {
        public static void Main();
    }
       try
}
    {

    //Declaramos las variables

    long contador = 0;
    String[] datoscontactos = new string[10000];
    String operandor, nombre, apellido, correo, telefono, linea, siono, buscar;

    int j = 0, i = 0;
    streamWriter dat;//Declaramos la clase para escribir la araible de los archivos.
    StreamReader inico;
    if ("datos.dat"))//si existe el archivo.
    {
        dat = File.Createtext("datoss.dat");// El archivo se crea..
        dat.Close();// El archivo se cierra.
    }
    else
    {
        inico= File.OpenText("datos");
        do
        {
            linea = inico.ReadLine();
            datoscontactos[i] = linea;
            //console.WriteLine("{0}",datosdeloscontactos[j]);
            j += 1;
            contador += 1;
        }
        inico.Close();
        contador -= 1;
        Console.WriteLine("{0}", contador);
    }
    //Ejecutar
    do
    {
        //Limpiamos termina
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("*");
        Console.WriteLine("DIRECTORIO TELEFONICO");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1.-AGREGAR NUEVO CONTACTO");
        Console.WriteLine();
        Console.WriteLine("2.-MOSTRAR LISTA DE CONTACTOS");
        Console.WriteLine();
        Console.WriteLine("3.-BUSCAR EL CONTACTO");
        Console.WriteLine();
        Console.WriteLine("4.-BORRAR CONTACTO");
        Console.WriteLine();
        Console.WriteLine("5.-BORRAR TODA LA LISTA");
        Console.WriteLine();
        Console.WriteLine("6.-CONTACTO FAVORITO");
        Console.WriteLine();
        Console.WriteLine("7.-SALIR");
        Console.WriteLine();
        operandor = Convert.ToString(Console.ReadLine());
        if (operandor == "1") ;
        {
            Console.Clear();
            Console.WriteLine("INTRODUCE EL NOMBRE DEL CONTACTO");
            nombre = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("INTRODUCE EL APELLIDO DEL CONTACTO");
            apellido = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("INTRODUCE EL TELEFONO DEL CONTACTO DE {0}", nombre);
            telefono = Convert.ToString(Console.ReadLine());
            Console.WriteLine("INTRODUCE EL NOMBRE DEL CONTACTO");
            correo = Convert.ToString(Console.ReadLine());
            Console.Clear();
            datoscontactos[contador] = nombre + "." + apellido + "." + telefono + "." + correo;

            //Lista de contactos completa
        }
        { }




