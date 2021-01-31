using System;


namespace Practica_9_Angela_Belem_Jiménez_Ramales
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

