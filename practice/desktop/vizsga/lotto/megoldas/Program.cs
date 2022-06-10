using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat
            List<Sorsolas> sorsolas_list = new List<Sorsolas>();
            string[] lines = File.ReadAllLines("lotto.txt");

            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Sorsolas sorsolas_object = new Sorsolas(values[0], values[1], values[2], values[3], values[4], values[5]);
                sorsolas_list.Add(sorsolas_object);
            }
            /*
            foreach (var item in sorsolas_list)
            {
                Console.WriteLine($"Hét: {item.het}, {item.szam1},  {item.szam2}, {item.szam3}, {item.szam4}, {item.szam5}");
            }
            */

            //2. Feladat
            Console.WriteLine("Hét: ");
            string bekert_szam = Console.ReadLine();

            foreach (var item in sorsolas_list)
            {
                if(item.het == bekert_szam)
                {
                    Console.WriteLine($"{item.het}, {item.szam1},  {item.szam2}, {item.szam3}, {item.szam4}, {item.szam5}");
                }
            }

            //3. Feladat
            List<Szam> szamok = new List<Szam>();

            int db = 0;
            for (int i = 1; i < 91; i++)
            {
                foreach (var item in sorsolas_list)
                {
                    if (i == item.szam1 || i == item.szam2 || i == item.szam3 || i == item.szam4 || i == item.szam5)
                    {
                        db++;
                    }
                }
                Szam szam_object = new Szam(i, db);
                szamok.Add(szam_object);
                db = 0;
            }

            int max = int.MinValue;
            int legnagyobb_eredmeny = 0;
            foreach (var item in szamok)
            {
                if(max < item.db)
                {
                    max = item.db;
                    legnagyobb_eredmeny = item.szam;
                }
            }
            Console.WriteLine($"A legtöbbször kihúzott: {legnagyobb_eredmeny}: {max}");

            //4. Feladat
            int sum = 0;
            foreach (var item in szamok)
            {
                if(item.szam % 2 == 0)
                {
                    sum += item.db;
                }
            }
            Console.WriteLine("Páros szám db: "+sum);

            //5-6. Feladat:
            int szam23 = 0;
            int szam64 = 0;
            foreach (var item in szamok)
            {
                if(item.szam == 23)
                {
                    szam23 = item.db;
                }
            }
            Console.WriteLine("23: " + szam23);

            foreach (var item in szamok)
            {
                if (item.szam == 64)
                {
                    szam64 = item.db;
                }
            }
            Console.WriteLine("64: " + szam64);


            // 7. Feladat:
            foreach (var item in szamok)
            {
                Console.WriteLine($"{item.szam}: {item.db}");
            }
           
        }
    }
}
