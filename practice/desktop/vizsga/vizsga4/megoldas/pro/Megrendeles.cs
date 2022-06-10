using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class Megrendeles
    {
        public int sorSzam, ar, kedv, fizetendo;
        public string userName;

        public Megrendeles(string sorSzam, string userName, string ar, string kedv)
        {
            this.sorSzam = int.Parse(sorSzam);
            this.userName = userName;
            this.ar = int.Parse(ar);
            this.kedv = int.Parse(kedv);
            this.fizetendo = int.Parse(ar)- int.Parse(kedv);
        }
    }
}
