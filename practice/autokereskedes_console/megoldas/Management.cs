using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKereskedes
{
    internal class Management
    {
        public string ujTulajdonos ="";
        public string rendszam ="";
        public int eloleg =0;
        Auto auto1 = new Auto("BMW", 2015, "abc-123", "Gipsz Jakab", 5000000, false);
        Auto auto2 = new Auto("Audi", 2016, "abc-234", "Teszt Elek", 10000000, true);
        Auto auto3 = new Auto("Toyota", 2019, "abc-345", "Kovács Jakab", 6000000, true);
        Auto auto4 = new Auto("Tesla", 2018, "abc-452", "Nagy Jakab", 7000000, true);
        Auto auto5 = new Auto("Trabant", 1990, "abc-426", "Kissw Jakab", 50000, false);
        
        List<Auto>autoLeltar = new List<Auto>();

        public Management(string ujTulajdonos, string rendszam, string eloleg)
        {
            this.ujTulajdonos = ujTulajdonos;
            this.rendszam = rendszam;
            if(int.TryParse(eloleg, out this.eloleg)) { }
            else
                this.eloleg = 0;

            autoLeltar.Add(auto1);
            autoLeltar.Add(auto2);
            autoLeltar.Add(auto3);
            autoLeltar.Add(auto4);
            autoLeltar.Add(auto5);

            Eladas();
        }
        public Management(string rendszam, string valasz)
        {
            this.rendszam = rendszam;
            Forgalmi(valasz);
        }

        public void Eladas()
        {
            for (int i = 0; i < autoLeltar.Count; i++)
            {
                if (autoLeltar[i].rendszam == rendszam)
                {
                    string regiTulaj = autoLeltar[i].tulajdonos;
                    autoLeltar[i].tulajdonos = ujTulajdonos;
                    int fizetendo = autoLeltar[i].ar - eloleg;
                    Console.WriteLine($"Adásvétel \n Eladó: {regiTulaj} \n" +
                        $"Vevő: {autoLeltar[i].tulajdonos},\n Márka:{autoLeltar[i].marka}, \n" +
                        $"Gyártási év: {autoLeltar[i].gyartasiEv}, \n Rendszám: {autoLeltar[i].rendszam}, \n" +
                        $"Vételár: {autoLeltar[i].ar}, \n Előleg: {eloleg}, \n Fizetendo: {fizetendo}");
                    break;
                }
            }
        }

        public void Forgalmi(string valasz)
        {
            for (int i = 0; i < autoLeltar.Count; i++)
            {
                if (autoLeltar[i].rendszam == rendszam)
                {
                    if(valasz == "ervenytelenit")
                    {
                        autoLeltar[i].muszaki = false;
                        Console.WriteLine("A műszaki lejárt!");
                    }
                    else
                    {
                        autoLeltar[i].muszaki = true;
                        Console.WriteLine("A műszaki megújítva!");
                    }
                }
            }
        }
    }
}
