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
                List<int> valueint = new List<int>();
                Order order_generator = new Order(values[0], values[1], values[2], values[3]);
                order_list.Add(order_generator);
            }

            // foreach (var item in order_list)
            //   Console.WriteLine($"{item.sorSzam} {item.fnev} , {item.ar} , {item.kedv}, {item.fizetendo}");

            //1. Feladat
            Console.WriteLine("Sorszám: ");
            string input_sorszam = Console.ReadLine();
            Order feladat1 = new Order("", "", "0", "0");

            foreach (var item in order_list)
                if (input_sorszam == item.sorSzam)
                    feladat1 = item;
            Console.WriteLine((feladat1.sorSzam != "") ? $"{feladat1.sorSzam}, {feladat1.fnev}, {feladat1.ar}, {feladat1.kedv}, {feladat1.fizetendo}" : "Nincs talalat!");

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
            User max_user = user_list[0];
            foreach (var item in user_list)
            {
                if (item.db > max)
                {
                    max = item.db;
                    max_user = item;
                }
            }

            Console.WriteLine($"2. Feladat: {max_user.fnev}, db: {max_user.db}, Sum ár: {max_user.sum_ar}");

            //3. Feladat
            int kupon_db = 0;
            foreach (var item in order_list)
                if (item.kedv != 0)
                    kupon_db++;

            //4. Feladat
            int min_ertek = int.MaxValue;
            Order min_ertek_order = order_list[0];
            foreach (var item in order_list)
                if (min_ertek > item.ar)
                {
                    min_ertek = item.ar;
                    min_ertek_order = item;
                }
            Console.WriteLine($"4. Feladat: {min_ertek_order.sorSzam}, {min_ertek_order.fnev}, {min_ertek_order.ar}, {min_ertek_order.kedv}, {min_ertek_order.fizetendo} ");

            // 5. Feladat
            Console.WriteLine("Felhasználó: ");
            string user_input = Console.ReadLine();

            List<Order> user_order_list = new List<Order>();
            foreach (var item in order_list)
                if (user_input == item.fnev)
                    user_order_list.Add(item);
            Console.WriteLine("4. Feladat");
            foreach (var item in user_order_list)
                Console.WriteLine($"{item.sorSzam} {item.fnev} , {item.ar} , {item.kedv}, {item.fizetendo}");

            //6. Feladat
            List<string> feladat6_list = new List<string>(); 
            foreach (var item in user_nev)
                if (item.StartsWith("a"))
                    feladat6_list.Add(item);

            Console.WriteLine($"G: {feladat6_list.Count} db");
            foreach (var item in feladat6_list)
                Console.WriteLine(item);

            //7. Feladat
            foreach (var item in user_list)
                if(item.fnev == "lali20")
                    Console.WriteLine($"Lali20 fizetendő összesen: {item.sum_fizetendo}");

            //8. Feladat
            int sum_fizetendo=0;
            foreach (var item in order_list)
                sum_fizetendo += item.fizetendo;
            Console.WriteLine($"Bevétel: {sum_fizetendo}");

            //9. Feladat
            foreach (var item in order_list)
                Console.WriteLine($"{item.sorSzam}, {item.fnev}, {item.fizetendo}");
        }
    }
}

