using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Calculator
{
    class Fajlbair
    {
        public float a, b, c;
        public string name;

        public Fajlbair(float a, float b, float c, string name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.name = name;
        }

        public void Printing()
        {
            DateTime most = DateTime.Now;
            string dateNowToString = most.ToString("yyyy/MM/dd");

            Szamitas calc = new Szamitas(a, b, c);
            calc.Szamol();

            StreamWriter sw = new StreamWriter("gipsz_jakab.txt");

            string str = $"Számításos lap \n " +
                $"a oldal: {a} \n" +
                $"b oldal: {b} \n" +
                $"c oldal: {c} \n" +
                $"Kerület: {calc.k}\n" +
                $"Terület: {calc.t}\n" +
                $"\n Kelt: Szeged, {dateNowToString}";

            sw.WriteLine(str);
            sw.Flush();
            // Zárni is kell
            sw.Close();
        }
    }
}
