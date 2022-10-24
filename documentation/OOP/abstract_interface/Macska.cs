using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    class Macska : Emlos
    {
        public int karomElesseg;

        public Macska(int eletkor, int testsuly, int szoros, int karom) : base(eletkor, testsuly, szoros)
        {
            this.karomElesseg = karom;
        }

        public override void HangotAdKi()
        {
            Console.WriteLine("Miau");
        }

        public string Karmol()
        {
            return "Megkarmolt";
        }
    }
}
