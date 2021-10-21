using System;
using System.Collections.Generic;
using System.Text;

namespace Oroklodes
{
    class Melee : Weapon
    {
        public Melee()
        {
        }

        public Melee(int sebzes, string texture) : base(sebzes, texture)
        {

        }

        public void CriticalStrike()
        {
            sebzes = Damage() + 50;
            hp = Evaulation()*10;
        }
    }
}
