using System;

namespace RandomNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random használatakor példányosítani kell Random osztályból egy objektumot és ennek az objektumnak a funkcióit lehet használni
            //Random objektum_név = new Random();
            Random rnd = new Random();
            //A példányosítás után létrehozhatjuk a random számot
            //rnd.Next() :  ilyenkor a választott szám típus pozitív értéktartományában jön létre randomszám úgy, hogy int.Maxvalue értékénél nem lesz nagyobb
            int num = rnd.Next();
            Console.WriteLine(num);

            float num2 = rnd.Next();
            Console.WriteLine(num2);

            double num3 = rnd.Next();
            Console.WriteLine(num3);

            //Több random szám generálása:
            Random rnd2 = new Random();

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(rnd2.Next());
            }

            // rnd.Next(szám) : A megadott számnál kisebb pozitív random számokkal tér vissza
            Console.WriteLine(rnd.Next(10));//returns random integers < 10

            //rnd.Next(szám1, szám2) : Random egész számokkal tér vissza(nagyobb vagy egyenlő mint szám1 és kisebb mint szám2)
            Console.WriteLine(rnd.Next(-100, 20));
            float num4 = rnd2.Next(10, 20);
            Console.WriteLine(num4);

            // Random tört számok generálása 0 és 1 között
            Console.WriteLine(rnd.NextDouble());

            //tömb feltöltése random byte-okkal
            byte[] tomb = new byte[4];
            rnd.NextBytes(tomb);

            //Seed érték megadás. Azonos Seed értékkel eltérő random objektumok is azonos random számot generálnak
            Random rnd3 = new Random(10);
            Random rnd4 = new Random(10);
            Console.WriteLine("Egyik: " + rnd3.Next());
            Console.WriteLine("Egyik: " + rnd3.Next());

            Console.WriteLine("Másik: " + rnd4.Next());
            Console.WriteLine("Másik: " + rnd4.Next());

            //Stringek randomizálása
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido", "Vanya", "Samuel", "Koani", "Volodya", "Prince", "Yiska" };
            // Random index generálása a tömbhöz.
            int mIndex = rnd.Next(malePetNames.Length);
            Console.WriteLine(malePetNames[mIndex]);
        }
    }
}
