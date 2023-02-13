using System;

namespace Jatek // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tippek = 5;
            Random rnd = new Random();
            int random_num = rnd.Next(1,11);
            bool game_on = true;
            int tet = 12000;

            while (game_on)
            {
                Console.WriteLine("Adj meg egy számot 1-10!");
                string input_num = Console.ReadLine();
                int guess = 0;
                if(int.TryParse(input_num, out guess))
                {
                    if(guess >0 && guess < 11)
                    {
                        if (tet < 10000)
                        {
                            if(guess == random_num)
                            {
                                Console.WriteLine("Nyertél!");
                                game_on = false;
                            }
                            else
                            {
                                Console.WriteLine("Nem talált!");
                                tippek--;
                            }
                        }
                        else
                        {
                            if (guess == random_num)
                            {
                                Console.WriteLine("Nem talált! ;-)");
                                while(guess == random_num)
                                {
                                    random_num = rnd.Next(1,11);
                                }
                                tippek--;
                            }
                            else
                            {
                                Console.WriteLine("Nem talált!");
                                tippek--;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nincs tartományban");
                        tippek--;
                    }
                }
                else
                {
                    Console.WriteLine("Nem szám!");
                    tippek--;
                }
               if(tippek == 0)
                {
                    game_on = false;
                    Console.WriteLine("Vesztettél! A random szám: " + random_num);
                } 
            }
        }
    }
}
