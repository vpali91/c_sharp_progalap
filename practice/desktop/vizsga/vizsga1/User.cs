using System;
using System.Collections.Generic;
using System.Text;

namespace Vizsga1
{
    public class User
    {
        public string fnev;
        public List<string> mlist;
        public int db;
        public int sum_ar;
        public int sum_kedv;
        public int sum_fizetendo;

        public User(string fnev, List<Order> olist)
        {
            this.fnev = fnev;
            this.mlist = Listaz(olist);
            this.db = mlist.Count;
            this.sum_ar = Sum_price(olist);
            this.sum_kedv = Sum_ked(olist);
            this.sum_fizetendo = Sum_fizet(olist);
        }
        public List<string> Listaz(List<Order> olist)
        {
            List<string> list = new List<string>();
            foreach (var item in olist)
            {
                if (item.fnev == fnev)
                    list.Add(item.sorSzam);
            }
            return list;
        }

        public int Sum_price(List<Order> olist)
        {
            int sum = 0;
            foreach (var item in olist)
            {
                if (fnev == item.fnev)
                    sum += item.ar;
            }
            return sum;
        }

        public int Sum_ked(List<Order> olist)
        {
            int sum = 0;
            foreach (var item in olist)
            {
                if (fnev == item.fnev)
                    sum += item.kedv;
            }
            return sum;
        }

        public int Sum_fizet(List<Order> olist)
        {
            int sum = 0;
            foreach (var item in olist)
            {
                if (fnev == item.fnev)
                    sum += item.fizetendo;
            }
            return sum;
        }


    }
}
