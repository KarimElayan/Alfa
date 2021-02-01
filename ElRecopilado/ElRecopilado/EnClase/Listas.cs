using System;
using System.Collections.Generic;

namespace ElRecopilado.EnClase
{
    class Listas
    {
        public void HacerMagia()
        {
            List<string> dinosaurs = new List<string>();

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);
            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            Console.WriteLine("Count: {0}", dinosaurs.Count);



            List<Colores> listaDeColores = new List<Colores>
            {
                new Colores(),
                new Colores(),
                new Colores(5,0.123135f),
                new Colores(6,0.521f),
                new Colores(7,0.522f,false),
                new Colores(9,0.54f,true),
                new Colores(9,0.9f,true),
            };

            //List<Colores> listaDeColores = new List<Colores>();

            //listaDeColores.Add(new Colores() { color = 3, grosor = 0.5f, hasPunta = false });
            //listaDeColores.Add(new Colores() { color = 4, grosor = 0.5f, hasPunta = true });
            //listaDeColores.Add(new Colores() { color = 5, grosor = 0.5f, hasPunta = false });
            //listaDeColores.Add(new Colores() { color = 6, grosor = 0.5f, hasPunta = true });
            //listaDeColores.Add(new Colores() { color = 9, grosor = 0.5f, hasPunta = false });
            //listaDeColores.Add(new Colores() { color = 9, grosor = 0.5f, hasPunta = false });
            //listaDeColores.Add(new Colores() { color = 9, grosor = 0.5f, hasPunta = false });

            foreach (Colores item in listaDeColores)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Count: {0}", listaDeColores.Count);

        }
    }
}
