using System;
using System.Collections.Generic;
using System.Linq;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = {0,1,3,2,4,5, 8, 6, 7};
            List<int> num_list = new List<int>();
            foreach (var item in tomb)
            {
                num_list.Add(item);
            }
            int x = 5, y = 10, z = 1;

            // Math.Max(), 2 értéket tudunk összehasonlítani, melyik a több
            Console.WriteLine($"Math.Max(x,y): {Math.Max(x, y)}");
            //Tömbben és listában is csak 2 elemet lehet összehasonlítani
            Console.WriteLine($"Tömb, Math.Max(tomb[0], tomb[1]): {Math.Max(tomb[0],tomb[1])}");
            
            //Maximum keresés listában
            num_list.Sort();
            num_list.Reverse();
            Console.WriteLine($"Lista max sort() és reverse() után, num_list[0]: {num_list[0]}");

            //Maximumkeresés tömbben, vagy listában(a példában tömb van, de listanévvel helyettesítve is működik):
            int max = 0;
            foreach (var item in tomb)
            {
                if (max < item)
                    max = item;
            }
            Console.WriteLine($"A tömb maximum értéke: {max}");

            //Math.Min(), 2 értéket tudunk összehasonlítani
            Console.WriteLine($"Math.Min(x,y): {Math.Min(x, y)}");
            //Tömbben és listában is csak 2 elemet lehet összehasonlítani
            Console.WriteLine($"Tömb, Math.Min(tomb[0], tomb[1]): {Math.Min(tomb[0], tomb[1])}");

            //Minimum keresés listában
            num_list.Sort();
            Console.WriteLine($"Lista max, sort() után num_list[0]: {num_list[0]}");

            //Minimumkeresés tömbben, vagy listában(a példában tömb van, de listanévvel helyettesítve is működik):
            int min = int.MaxValue;
            Console.WriteLine(min);
            foreach (var item in tomb)
            {
                if (min > item)
                    min = item;
            }
            Console.WriteLine($"A tömb minimum értéke: {min}");

            //Math.Pow(szám, hatványérték) - Hatványozás, példa: 3 a negyediken
            Console.WriteLine($"Math.Pow(3,4): {Math.Pow(3,4)}");

            //Math.Sqrt(szám) - Négyzetgyök pl: 64 négyzetgyöke
            Console.WriteLine($"Math.Sqrt(): {Math.Sqrt(64)}");

            //Abszolútérték, ha egyszerűen csak a negatív számokat szeretnéd pozitívra alakítani if nélkül
            Console.WriteLine($"Abszolút érték(-5): {Math.Abs(-5)}");

            //PI ()
            Console.WriteLine($"Math.PI: {Math.PI}");

            //Math.Round(kerekítendő szám, hány tizedesjelre) - Kerekítés. Ha a 2. értéket nem adjuk meg, akkor egész számra
            Console.WriteLine($"Math.Round(Math.PI):{Math.Round(Math.PI,2)}");

            //Mégis hogyan tudnánk a tömbben megkeresni a max/min értéket egyszerűen... 
            //LINQ methods
            Console.WriteLine($"LINQ, tomb.Max():{tomb.Max()}");
            Console.WriteLine($"LINQ, tomb.Min():{tomb.Min()}");
            Console.WriteLine($"LINQ, tomb.Sum():{tomb.Sum()}");
            Console.WriteLine($"LINQ, tomb.Average():{tomb.Average()}");

            //Array Methods a tömböknél
            Array.Sort(tomb);
            Array.Reverse(tomb);
            Array.ForEach(tomb, n => Console.WriteLine(n));
            Array.BinarySearch(tomb, 5);
        }
    }
}
