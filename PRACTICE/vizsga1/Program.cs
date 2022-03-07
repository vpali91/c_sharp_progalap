using System;
using System.Collections.Generic;
using System.IO;

namespace Vizsga1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> order_list = new List<Order>();
            string[] lines = File.ReadAllLines("megrendelesek.txt");
            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Order order_generator = new Order(values[0], values[1], values[2], values[3]);
                order_list.Add(order_generator);
            }

           // foreach (var item in order_list)
             //   Console.WriteLine($"{item.sorSzam} {item.fnev} , {item.ar} , {item.kedv}, {item.fizetendo}");

            //1. Feladat
            Console.WriteLine("Sorszám: ");
            string input_sorszam = Console.ReadLine();
            Order feladat1 = new Order("","","0","0");

            foreach (var item in order_list)
                if (input_sorszam == item.sorSzam)
                    feladat1 = item;
            Console.WriteLine((feladat1.ar != 0)? $"{feladat1.sorSzam}, {feladat1.fnev}, {feladat1.ar}, {feladat1.kedv}, {feladat1.fizetendo}": "Nincs talalat!");

            //2. Feladat
            List<string> user_nev = new List<string>();
            List<User> user_list = new List<User>();
            foreach (var item in order_list)
                if (!user_nev.Contains(item.fnev))
                    user_nev.Add(item.fnev);

            foreach (var item in user_nev)
            { 
                User user_generator = new User(item, order_list);
                user_list.Add(user_generator);
            }
            /*
            foreach (var item in user_list)
            {
                string megrend = "";
                foreach (var item2 in item.mlist)
                {
                    megrend += item2 +"; ";
                }
                Console.WriteLine($"{item.fnev}, {item.db}, {megrend}");
                megrend = "";
            }
            */
            int max = int.MinValue;
            int sum_max = 0;
            User max_user = user_list[0];
            foreach (var item in user_list)
            {
                if (item.db > max)
                {
                    max = item.db;
                    max_user = item;
                }
            }

            Console.WriteLine();


        }
    }
}
