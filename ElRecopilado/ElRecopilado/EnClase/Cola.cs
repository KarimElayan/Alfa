using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EnClase
{
    class Cola
    {
        public void HacerMagia()
        {
            Queue<string> my_queue = new Queue<string>();

            my_queue.Enqueue("rojo");
            my_queue.Enqueue("azul");
            my_queue.Enqueue("negro");
            my_queue.Enqueue("amarillo");

            Console.WriteLine("Total de elements en my_queue: {0}", my_queue.Count);

            Console.WriteLine("REMOVER el primer elemento de la cola: {0}", my_queue.Dequeue());


            Console.WriteLine("Total de elements en my_queue: {0}",my_queue.Count);

            Console.WriteLine("VER el primer elemento de la cola: {0}",my_queue.Peek());

            Console.WriteLine("Total de elements en my_queue: {0}", my_queue.Count);
        }
    }
}
