using System;
using System.Collections.Generic;
using System.Text;

namespace Oroklodes
{
    class Weapon
    {
        protected int sebzes;
        protected string texture;
        protected int hp = 100;

        public Weapon(int sebzes, string texture)
        {
            this.sebzes = sebzes;
            this.texture = texture;
        }
        public Weapon()
        {
        }

        public int Damage()
        {
            return sebzes;
        }
        public int Evaulation()
        {
            if (hp > 0)
                return hp - 1;
            else
                return hp;
        }

    }
}
