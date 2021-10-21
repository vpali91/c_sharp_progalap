using System;
using System.Collections.Generic;
using System.Text;

namespace Oroklodes
{
    class Ranged : Weapon
    {
        protected int range;
        public Ranged()
        {
        }

        public Ranged(int range)
        {
            this.range = range;
        }

        public Ranged(int sebzes, string texture, int range) : base(sebzes, texture)
        {
            this.range = range;
        }

        public int Hatotav()
        {
            return range * hp;
        }
    }
}
