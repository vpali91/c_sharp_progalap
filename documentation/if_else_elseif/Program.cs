using System;

namespace IfElseElif
{
    class Program
    {
        static void Main(string[] args)
        {
            //if(feltétel){} törzsén belüli utasítás csak akkor fut le, ha igaz a kondíció
            //else akkor fut le, ha a feltételünknél hamis kondíció valósul meg "minden más esetben"
            int age = 20;
            if (age>=18) 
            {
                Console.WriteLine("Felnőtt");
            }
            else
            {
                Console.WriteLine("Fiatalkorú");
            }

            // Ternális operátor: (feltétel) ? parancs Igaz esetén : parancs Hamis esetén;
            Console.WriteLine((age >= 18) ? "Felnőtt" : "Fiatalkorú");

            //else if(feltétel) törzsén belüli parancs csak akkor fut le, ha az előző feltételünk nem volt igaz és else if kondíciója igaz
            // Ha az if, else if, else törzsén belül csak egy sor parancs van, akkor elhagyhatjuk a {} zárójeleket
            int number = 15;
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (number % 3 == 0)
                Console.WriteLine("Fizz");
            else if (number % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine("Not Fizz or Buzz or FizzBuzz");
        }
    }
}
