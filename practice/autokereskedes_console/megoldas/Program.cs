using System;

namespace AutoKereskedes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("e - Eladás / m - Műszaki");
                string valasztas = Console.ReadLine();
                if(valasztas == "e" || valasztas == "E")
                {
                    Console.WriteLine("Új tulajdonos: ");
                    string ujTulaj = Console.ReadLine();

                    Console.WriteLine("Rendszám: ");
                    string rendszam = Console.ReadLine();

                    Console.WriteLine("Előleg: ");
                    string input_eloleg = Console.ReadLine();

                    Management manage = new Management(ujTulaj, rendszam, input_eloleg);
                    repeat = false;
                }
                else if(valasztas == "m" || valasztas == "M")
                {
                    Console.WriteLine("Rendszám: ");
                    string rendszam2 = Console.ReadLine();

                    Console.WriteLine("megujit/ervenytelenit");
                    string muszaki = Console.ReadLine();

                    Management manage2 = new Management(rendszam2,muszaki);
                    repeat = false;
                }
                else { 
                    Console.WriteLine("Rossz input");
                    Console.Clear();
                }

                Console.WriteLine("Szeretnél-e műveleteket végrehajtani (i/n)?");
                string kilep = Console.ReadLine();

                if(kilep == "i")
                {
                    repeat = true;
                    Console.Clear();
                }
                else
                {
                    repeat=false;
                }
            }
        }
    }
}
