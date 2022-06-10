using System;

namespace ProgTetelek
{
    //Szeretnénk kiválogatni a addot feltételek szerint egy tömb elemeit
    class Szetvalogatas
    {
        //létrehozzuk az üres tömbünket
        int[] tomb;
        int keresett = 5;

        //konstruktorban betöltjük a main osztályból a tömbünk elemeit
        public Szetvalogatas(int [] inputtomb)
        {
            this.tomb = inputtomb;
        }

        //Metódus
        public void SzetvalogatasMethod()
        {
            int n1 = tomb.Length; //A tömbünk hossza (nem muszáj létrehozni a tomb.Length-et írhatnánk a for ciklusunkba is)
            //itt létrehozzuk a másik két tömbünk hosszát tartalmazó változót
            int n2 = 0;
            int n3 = 0;

            //Itt végigfutunk az eredeti tömbünkön és megszámoljuk, hogy a feltételünk alapján a két új tömbünknek hány tagja lesz
            for (int i = 0; i < n1; i++)
            {
                if (tomb[i] > keresett)  //ha igaz a feltételünk tömbünk i-edik elemére, akkor tömb2 hosszához adunk egyet
                {
                    n2++;
                }
                else  //ha nem igaz a feltételünk, akkor tömb3 hosszához adunk egyet
                {
                    n3++;
                }
            }
            //itt hozzuk létre a 2 tömbünket, azért volt fontos, hogy meghatározzuk a tömbök hosszát, mert ha enélkül adnánk hozzá elemeket az új tömbökhöz, akkor crashelnénk
            int[] tomb2 = new int[n2];
            int[] tomb3 = new int[n3];

            // for ciklusunkhoz 2 db 0 értékű változót hozunk létre,
            int j = 0; //tömb2-höz kell
            int k = 0; //tömb3-hoz kell

            for (int i = 0; i < n1; i++)
            {
                if (tomb[i] > keresett) // ha megvalósul a feltételünk, akkor tömb2-höz adunk elemet
                {
                    tomb2[j] = tomb[i];  //tömbünk j-edik elemét felülírjuk az eredeti tömb i-edik elemével
                    j++; // növelnünk kell j-t különben minden ciklusban az új tömbünk első elemét írogatnánk felül
                }
                else  // ha nem igaz, tömb3-hoz
                {
                    tomb3[k] = tomb[i]; //tömbünk k-adik elemét felülírjuk az eredeti tömb i-edik elemével
                    k++; // növelnünk kell k-t különben minden ciklusban az új tömbünk első elemét írogatnánk felül
                }

            }
            Console.WriteLine("Szétválogatás tétele: ");

            //tömb2 kiíratása
            Console.Write("Egyik tömb: ");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.Write(tomb2[i] + ";");
            }
            //tömb2 kiíratása
            Console.Write("Másik tömb: ");
            for (int i = 0; i < tomb3.Length; i++)
            {
                Console.Write(tomb3[i] + ";");
            }


        }

    }
}
