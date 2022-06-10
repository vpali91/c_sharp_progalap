using System;

namespace ProgTetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Létrehozzuk azt a tömböt, amivel minden feladatban dolgozni fogunk
            int[] inputtomb = new int[] {1,2,8,6,4,9};

            //Létrehozzuk az osztályból ossz nevű objektumunkat, a zárójelben azt a változót rakjuk bele, amit az adott osztály konstruktorának küldünk át
            Osszegzes ossz = new Osszegzes(inputtomb);
            //meghívjuk az objektumunk metódusát, ami az előző sorban betöltött számokkal dolgozik
            ossz.OsszegzesMethodus();

            Megszamolas megsz = new Megszamolas(inputtomb);
            megsz.MegszamolasMethod();

            Eldontes eldont = new Eldontes(inputtomb);
            eldont.EldontesMethodus();
            eldont.EldontesMethodus2();

            Kivalogatas kivalogat = new Kivalogatas(inputtomb);
            kivalogat.KivalogatMethod();

            Szetvalogatas szetvalogat = new Szetvalogatas(inputtomb);
            szetvalogat.SzetvalogatasMethod();

            Maximum max = new Maximum(inputtomb);
            max.MaxMethod();

            Minimum min = new Minimum(inputtomb);
            min.MinMethod();

        }
    }
}
