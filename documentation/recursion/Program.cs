using System;

namespace Recursion
{
    class Program
    {
        // Rekurzív metódus, csak azért static, mert a futtatható osztályban van
        static long Faktorialis(int n)
        {
            if (n <= 1) {
             return 1; 
            }
            //önmagát hívja meg a metódus, ettől rekurzív
            return n * Faktorialis(n - 1);
        }

        static void Main(string[] args)
        {
            //Iteratív megoldás for ciklussal, ez nem rekurzió
            int faktorialis = 1;
            for (int i = 1; i < 5; i++)
            {
                faktorialis *= i;
            }
            Console.WriteLine(faktorialis);


            var fakt = Faktorialis(4);
            Console.WriteLine(fakt);

        }
    }
}
