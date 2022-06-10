using System;
using System.Collections.Generic;
using System.Text;
using static System.Random;

namespace OOP_Intro
{
    //osztály
    class NPC
    {
        //az osztály változói
        public string name;
        public string race;
        public int hp;
        public bool immortal;
        Weapon weapon;
        
        //construktor, ami paramétereket vár és ez alapján értéket az a változóknak
        public NPC(string name, string race, int hp, bool immortal)
        {
            this.name = name;
            this.race = race;
            this.hp = hp;
            this.immortal = immortal;
            this.weapon = new Weapon("Sword",100,10,false);
        }

        //metódus visszatérési érték és paraméter nélkül
        public void Speak()
        {
            string[]quotes = { "I used to be an adventurer like you. Then I took an arrow in the knee.", "Never should have come here!", "Let me guess… someone stole your sweetroll?"};
            var rnd = new Random();
            int random_num = rnd.Next(3);
            Console.WriteLine(quotes[random_num]);
        }

        public void Injured()
        {
            hp -= 10;
        }

        //metódus visszatérési értékkel
        public int getHP()
        {
            return hp;
        }

        //Method overloading: Ha több ugyanolyan nevű metódus létezik, csak különféle típusú paramétereket várnak
        // Mindig az fut le, amelyik fajta paramétert kapta meg.
        public void doSomething(string something) {
            Console.WriteLine("string: " + something);
        }
        public void doSomething(string something, string something2)
        {
            Console.WriteLine("string: " + something);
        }
        public void doSomething(int something)
        {
            Console.WriteLine("int: " + something);
        }
        public void doSomething(bool something)
        {
            Console.WriteLine("bool: " +something);
        }

    }
}
