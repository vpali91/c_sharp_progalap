using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matematikai alapműveletek: +, -, *, / ezeket nem fejteném ki
            //Maradékos osztás, pl: 5%2 = 1 ilyenkor azt vizsgáljuk hogy 5 szám 2-vel elosztva mennyi maradékot ad.
            Console.WriteLine($"5%2={5 % 2}");
            
            //Incrementation ++ ilyenkor 1-el növeljük a változó értékét. Fontos, hogy nem azonnal növeli 1-el, hanem a végrehajtás után!
            int b = 3;
            Console.WriteLine($"b++ pillanatában: {b++}");
            Console.WriteLine($"b értéke b++ után {b}");

            //Decrementation -- Ilyenkor 1-el csökkentjük a változó értékét. Fontos, hogy nem azonnal csökkenti 1-el, hanem a végrehajtás után!
            Console.WriteLine($"b-- pillanatában: {b--}");
            Console.WriteLine($"b értéke b++ után {b}");

            //Assignment operators(értékadó operátorok): ezekkel a változónknak valamilyen értéket adunk. Pl: =, +=, -=, *=, /=, %=
            //b-nek új értéket adunk:
            b = 10;
            //b-hez hozzáadódik 5, másképp b=b+6
            b += 5;
            //b-ből kivonjuk 4-et, másképp b=b-4
            b -= 4;
            //b-vel szorozzuk 3-at, másképp b=b*3
            b *= 3;
            //2-vel osszuk b-t, másképp b=b/2
            b /= 2;
            //b-t felülírjuk a 3-al osztás maradékának eredményével, másképp b=b%3
            b %= 3;

            int x = 3;
            int y = 5;
            int z = 3;
            //Comparison operators/összehasonlító operátorok:Egyenlő: ==, Nem egyenlő: !=, >, <, >=, <= , ezek mindig logikai(bool) értékkel térnek vissza: true/false
            Console.WriteLine($" x==y: {x==y},\n x==z: {x==z},\n x!=y: {x!=y},\n x<y: {x<y},\n stb...");

            // Logical operators/Logikai operátorok:
            // &&: és, ilyenkor mindkét feltétel együttesen teljesül akkor lesz true,
            Console.WriteLine($"x=3 esetén, x>2 && x<5: {x > 2 && x < 5}");
            // ||: vagy, ilyenkor egy feltételnek kell teljesülnie, akkor lesz true
            Console.WriteLine($"x=3 esetén, x>2 || x>5: {x > 2 || x > 5}");
            // !: megfordítjai a logikai értékünk, pl !(false) -> true
            Console.WriteLine($"!true: {!true}");



        }
    }
}
