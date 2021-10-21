using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    public class Emlos
    {
        public int eletkor;
        public int testsuly;
        public bool eletbenVanE=true;

        public Emlos(int eletkor, int testsuly)
        {
            this.eletkor = eletkor;
            this.testsuly = testsuly;
        }

        public int Oregszik()
        {
            return eletkor++;
        }

        public int Eszik()
        {
            return testsuly++;
        }

        public bool kill()
        {
            return eletbenVanE = false;
        }
    }
}
