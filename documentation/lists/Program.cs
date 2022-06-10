using System;
using System.Collections;
using System.Collections.Generic;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList olyan lista, amihez mindenféle típusú elemet hozzáadhatunk, akár egyazon array listbe és a méretet se kell megadnunk
            //Teljesítményproblémák miatt inkább a List<object> megoldás javasolt többféle típusú változó tárolására
            //Azonos típusú változók dinamikus tárolására inkább a List javasolt
            ArrayList arlist = new ArrayList();
            var arlist2 = new ArrayList(); //inkább ez a javasolt forma

            //Így adunk elemeket hozzá
            arlist.Add(1);
            arlist.Add("Bill");
            arlist.Add(" ");
            arlist.Add(true);
            arlist.Add(1.6);

            //vagy így
            var arlist3 = new ArrayList(){3,"Steve", " ", true, 4.6, null};

            //Tömböt is és ArrayList-et hozzáadhatunk
            int[] tomb = { 100, 200, 300, 400, 500 };
            arlist2.AddRange(arlist);
            arlist2.AddRange(tomb);

            //kiíratás
            Console.WriteLine(arlist2[5]);
            foreach (var item in arlist2)
            {
                Console.Write(item + "; ");
            }
            Console.WriteLine();

            //ArrayList methods
            //Remove() Egy elemet távolít el
            //RemoveRange() több elemet távolítunk el indexekkel megadva
            arlist2.Remove(" ");
            arlist2.RemoveRange(4,3);
            foreach (var item in arlist2)
            {
                Console.Write(item + "; ");
            }
            Console.WriteLine();

            //Sort() sorbarendezés, azonos típusokkal működik

            //Reverse() Megfordítja az elemes sorrendjét
            arlist2.Reverse();
            foreach (var item in arlist2)
            {
                Console.Write(item + "; ");
            }
            Console.WriteLine();

            //Clear() törli a tartalmát
            arlist2.Clear();
            foreach (var item in arlist2)
            {
                Console.Write(item + "| ");
            }
            Console.WriteLine();

            //List<> lista
            //Létrehozása és feltöltése adatokkal
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(30);
            numbers.Add(10);
            numbers.Add(5);

            List<int> numbers2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers2.Add(i);
            }

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// ez is megengedett listánál

            //ez is működik
            var bigCities = new List<string>(){"New York", "London", "Mumbai", "Chicago"};

            //Hogyan töltsünk be többféle változó típust a listába? Objektumokkal!
            List<NPC> npc_list = new List<NPC>();
            NPC npc_generator = new NPC("Belethor","breton",100,false);
            npc_list.Add(npc_generator);
            npc_generator = new NPC("Sheogorath", "daedric", 100, true);
            npc_list.Add(npc_generator);
            npc_generator = new NPC("M'aiq the Liar", "khajiit", 100, true);
            npc_list.Add(npc_generator);

            //kiíratás
            foreach (var item in npc_list)
            {
                Console.WriteLine(item.name + " " + item.race + " " + item.hp + " " + item.immortal);
            }

            //Tömb hozzáadása listához
            string[] tomb2 = { "Mumbai", "London", "New York"};
            List<string> lista = new List<string>();
            lista.AddRange(tomb2);
            //ellenőrzés, hogy sikerült-e
            foreach (var item in lista)
                Console.WriteLine(item);

            //Count, ugyanazt csinálja, mint a tömböknél a Length, megszámolja az elemeket
            //Az objektumot is 1-nek számolja, hiába van tele változókkal
            Console.WriteLine($"Lista elemeinek száma: {npc_list.Count}");

            //BinarySearch: megkeresi adott elemet és visszatér az indexével
            Console.WriteLine("London találat: "+bigCities.BinarySearch("London"));

            //Clear() - Lista elemeinek törlése

            //Contains(keresett érték) --> logikai értékkel tér vissza, hogy tartalmazza-e a lista
            Console.WriteLine((bigCities.Contains("London"))?"Van találat Londonra" : "Nincs találat Londonra");

            //Remove(érték) Eltávolít egy elemet, ami egyezik ezzel az értékkel, RemoveAt(index) ugyanezt teszi, csak indexet kell megadni

            //Sort() Sorbarendezi a lista elemeit, minimum maximumkereséskor praktikus lehet, ha számokról van szó, vagy ha abc sorrendbe akarjuk rakni a szavakat
            bigCities.Sort();
            foreach (var item in bigCities)
                Console.WriteLine(item);

            numbers.Sort();
            Console.WriteLine($"Min: {numbers[0]}, Max: {numbers[numbers.Count-1]}");



            //Listákat tudunk akár tömbben, vagy egy másik listában is tárolni
            List<string> lista1 = new List<string>();
            List<string> lista2 = new List<string>();
            List<string> lista3 = new List<string>();

            List<string>[] listaTomb = { lista1, lista2, lista3 };
            listaTomb[0].Add("asd");

            List<List<string>> listalista = new List<List<string>>();
            listalista.Add(lista1);
            listalista.Add(lista2);
            listalista.Add(lista3);
            listalista[0].Add("fgdsf");

        }
    }

    public class NPC
    {
        public string name;
        public string race;
        public int hp;
        public bool immortal;

        public NPC(string name, string race, int hp, bool immortal)
        {
            this.name = name;
            this.race = race;
            this.hp = hp;
            this.immortal = immortal;
        }
    }
}
