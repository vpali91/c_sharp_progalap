using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Intro
{
    class Weapon
    {
        string name;
        int hp;
        int damage;
        bool enchanted;

        public Weapon(string name, int hp, int damage, bool enchant)
        {
            this.name = name;
            this.damage = damage;
            this.hp = hp;
            this.enchanted = enchant;
        }
        public Weapon()
        {
            this.name = "knife";
            this.damage = 5;
            this.hp = 100;
            this.enchanted = false;
        }
    }
}
