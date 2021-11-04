using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var verem = new Stack<char>();
            var be = "VEREM RULEZ";

            Console.WriteLine("Verembe írás: {0}", be);

            foreach (var chr in be)
            {
                verem.Push(chr);
            }

            Console.WriteLine("Veremből kiolvasás:");

            while (verem.Count > 0)
            {
                var karakter = verem.Pop();
                Console.Write(karakter);
            }
            Console.WriteLine();

        }
    }
}
