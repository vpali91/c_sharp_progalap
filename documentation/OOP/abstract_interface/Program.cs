using System;

namespace AbstractInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya bundas = new Kutya(9, 5, 3, "Sanyi");
            Console.WriteLine($"{bundas.gazda}, {bundas.eletkor}, {bundas.testsuly}, {bundas.szorosseg}, {bundas.eletbenVanE}");
            bundas.Eszik();
            Console.WriteLine($"{bundas.gazda}, {bundas.eletkor}, {bundas.testsuly}, {bundas.szorosseg}, {bundas.eletbenVanE}");
            bundas.HangotAdKi();
            bundas.Uszik();
        }
    }
}
