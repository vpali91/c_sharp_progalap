using System;
using System.Collections.Generic;
using System.Text;

namespace Oroklodes
{
    class Sniper : Rifle , Scoped
    {
        public Sniper()
        {
        }

        public Sniper(int range) : base(range)
        {
        }

        public Sniper(int sebzes, string texture, int range) : base(sebzes, texture, range)
        {
        }

        public void UseScope()
        {
            range = range+100;
        }
    }
}
