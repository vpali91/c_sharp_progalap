using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTetelek
{
    // Szeretnénk kiválogatni a addot feltételek szerint egy tömb elemeit
    class Kivalogatas
    {
        //létrehozzuk az üres tömbünket
        int[] tomb;
        int keresett = 5;

        //konstruktorban betöltjük a main osztályból a tömbünk elemeit
        public Kivalogatas(int[] inputtomb)
        {
            this.tomb = inputtomb;
        }
        //Metódus
        public void KivalogatMethod()
        {
            int n1 = tomb.Length; //A tömbünk hossza (nem muszáj létrehozni a tomb.Length-et írhatnánk a for ciklusunkba is)
            int n2 = 0;

            for (int i = 0; i < n1; i++)
            {
                //minden egyes ciklusban megnézi, hogy a tömbünk i-edik eleme nagyobb-e a keresett számnál
                if (tomb[i] > keresett)
                {
                    n2++;
                }
            }
            int[] eredmeny = new int[n2];
            int j = 0;

            for (int i = 0; i < n1; i++)
            {
                if (tomb[i] > keresett) // ha megvalósul a feltételünk, akkor tömb2-höz adunk elemet
                {
                    eredmeny[j] = tomb[i]; //tömbünk j-edik elemét felülírjuk az eredeti tömb i-edik elemével
                    j++; // növelnünk kell j-t különben minden ciklusban az új tömbünk első elemét írogatnánk felül
                }
            }
            Console.Write("Kiválogatás tétele: A feltételek szerint kiválasztott új tömb tagjai: ");
            //kiíratjuk sorban a tömb elemeit
            for (int i = 0; i < eredmeny.Length; i++)
            {
                Console.Write(eredmeny[i] + ";");
            }
        }

    }
}
