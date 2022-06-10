using System;
using System.Collections.Generic;

namespace ForWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iteration statement / iteráció
            //egyszerűen gyorsan for+tab paranccsal tudsz for ciklust generálni
            // i-nek mindig kell kezdőértéket adni, nem kötelező 0 értéket adni neki, szituációfüggő
            //Feltételnek mindig kell lennie a for ciklusban, ennek pedig olyan feltételnek kell lennie, ami valamikor teljesül, különben végtelen ciklus lesz
            //i++/i-- elem is kell bele különben végtelen ciklus marad és jól meg kell választani, hogy növeljük/csökkentjük különben végtelen ciklus lesz

            //esetünkben for ciklusunk 0-ról indul. Minden körben: lefut a kiíratásunk és i értéke 1-el növekszik. Amikor i értéke 4 eléri a 4-et, akkor leáll a for ciklus és folytatódik a programunk a for ciklust követő utasításokkal.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ciklus:{i}. kör, még ebben a körben i++.");
            }

            //Példa: Hány inputot akarsz bekérni?
            Console.WriteLine("Hány String inputot akarsz bekérni?");
            List<string> sztringek = new List<string>();
            string input = Console.ReadLine();

            int inputNumber = int.Parse(input);
            for (int i = 0; i < inputNumber; i++)
            {
                Console.WriteLine($"{i + 1}. Add meg a lista {i}-edik elemét!");
                input = Console.ReadLine();
                sztringek.Add(input);
            }
            for (int i = 0; i < sztringek.Count; i++)
            {
                Console.WriteLine($"{i + 1}. A lista {i}-edik eleme: {sztringek[i]}");
            }

            //fordított for ciklus
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"Visszaszámlálás: {i}");
            }

            //foreach használata, főleg listakiíratáshoz használható, vagy egyszerűbb for ciklussal kiíratható dolgokra is
            // foreach+tab  item: a lista i-edik eleme(itt 0-ról indul mindig, tehát ha 1-ről akarunk indulni, akkor for)
            foreach (var item in sztringek)
            {
                Console.WriteLine($"Foreach: {item}");
            }

            //listába betöltés foreach-el
            List<string> szavak = new List<string>();
            int a = 1;
            foreach (var item in sztringek)
            {
                szavak.Add(a + ". "+item);
                a++;
            }
            foreach (var item in szavak)
            {
                Console.WriteLine(item);
            }

            //Egymásba ágyazott for ciklus
            int[] cimletek = {5,10,20,50};
            int[] kassza = { 5, 5, 5, 10, 20, 20, 20, 50, 50, 5, 5, 5, 10, 20, 20, 20, 50, 50 };
            List<Cimletek> penzSum = new List<Cimletek>();
            int db = 0;
            // a külső for ciklus a címleteketen meg végig
            for (int i = 0; i < cimletek.Length; i++)
            {
                //A belső minden egyes címletnél végigfut a teljes kassszán
                //beágyazott for ciklusban, nem lehet i változó ugyanúgy elnevezve, mint a külsőben, ezért j
                for (int j = 0; j < kassza.Length; j++)
                {
                    if (cimletek[i] == kassza[j])
                        db++; //itt minden egyezésnél növekszik db 1-el
                }
                //objektum létrehozás, erről az osztályoknál szó lesz, annyi a lényeg, hogy itt mindig összeillesszük az aktuláis címletet a hozzá tartozó darabszámmal
                Cimletek szamolas = new Cimletek(cimletek[i], db);
                //Ezt hozzáadjuk egy listához
                penzSum.Add(szamolas);
                db = 0; //db-ot kinullázzuk, hogy a következő címlet is meg legyen számolva
            }
            //Ellenőrzésül írassuk ki
            foreach (var item in penzSum)
            {
                Console.WriteLine($"Címlet: {item.cimlet} Ft darabszám: {item.db}");
            }
            
            //while(feltétel), Addig lefut, amíg Igaz a feltételünk, amint hamis lesz leáll. Azért használunk k-t, mert már i létezik a for ciklusok miatt
            int k = 0;
            while (k < 5)
            {
                Console.WriteLine($"While {k}. ciklus");
                k++; //ha nem növelnék k értékét végtelen ciklust kapnánk
            }

            //while bool értékkel is működhet, amíg igaz addig fut, amint átállítjuk false-ra leáll
            //Fontos!!! Ha false az értékünk, while el sem indul
            bool repeat = true;
            int number;
            while (repeat)
            {
                Console.WriteLine("Adj meg egy számot");
                string input_num = Console.ReadLine();
                if (int.TryParse(input_num, out number)) {
                    Console.WriteLine($"Ügyes vagy! {number} valóban szám, jár a keksz!");
                    repeat = false;
                }
            }

            //do while, ez kiküszöböli azt a problémát, hogy false esetén while el sem indul. Do-nál legalább 1x minden esetben lefut
            int n = 0;
            do
            {
                Console.WriteLine($"Do-while, n({n})<5?");
                n++;
            }
            while (n<5);


            //Bár while erőforrásbarátabb, mivel olyan kereséseket tudunk csinálni ahol, az első találat után már nem fut végig
            //ugyanezt for ciklussal is meg tudjuk csinálni a break; használatával. Ez megszakítja a for ciklust az első találat után
            //keresés while-al
            int[] kassza2 = { 5, 5, 5, 10, 20, 20, 20, 50, 50, 5, 5, 5, 10, 20, 20, 20, 50, 50 };
            int keresett = 10;
            bool talalt = false;
            int m = 0;
            while (!talalt)
            {
                if (kassza2[m] == keresett)
                {
                    Console.WriteLine($"While, Van találat első index: {m}");
                    talalt = true;
                    m++;
                }
                else
                {
                    Console.WriteLine($"While keresés {m}. kör");
                    m++;
                }
            }

            //Ugyanez for ciklussal, hogy szintén leálljon (mert egyébként végig menne kassza2 összes elemény)
            for (int i = 0; i < kassza2.Length; i++)
            {
                if (kassza2[i] == keresett)
                {
                    Console.WriteLine($"For-break, van találat első index:{m}");
                    break;
                }
                else
                {
                    Console.WriteLine($"For break keresés {m}. kör");
                }
            }
        }
    }
    public class Cimletek
    {
        public int cimlet;
        public int db;

        public Cimletek(int cimlet, int db)
        {
            this.cimlet = cimlet;
            this.db = db;
        }
    }
}
