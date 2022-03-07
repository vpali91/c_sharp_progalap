using System;
using System.Collections.Generic;
using System.Text;

namespace Vizsga1
{
    public class Order
    {
        public string sorSzam;
        public string fnev;
        public int ar;
        public int kedv;
        public int fizetendo;

        public Order(string sorSzam, string fnev, string a,string ked)
        {
            this.sorSzam = sorSzam;
            this.fnev = fnev;
            this.ar = int.Parse(a);
            this.kedv = int.Parse(ked);
            this.fizetendo = ar -kedv;
        }
    }
}
