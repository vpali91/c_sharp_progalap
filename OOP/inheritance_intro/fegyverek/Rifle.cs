using System;
using System.Collections.Generic;
using System.Text;

namespace Oroklodes
{
    class Rifle : Ranged
    {
        public Rifle()
        {
        }

        public Rifle(int range) : base(range)
        {
        }

        public Rifle(int sebzes, string texture, int range) : base(sebzes, texture, range)
        {
        }
        public void Celzas()
        {
            range = range + 10;
        }
    }
}
