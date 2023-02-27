using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sorsolas> sorsolas_lista = new List<Sorsolas>();
            string[] lines = File.ReadAllLines("sorsolas.txt");

            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Sorsolas sorsolas_object = new Sorsolas(values[0], values[1], values[2], values[3], values[4], values[5]);
                sorsolas_lista.Add(sorsolas_object);
            }

            /* foreach (var item in sorsolas_lista)
             {
                 Console.WriteLine(item.het + "| " + item.szam1 + "| " + item.szam2 + "| " + item.szam3 + "| " + item.szam4 + "| " + item.szam5);
             }
            */
            bool okes = true;
            int hetiSzam = 0;
            while (okes) 
            {
                Console.WriteLine("Adj meg egy hetet(1-52): ");
                string inputNumber = Console.ReadLine();
                if (int.TryParse(inputNumber, out hetiSzam))
                {
                    if(hetiSzam >0 && hetiSzam < 53)
                    {
                        foreach (var item in sorsolas_lista)
                        {
                            if(item.het == hetiSzam)
                            {
                                Console.WriteLine($"{item.het}. heti sorsolás: {item.szam1},{item.szam2},{item.szam3},{item.szam4},{item.szam5},");
                                okes = false;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nincs tartományban!");
                    }
                }
                else
                {
                    Console.WriteLine("Nem szám!");
                }
             }

            List<NyeroSzam> nyeroszamLista = new List<NyeroSzam>();
            int db = 0;
            for (int i = 1; i < 91; i++)
            {
                foreach (var item in sorsolas_lista)
                {
                    if (item.szam1 == i)
                        db++;
                    if (item.szam2 == i)
                        db++;
                    if (item.szam3 == i)
                        db++;
                    if (item.szam4 == i)
                        db++;
                    if (item.szam5 == i)
                        db++;
                }
                NyeroSzam nyszam_object = new NyeroSzam(i, db);
                nyeroszamLista.Add(nyszam_object);
                db = 0;
            }

            //3. Feladat
            int min = int.MaxValue;
            int min_nyeroszam=0;
            foreach (var item in nyeroszamLista)
            {
                if (min > item.db)
                {
                    min = item.db;
                    min_nyeroszam = item.nySzam;
                }
            }
            Console.WriteLine("3. Feladat: " + min_nyeroszam +","+min);

            //4. Feladat
            int parosDb = 0;
            foreach (var item in nyeroszamLista)
            {
                if(item.nySzam % 2 == 0)
                {
                    parosDb += item.db;
                }
            }
            Console.WriteLine("4. Feladat Páros számok (db): "+parosDb);

            int db5 = 0;
            int db46 = 0;

            foreach (var item in nyeroszamLista)
            {
                if (item.nySzam == 5)
                    db5++;
                if (item.nySzam == 46)
                    db46++;
            }
            Console.WriteLine("5 szam: "+db5);
            Console.WriteLine("46 szam: " + db46);

            //7. Feladat
            foreach (var item in nyeroszamLista)
            {
                Console.WriteLine($"{item.nySzam};{item.db}");
            }
            Console.ReadKey();
        }
    }
}
