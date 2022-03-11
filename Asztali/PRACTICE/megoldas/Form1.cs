using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Sorsolas> sorsolasok = new List<Sorsolas>();
        List<Szam> szamok = new List<Szam>();
        public Form1()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("lotto.txt");
            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Sorsolas sorsolas_object = new Sorsolas(values[0], values[1], values[2], values[3], values[4], values[5]);
                sorsolasok.Add(sorsolas_object);
            }

            //2. Feladat:
            int db = 0;
            for (int i = 1; i < 91; i++)
            {
                foreach (var item in sorsolasok)
                {
                    if(i == item.szam1|| i == item.szam2 || i == item.szam3 || i == item.szam4 || i == item.szam5)
                        db++;
                }
                Szam szam_object = new Szam(i, db);
                szamok.Add(szam_object);
                db = 0;
            }

            int max_db =int.MinValue;
            int max_szam=0;

            foreach (var item in szamok)
            {
                if(item.db > max_db)
                {
                    max_db = item.db;
                    max_szam = item.szam;
                }
                //3. Feladat 23
                if (item.szam == 23)
                    label3.Text = $"23-as: {item.db} db";
                //4. Feladat 64
                if (item.szam == 64)
                    label4.Text = $"64-es: {item.db} db";
            }
            label2.Text = $"Legtöbbször kihúzva: {max_szam}: {max_db}";

            //5-6. Feladat
            foreach (var item in szamok)
                dataGridView1.Rows.Add(item.szam, item.db);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in sorsolasok)
                if (numericUpDown1.Value == item.het)
                    label1.Text = $"Feladat1: {item.het}. hét: {item.szam1},{item.szam2},{item.szam3},{item.szam4},{item.szam5}";
        }
    }
}
