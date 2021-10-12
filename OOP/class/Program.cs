using System;

namespace OOP_Intro
{
    //Console app-ban ez a futtatható osztályod
    class Program
    {
        static void Main(string[] args)
        {
            // objektum példányosítás
            NPC belethor = new NPC("Belethor", "breton", 100, false);
            //objektumhoz tartozó methódus meghívása
            belethor.Speak();
            NPC sheogorath = new NPC("Sheogorath", "daedric", 100, true);
            NPC maiq = new NPC("M'aiq the Liar", "khajiit", 100, true);
        }
    }
}
