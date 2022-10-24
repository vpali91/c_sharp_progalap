using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    public abstract class Emlos : Allat
    {
        public int szorosseg;
        public Emlos(int eletkor, int testsuly, int szoros) : base(eletkor, testsuly)
        {
            this.szorosseg = szoros;
        }

        public void Vedlik()
        {
            if (szorosseg > 0)
                szorosseg--;
        }

    }
}
