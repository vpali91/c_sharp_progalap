using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTetelek
{
    class Osszegzes
    {
        //létrehozzuk az üres tömbünket
        int[] tomb;

        //konstruktorban betöltjük a main osztályból a tömbünk elemeit
        public Osszegzes(int[] inputtomb)
        {
            this.tomb = inputtomb;
        }

        //Metódus
        public void OsszegzesMethodus()
        {
            int osszeg = 0;
            int n = tomb.Length; //A tömbünk hossza (nem muszáj létrehozni a tomb.Length-et írhatnánk a for ciklusunkba is)

            for (int i = 0; i < n; i++)
            {
                osszeg = osszeg + tomb[i]; //minden egyes ciklusban hozzáadjuk az összeghez a tömbünk i-edik elemét
            }
            //kiíratás
            Console.WriteLine("Összegzés tétele, Összeg: " + osszeg);
        }

    }
}
