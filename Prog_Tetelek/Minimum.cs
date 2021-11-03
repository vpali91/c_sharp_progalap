using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTetelek
{
    class Minimum
    {
        //létrehozzuk az üres tömbünket
        int[] tomb;

        //konstruktorban betöltjük a main osztályból a tömbünk elemeit
        public Minimum(int[] inputtomb)
        {
            this.tomb = inputtomb;
        }

        //Metódus
        public void MinMethod()
        {
            int n = tomb.Length; //A tömbünk hossza (nem muszáj létrehozni a tomb.Length-et írhatnánk a for ciklusunkba is)
            int min = Int32.MaxValue; //itt a változónkban lehetséges maximum értéket állítjuk be azért, hogy tutira találjuk kisebb számot a tömbben

            for (int i = 0; i < n; i++)
            {
                //minden egyes ciklusban megnézi, hogy a tömbünk i-edik eleme kisebb-e a min változónk értékénél
                if (tomb[i] < min)
                {
                    min = tomb[i]; //ha igen, akkor max értékét felülírjuk a tömb i-edik értékével
                }
            }
            //kiíratás
            Console.WriteLine("Minimumkeresés tétele:  A tömb legkisebb száma: " + min);
        }
    }
}
