using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Név:");
            string name = Console.ReadLine();

            Console.WriteLine("A: ");
            string input_a = Console.ReadLine();
            Console.WriteLine("B: ");
            string input_b = Console.ReadLine();
            Console.WriteLine("C: ");
            string input_c = Console.ReadLine();

            float a, b, c;

            if(float.TryParse(input_a, out a) && float.TryParse(input_b, out b)&& float.TryParse(input_c, out c))
            {
                Fajlbair f = new Fajlbair(a, b, c, name);
                f.Printing();
            }
            else
                Console.WriteLine("Számot adj meg!");
        }
    }
}
