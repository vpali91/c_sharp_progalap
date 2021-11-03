using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTetelek
{
    class Maximum
    {
        //létrehozzuk az üres tömbünket
        int[] tomb;

        //konstruktorban betöltjük a main osztályból a tömbünk elemeit
        public Maximum(int[] inputtomb)
        {
            this.tomb = inputtomb;
        }

        //Metódus
        public void MaxMethod()
        {
            int n = tomb.Length; //A tömbünk hossza (nem muszáj létrehozni a tomb.Length-et írhatnánk a for ciklusunkba is)
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                //minden egyes ciklusban megnézi, hogy a tömbünk i-edik eleme nagyobb-e a max változónk értékénél
                if (tomb[i] > max)
                {
                    max = tomb[i]; //ha igen, akkor max értékét felülírjuk a tömb i-edik értékével
                }
            }
            //kiíratás
            Console.WriteLine("Maximumkeresés tétele:  A tömb legnagyobb száma: " + max);
        }
    }
}
