using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    public class Kutya : Emlos, Uszas
    {

        public string gazda;
        public Kutya(int eletkor, int testsuly, int szoros, string gazda) : base(eletkor, testsuly, szoros)
        {
            this.gazda = gazda;
        }

        public override void HangotAdKi()
        {
            Console.WriteLine("Vau");
        }

        public void Uszik()
        {
            Console.WriteLine("Uszok");
        }
    }
}
