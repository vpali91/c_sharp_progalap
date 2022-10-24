using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    public abstract class Allat
    {
        public int eletkor;
        public int testsuly;
        public bool eletbenVanE = true;

        public Allat(int eletkor, int testsuly)
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

        public bool Kill()
        {
            return eletbenVanE = false;
        }

        public abstract void HangotAdKi();
    }
}

//Elmélet: https://csharptutorial.hu/docs/hellovilag-hellocsharp/5-osztalyok-objektumok/orokles-nyelvi-alapjai/
