using System;
using System.Collections.Generic;
using System.Text;

namespace File_Handling
{
    class NPC
    {
        //az osztály változói
        public string name;
        public string race;
        public int hp;
        public bool immortal;

        //construktor, ami paramétereket vár és ez alapján értéket az a változóknak
        public NPC(string name, string race, int hp, bool immortal)
        {
            this.name = name;
            this.race = race;
            this.hp = hp;
            this.immortal = immortal;
        }
    }
}
