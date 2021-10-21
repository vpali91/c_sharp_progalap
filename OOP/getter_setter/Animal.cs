using System;
using System.Collections.Generic;
using System.Text;

namespace getter_setter
{
    class Animal
    {
        private int age;
        private string name;
        private bool alive;

        public Animal(int ev, string nev, bool el)
        {
            this.age = ev;
            this.name = nev;
            this.alive = el;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int ev)
        {
            if(ev>age)
            age = ev;
        }

        public bool GetAlive()
        {
            return alive;
        }

        public void SetAlive(bool el)
        {
            alive = el;
        }


    }
}
