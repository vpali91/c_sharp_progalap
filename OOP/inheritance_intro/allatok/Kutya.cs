using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    class Kutya : Emlos
    {

        public Kutya(int eletkor, int testsuly) : base(eletkor, testsuly)
        {

        }

        public string Ugat()
        {
            return "Vau";
        }
    }
}
