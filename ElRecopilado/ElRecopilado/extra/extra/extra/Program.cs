using System;
using System.Linq;

namespace extra
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] A = { 1, 2, 2, 3, 9, 5, 5, 4 };

                int[] B = (from item in A
                           group item by item into g
                           where g.Count() == 1
                           select g.Key).ToArray();

                Console.WriteLine(string.Join(",", B.ToList()));
            }
        }
    }
}
   
