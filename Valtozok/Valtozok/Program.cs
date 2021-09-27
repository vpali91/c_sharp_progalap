using System;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaráció: Amikor úgy hozunk létre változót, hogy nem adunk neki értéket
            int a;
            //Inicializáció: Amikor értéket adunk a változónak
            a = 10;
            //Inicializáció történhet a deklarációval együttesen
            int b = 20;
            int c = a + b;

            //Változó elnevezések
            string camelCase = "camelCase";
            string PascalCase = "Pascal"; 
            string snake_case = "snake_case";
            //kebab-case nem működik C#-ban
            //a változó nem kezdődhet számmal, de rakhatsz számot bele: pl: a1
            //a változó nem tartalmazhat szóközt, speciális karaktert, ékezetes se legyen
            //a tiszta kód jegyében próbálj mindig beszédes nevet adni nekik, lehetőleg angol nevekkel, hogy bárki ránéz, tudja miről van szó

            //Változó típusok
            byte mybyte = 1;
            int myNum = 5;
            float myFloat = 6.02f;
            double myDoubleNum = 5.02;
            long mylong = 3;
            bool myBool = true;
            char myLetter = 'D';
            string myText = "Hello";
            string text2 = "true";

            //Egyszerre több azonos típusú változót is létrehozhatsz inicializációval és anélkül is
            int x = 5, y = 6, z;

            //Explicit Kasztolás (Casting), egy változó/érték típusának megváltoztatás
            int castedFloatToInt = (int)myFloat;
            Console.WriteLine(castedFloatToInt); //Nincs kerekítés, csak a tizedes jel mögötti értékek el lettek távolítva

            //Típus konverzió methódusok (Type conversion methods)
            string intToString = Convert.ToString(myNum);
            string charToString = Convert.ToString(myLetter);
            double intToDouble = Convert.ToDouble(myNum);
            byte intToByte = Convert.ToByte(myNum);
            bool StringToBool = Convert.ToBoolean(text2);
            Console.WriteLine(intToString + "; " + charToString + "; " + intToDouble + "; " + intToByte + "; " + StringToBool);

            //Stringgé alakítás másképp
            string newString = "" + myNum;
            string newString2 = "" + myDoubleNum;
            string newString3 = "" + myLetter;
            string newString4 = "" + myBool;
            string newString5 = "" + myFloat;

            Console.WriteLine(newString + "; " + newString2 + "; " + newString3 + "; " + newString4 + "; " + newString5);

            //Parse a típus megváltoztatására string esetén
            string intInString = "2021";
            string doubleInString = "10,02";
            int stringToIntParse = int.Parse(intInString);
            double stringToDoubleParse = double.Parse(doubleInString);

            //Char típusú változót nem tudunk parse-olni, de kis ügyeskedéssel sikerülhet
            char intInChar = '2';
            string charToString2 = "" + intInChar;
            int charToInt = int.Parse(charToString2);

            Console.WriteLine(stringToIntParse + stringToDoubleParse + charToInt);

            //DateTime típusú változó
            DateTime most = DateTime.Now;
            Console.WriteLine(most);
            //Parsolás stringből DateTime típusba
            var dateString = "5/1/2008 8:30:52 AM";
            DateTime stringToDate = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(stringToDate);
            string dateNowToString = most.ToString("yyyy/MM/dd"); //y: év, M: hó, d: nap, h/H:óra, m: perc, stb...
            Console.WriteLine(dateNowToString);

        }
    }
}
