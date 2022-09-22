using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKereskedes
{
    class Auto
    {
        public string marka;
        public int gyartasiEv;
        public string rendszam;
        public string tulajdonos;
        public int ar;
        public bool muszaki;

        public Auto(string marka, int gyartasiEv, string rendszam, string tulajdonos, int ar, bool muszaki)
        {
            this.marka = marka;
            this.gyartasiEv = gyartasiEv;
            this.rendszam = rendszam;
            this.tulajdonos = tulajdonos;
            this.ar = ar;
            this.muszaki = muszaki; 
        }
    }
}
