using System;

namespace Oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ranged r = new Ranged(10, "gun", 30);
            r.Evaulation();
            r.Hatotav();
            Sniper s = new Sniper(20,"Mosin Nagant", 100);
            s.Damage();
            s.Celzas();
            s.UseScope();

            Melee m = new Melee(5, "Sword");
            m.Damage();
            m.CriticalStrike();

        }
    }
}
