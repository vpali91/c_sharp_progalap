using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTetelek
{
    class Megszamolas
    {
        //létrehozzuk az üres tömbünket
        int[] tomb;
        int keresett = 5;

        //konstruktorban betöltjük a main osztályból a tömbünk elemeit
        public Megszamolas(int[] inputtomb)
        {
            this.tomb = inputtomb;
        }

        //Metódus
        public void MegszamolasMethod()
        {
            int db = 0;
            int n = tomb.Length; //A tömbünk hossza (nem muszáj létrehozni a tomb.Length-et írhatnánk a for ciklusunkba is)

            for (int i = 0; i < n; i++)
            {
                //minden egyes ciklusban megnézi, hogy a tömbünk i-edik eleme kisebb-e a megadott számnál
                if (tomb[i] < keresett)
                {
                    db++;  // ha igen, akkor hozzáadunk a darabszámhoz egyet
                }

            }
            //kiíratás
            Console.WriteLine("Megszámolás tétele: " + keresett + " számnál kisebb számokból " + db + " db van.");
        }

    }
}
