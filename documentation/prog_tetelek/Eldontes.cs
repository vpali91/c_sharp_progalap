using System;
using System.Collections.Generic;
using System.Text;

//Az eldöntés tétele során a metódusunk azt ellenőrzi, hogy a keresett elem szerepel-e a tömbünkben

namespace ProgTetelek
{
    class Eldontes
    {
        //létrehozzuk az üres tömbünket
        int[] tomb;
        int keresett = 1;

        //konstruktorban betöltjük a main osztályból a tömbünk elemeit
        public Eldontes(int[] inputtomb)
        {
            this.tomb = inputtomb;
        }

        //Metódus
        public void EldontesMethodus()
        {
            int n = tomb.Length;  //A tömbünk hossza (nem muszáj létrehozni a tomb.Length-et írhatnánk a for ciklusunkba is.
            bool vane = false; //logikai változó, false az alapértéke, mert ha nem találjuk a keresett elemet, akkor false marad

            for (int i = 0; i < n; i++)
            {
                //minden egyes ciklusban megnézi, hogy a tömbünk i-edik eleme megegyezik-e a keresett számmal
                if(tomb[i] == keresett)
                {
                    vane = true; // ha megtaláltuk a keresett számot, akkor felülírjuk a változónkat true-ra
                }
            }
            //Kiíratás, itt leellenőrizzük a logikai változónk értékét. 
            if (vane == true)
            {
                Console.WriteLine("Eldöntés tétele: Van ilyen szám. (" + keresett + ") "); //true esetén ez fut le
            }
            else
            {
                Console.WriteLine("Eldöntés tétele: Nincs ilyen szám. (" + keresett + ") "); //false esetén ez fut le
            }
        }

        //Ugyanez a tétel while használatával, erőforrásigényben kedvezőbb a használata, mert ha megtalálta a keresett elemet, nem fut végig a tömbön
        public void EldontesMethodus2()
        {
            int n = tomb.Length;
            int i = 0;
            while(i<n && tomb[i] != keresett)
            {
                i++;
            }
            //kiíratás, a while ciklusunk során, amikor nem volt találat mindig hozzáadunk 1-et i-hez, ha végigment a tömbön találat nélkül, akkor i=n
            //Ha i kisebb számot tartalmaz, mint a tömb hossza, akkor megtalálta a keresett számot és megállt mielőtt végig ment volna a tömbön
            if (i < n)
            {
                Console.WriteLine("Benne van");
            }
            else
            {
                Console.WriteLine("Nincs benne");
            }
        }
    }
}
