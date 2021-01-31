using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElRecopilado.Tarea
{
    class agenda2
    {

        public string nombre;
        public string apellido;
        public string numeroTelefonico;            //se dejo con cadena de caracteres ya que no se hara un calculo matematico con el.
        public string correoElectronico;
        public bool FavoritoSiNo = false;
        public int identificador;


        public agenda2(string nombre, string apellido, string numeroTelefonico, string correoElectronico, bool FavoritoSiNo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroTelefonico = numeroTelefonico;
            this.correoElectronico = correoElectronico;
            this.FavoritoSiNo = FavoritoSiNo;

        }


    }
    class Practica_8
    {
        private List<agenda2> ContactosAgregados = new List<agenda2>();
        public void agregarContactos(agenda2 contacto)
        {
            contacto.identificador = ContactosAgregados.Count;
            ContactosAgregados.Add(contacto);
        }
        public void EditarContactos()
        {
            Console.WriteLine("-----EDITAR CONTACTO-----");
            Console.WriteLine("Coloca el identificador del contacto a editar: ");
            int indice = Convert.ToInt16(Console.ReadLine());
            for (int y = 0; y < ContactosAgregados.Count; y++)
            {
                if (y == indice)
                {
                    Console.WriteLine("CONTACTO ENCONTRADO");
                    Console.WriteLine("Ingresa el nombre del contacto: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el apellido del contacto: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingresa el numero del contacto: ");
                    string numero = Console.ReadLine();
                    Console.WriteLine("Ingresa el correo del contacto: ");
                    string correo = Console.ReadLine();
                    Console.WriteLine("Es un contacto favorito?");
                    string EsFavorito = Console.ReadLine();
                    if (EsFavorito == "si" || EsFavorito == "Si")
                    {
                        bool favorito = true;
                        ContactosAgregados.RemoveAt(indice);
                        agenda2 contactoAgregar = new agenda2(nombre, apellido, numero, correo, favorito);
                        ContactosAgregados.Insert(indice, contactoAgregar);
                        seleccionar();
                    }
                    if (EsFavorito != "si" || EsFavorito != "Si")
                    {
                        bool favorito = false;
                        ContactosAgregados.RemoveAt(indice);
                        agenda2 contactoAgregar = new agenda2(nombre, apellido, numero, correo, favorito);
                        ContactosAgregados.Insert(indice, contactoAgregar);
                        seleccionar();
                    }

                    seleccionar();
                    break;
                }

            }
            Console.WriteLine("NO EXISTE EL CONTACTO");
            seleccionar();
        }

        public void ImprimirListaFavoritosYnoFavoritos()
        {
            IEnumerable<agenda2> ContactosOrdenados = ContactosAgregados.OrderBy(x => x.FavoritoSiNo).Reverse();
            foreach (agenda2 ImpresionDeContactos in ContactosOrdenados)
            {
                Console.WriteLine(" -NOMBRE-: " + ImpresionDeContactos.nombre + "   -APELLIDO-: " + ImpresionDeContactos.apellido + "   -NUMERO TELEFONICO-: " + ImpresionDeContactos.numeroTelefonico + "    -CORREO ELECTRONICO-: " + ImpresionDeContactos.correoElectronico + "   -FAVORITO-: " + ImpresionDeContactos.FavoritoSiNo + "   -IDENTIFICADOR-: " + ImpresionDeContactos.identificador);
            }
            seleccionar();
        }
        public void EliminarContactos()
        {
            Console.WriteLine("-----ELIMINAR CONTACTO-----");
            Console.WriteLine("Coloca el identificador del contacto a borrar: ");
            int x = Convert.ToInt16(Console.ReadLine());
            for (int y = 0; y < ContactosAgregados.Count; y++)
            {
                if (y == x)
                {
                    ContactosAgregados.RemoveAt(x);
                    Console.WriteLine("Contacto Eliminado...");
                    seleccionar();
                    break;
                }

            }
            Console.WriteLine("NO EXISTE EL CONTACTO");
            seleccionar();

        }
        public void BuscarContacto()
        {
            Console.WriteLine("----BUSCAR UN CONTACTO----");
            Console.WriteLine("Coloca el identificardor del contacto a buscar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < ContactosAgregados.Count; x++)
            {
                if (indice == x)
                {
                    Console.WriteLine("-CONTACTO ENCONTRADO-");
                    agenda2 contactoImpresion = ContactosAgregados[indice];
                    Console.WriteLine(" -NOMBRE-: " + contactoImpresion.nombre + "   -APELLIDO-: " + contactoImpresion.apellido + "   -NUMERO TELEFONICO-: " + contactoImpresion.numeroTelefonico + "    -CORREO ELECTRONICO-: " + contactoImpresion.correoElectronico + "   -FAVORITO-: " + contactoImpresion.FavoritoSiNo + "   -IDENTIFICADOR-: " + contactoImpresion.identificador);

                    seleccionar();
                    break;
                }

            }
            Console.WriteLine("EL CONTACTO NO SE ENCUENTRA EN LA LISTA...");
            seleccionar();
        }
        public void OrdenarElementosAscendente()
        {
            IEnumerable<agenda2> ContactosOrdenados = ContactosAgregados.OrderBy(x => x.nombre);
            foreach (agenda2 ImpresionDeContactos in ContactosOrdenados)
            {
                Console.WriteLine(" -NOMBRE-: " + ImpresionDeContactos.nombre + "   -APELLIDO-: " + ImpresionDeContactos.apellido + "   -NUMERO TELEFONICO-: " + ImpresionDeContactos.numeroTelefonico + "    -CORREO ELECTRONICO-: " + ImpresionDeContactos.correoElectronico + "   -FAVORITO-: " + ImpresionDeContactos.FavoritoSiNo + "   -IDENTIFICADOR-: " + ImpresionDeContactos.identificador);
            }
            seleccionar();
        }
        public void OrdenarElementosDescendente()
        {
            IEnumerable<agenda2> ContactosOrdenados = ContactosAgregados.OrderBy(x => x.nombre).Reverse();
            foreach (agenda2 ImpresionDeContactos in ContactosOrdenados)
            {
                Console.WriteLine(" -NOMBRE-: " + ImpresionDeContactos.nombre + "   -APELLIDO-: " + ImpresionDeContactos.apellido + "   -NUMERO TELEFONICO-: " + ImpresionDeContactos.numeroTelefonico + "    -CORREO ELECTRONICO-: " + ImpresionDeContactos.correoElectronico + "   -FAVORITO-: " + ImpresionDeContactos.FavoritoSiNo + "   -IDENTIFICADOR-: " + ImpresionDeContactos.identificador);
            }
            seleccionar();
        }
        public void MostrarAgenda()
        {
            Console.WriteLine("----CONTACTOS AGREGADOS----");
            foreach (agenda2 ImpresionDeContactos in ContactosAgregados)
            {
                Console.WriteLine(" -NOMBRE-: " + ImpresionDeContactos.nombre + "   -APELLIDO-: " + ImpresionDeContactos.apellido + "   -NUMERO TELEFONICO-: " + ImpresionDeContactos.numeroTelefonico + "    -CORREO ELECTRONICO-: " + ImpresionDeContactos.correoElectronico + "   -FAVORITO-: " + ImpresionDeContactos.FavoritoSiNo + "   -IDENTIFICADOR-: " + ImpresionDeContactos.identificador);
            }
            Console.WriteLine();
            seleccionar();
        }
        public void DatosDeIngreso()
        {
            Console.WriteLine("INGRESO DE UN CONTACTO");
            Console.WriteLine("Ingresa el nombre del contacto: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido del contacto: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresa el numero del contacto: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Ingresa el correo del contacto: ");
            string correo = Console.ReadLine();
            Console.WriteLine("Es un contacto favorito?");
            string EsFavorito = Console.ReadLine();
            if (EsFavorito == "si" || EsFavorito == "Si")
            {
                bool favorito = true;
                agenda2 contactoAgregar = new agenda2(nombre, apellido, numero, correo, favorito);
                agregarContactos(contactoAgregar);
                seleccionar();
            }
            if (EsFavorito != "si" || EsFavorito != "Si")
            {
                bool favorito = false;
                agenda2 contactoAgregar = new agenda2(nombre, apellido, numero, correo, favorito);
                agregarContactos(contactoAgregar);
                seleccionar();
            }

            // agenda2 contactoAgregar = new agenda2(nombre, apellido, numero, correo, favorito);
            //  Console.WriteLine();
            //  agregarContactos(contactoAgregar);
            // seleccionar();
        }
        public void seleccionar()
        {
            byte Seleccion;
            Console.WriteLine("==========INGRESA UNA OPCION==========");
            Console.WriteLine("Agregar un contacto: 1");
            Console.WriteLine("Ver agenda: 2");
            Console.WriteLine("Eliminar contacto: 3");
            Console.WriteLine("Buscar contacto: 4");
            Console.WriteLine("Editar contacto: 5");
            Console.WriteLine("Imprimir contactos de forma ordenada(Ascendente): 6");
            Console.WriteLine("Imprimir contactos de forma ordenada(Descendente): 7");
            Console.WriteLine("Imprimir lista(Favoritos): 8");
            Console.WriteLine("Imprimir lista(Favoritos/No favoritos): 9");
            Console.WriteLine("Salir: 10");
            Seleccion = Convert.ToByte(Console.ReadLine());

            switch (Seleccion)
            {
                case 1:
                    DatosDeIngreso();
                    break;
                case 2:
                    MostrarAgenda();
                    break;
                case 3:
                    EliminarContactos();
                    break;
                case 4:
                    BuscarContacto();
                    break;
                case 5:
                    EditarContactos();
                    break;
                case 6:
                    OrdenarElementosAscendente();
                    break;
                case 7:
                    OrdenarElementosDescendente();
                    break;
                case 8:
                    ContactosFavoritos();
                    break;
                case 9:
                    ImprimirListaFavoritosYnoFavoritos();
                    break;
                case 10:
                    Console.WriteLine("Saliendo...");
                    break;



            }
        }
        public void ContactosFavoritos()
        {
            for (int x = 0; x < ContactosAgregados.Count; x++)
            {
                agenda2 ImpresionDeContactos = ContactosAgregados[x];
                if (ImpresionDeContactos.FavoritoSiNo == true)
                {
                    agenda2 ImprimeContactos = ImpresionDeContactos;
                    Console.WriteLine(" -NOMBRE-: " + ImprimeContactos.nombre + "   -APELLIDO-: " + ImprimeContactos.apellido + "   -NUMERO TELEFONICO-: " + ImprimeContactos.numeroTelefonico + "    -CORREO ELECTRONICO-: " + ImprimeContactos.correoElectronico + "   -FAVORITO-: " + ImprimeContactos.FavoritoSiNo + "   -IDENTIFICADOR-: " + ImprimeContactos.identificador);

                }
            }
            seleccionar();  // se coloco el menu de esta manera ya que me agregaba contactos de mas...
        }
    }

}
    

