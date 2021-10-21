using System;

namespace Allatok
{

    class Program
    {
        static void Main(string[] args)
        {
            Kutya bundas = new Kutya(5, 15);
            Console.WriteLine("Kutya előtte, életkor: " + bundas.eletkor + ", testsúly: " + bundas.testsuly + ", életben van: " + bundas.eletbenVanE);
            bundas.Eszik();
            bundas.Oregszik();
            Console.WriteLine(bundas.Ugat());
            Console.WriteLine("Kutya utána, életkor: " + bundas.eletkor + ", testsúly: " + bundas.testsuly + ", életben van: " + bundas.eletbenVanE);

            Macska cirmi = new Macska(2, 7);
            Console.WriteLine("Macska előtte, életkor: " + cirmi.eletkor + ", testsúly: " + cirmi.testsuly + ", életben van: " + cirmi.eletbenVanE);
            cirmi.Eszik();
            cirmi.Oregszik();
            Console.WriteLine(cirmi.Karmol());
            cirmi.kill();
            Console.WriteLine("Macska utána, életkor: " + cirmi.eletkor + ", testsúly: " + cirmi.testsuly + ", életben van: " + cirmi.eletbenVanE);
        }
    }
}
