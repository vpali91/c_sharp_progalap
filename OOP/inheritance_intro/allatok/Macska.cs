using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    class Macska : Emlos
    {

        public Macska(int eletkor, int testsuly) : base(eletkor, testsuly)
        {

        }

        public string Karmol()
        {
            return "Megkarmolt";
        }
    }
}
