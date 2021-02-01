using System;
using System.Collections.Generic;

namespace ElRecopilado.EnClase
{
    class Pila
    {
        public void HacerMagia()
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            Console.WriteLine("Mostrar Pila");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPop '{0}'", numbers.Pop());
            Console.WriteLine("Ver el siguiente en pila: {0}", numbers.Peek());
            Console.WriteLine("Pop '{0}'", numbers.Pop());
            Console.WriteLine("Mostrar Pila\r\n");
            Console.WriteLine("Mostrar Pila despues de pops");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
