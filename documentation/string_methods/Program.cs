using System;
using System.Collections.Generic;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Length
            string txt = "Valami Szöveg";
            Console.WriteLine($"Txt length: {txt.Length}");

            // String ToUpper(), Minden nagybetűvé alakul
            Console.WriteLine($"txt.ToUpper(): {txt.ToUpper()}");

            // String ToLower(), Minden kisbetűvé alakul
            Console.WriteLine($"txt.ToLower(): {txt.ToLower()}");

            //String concateration (string összeadás)
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            //string.Concat(string1, string2) ugyanerre jó, több stringet is bele lehet pakolni
            Console.WriteLine($"string.Concat(firstName, lastName): {string.Concat(firstName, lastName, name)}");

            //string interpolation $"Valami szöveg: {kód, vagy változó}";

            //string characterek szerinti bontása
            Console.WriteLine($"txt[1]: {txt[1]}");
            List<char> characterList = new List<char>();
            foreach (var item in txt)
            {
                characterList.Add(item);
            }

            //Stringben belüli character indexének megadása, az első találatot adja ki
            Console.WriteLine($"'a' hanyadik karakter, (első találat)? {txt.IndexOf('a')}");
            Console.WriteLine($"'a' hanyadik karakter (utolsó találat)? {txt.LastIndexOf('a')}");

            //Substring(7): a 7. karaktertől a végéig írja ki a string tartalmát
            Console.WriteLine($"A 7. karaktertől írja ki a végéig: {txt.Substring(7)}");

            //Substring(2,7): a 2. karaktertől a 7-ig írja ki a string tartalmát
            Console.WriteLine($"A 2. karaktertől írja ki a 7-ig: {txt.Substring(2,7)}");

            //Split használata txt.Split(karakter(ek), amely(ek)nél szét akarjuk bontani)
            string longTxt = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            
            //String szavakra bontása és betöltése tömbbe:
            Console.WriteLine($"A második mondat: {longTxt.Split(".")[1]}");
            string[] szavak = longTxt.Split(' ',',', '.');
            
            //tömb kiíratása
            foreach (var item in szavak)
            {
                //Console.WriteLine(item);
            }
            //String szavakra bontása és betöltése tömbből listába úgy hogy ne legyen nagybetű és ismétlődés és szóköz:
            List<string> szavakLista = new List<string>();
            foreach (var item in szavak)
            {
                if (!szavakLista.Contains(item.ToLower())&& !String.IsNullOrWhiteSpace(item))
                {
                    szavakLista.Add(item.ToLower());
                }
            }
            //lista kiíratása úgy hogy minden szó nagybetűvel kezdődjön
            foreach (var item in szavakLista)
            {
                Console.WriteLine(char.ToUpper(item[0])+item.Substring(1));
            }
        }
    }
}
