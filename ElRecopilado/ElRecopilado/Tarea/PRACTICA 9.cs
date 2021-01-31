using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTICA_9
{
    class Class1;

        public static void Main(string[] args)
    {
        string año, noombre, ap, am, estado, genero, o, np, no, nw;
        int dia, mes;
        {


            Console.WriteLine("CURP");
            noombre = Console.ReadLine();
            noombre = noombre.ToUpper();
            Console.WriteLine("INGRESAR EL NOMBRE DE LA PRIMER PILA");
            np = Console.ReadLine();
            np = np.ToUpper();
            Console.WriteLine(".");
            Console.WriteLine("INGRESAR  APELLIDO PATERNO");
            ap = Console.ReadLine();
            ap = ap.ToUpper();
            Console.WriteLine("INGRESAR LA PRIMER VOLCAL DEL APELLIDO PARTERNO");
            o = Console.ReadLine();
            o = o.ToUpper();
            Console.WriteLine("INGRESAR LA PRIMER CONSONANTE DEL APELLIDO PATERNO");
            no = Console.ReadLine();
            no = no.ToUpper();
            Console.WriteLine(".");


            Console.WriteLine("INGRESAR EL APELLIDO MATERNO");
            am = Console.ReadLine();
            am = am.ToUpper();
            Console.WriteLine("INGRESAR LA PRIMERA CONSONANTE DEL APELLIDO MATERNO");
            nw = Console.ReadLine();
            nw = nw.ToUpper();
            Console.WriteLine(".");

            do
            {
                Console.WriteLine("INGRESAR LA FECHA DE NACIMIENTO");
                Console.WriteLine("DIA");

            } while (dia> 31 || dia< 04);

            do
            {
                Console.WriteLine("MES");
                mes = Convert.ToInt32(Console.ReadLine());


            } while (mes > 12 || mes < 10);

            do
            {
                Console.WriteLine("INGRESAR EL ESTADO DE NACIMIENTO");
                estado = Console.ReadLine();
                estado = estado.ToUpper();
                if (estado == "CHIAPAS")
                    estado = "CS";
                if (estado == "BAJA CALIFORNIA SUR")
                    estado = "BS";
                if (estado == "COAHUILA")
                    estado = "CL";
                if (estado == "BAJA CALIFORNIA")
                    estado = "BC";
                if (estado == "AGUASCALIENTES")
                    estado = "AS";
                if (estado == "DISTRITO FEDERAL")
                    estado = "DF";
                if (estado == "GUANAJUATO")
                    estado = "GT";
                if (estado == "HIDALGO")
                    estado = "HG";
                if (estado == "MEXICO")
                    estado = "MEX";
                if (estado == "MORELOS")
                    estado = "MS";
                if (estado == "NUEVO LEON")
                    estado = "NL";
                if (estado == "PUEBLA")
                    estado = "PL";
                if (estado == "QUINTA ROO")
                    estado = "QR";
                if (estado == "SINALOA")
                    estado = "SL";
                if (estado == "TABASCO")
                    estado = "TBC";
                if (estado == "TLAXCALA")
                    estado = "TL";
                if (estado == "YUCATAN")
                    estado = "YT";
            }


