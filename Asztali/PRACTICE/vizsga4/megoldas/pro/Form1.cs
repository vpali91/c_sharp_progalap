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

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Megrendeles> order_list = new List<Megrendeles>();
        List<User> user_list = new List<User>();
        public Form1()
        {
            InitializeComponent();
            List<string> users = new List<string>();
            string g_user = "";
            int g_db = 0, max_ar = int.MinValue, kupon_db = 0, min_ar = int.MaxValue, sum_fiz = 0;

            string[] lines = File.ReadAllLines("megrendelesek.txt");
            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Megrendeles order_object = new Megrendeles(values[0], values[1], values[2], values[3]);
                order_list.Add(order_object);
            }

            //2. Feladat
            foreach (var item in order_list)
                if (!users.Contains(item.userName))
                    users.Add(item.userName);

            foreach (var item in users)
            {
                User user_object = new User(item, order_list);
                user_list.Add(user_object);
                //6. Feladat
                if (item.StartsWith("g"))
                {
                    g_db++;
                    if (g_db < 4)
                        g_user += item + "; ";
                }
            }

            User max_ertek_user = user_list[0];
            foreach (var item in user_list)
            {
                if (item.sum_ar > max_ar)
                {
                    max_ar = item.sum_ar;
                    max_ertek_user = item;
                }
                //7. Feladat
                if (item.nev == "lali20")
                    label6.Text = "Lali20 összes megrendelés: " + item.sum_fiz;
            }
            label2.Text = $"Legnagyobb érték: {max_ertek_user.nev}, {max_ertek_user.db} db, {max_ertek_user.sum_ar} Ft";

            //3. Feladat
            Megrendeles min_ertek_megrend = order_list[0];
            foreach (var item in order_list)
            {
                if (item.kedv != 0)
                    kupon_db++;
                if (min_ar > item.ar)
                {
                    min_ar = item.ar;
                    min_ertek_megrend = item;
                }
                sum_fiz += item.fizetendo;
                //9. Feladat
                dataGridView2.Rows.Add(item.sorSzam, item.userName, item.fizetendo);
            }
            label3.Text = $"Kuponos megrendelés: {kupon_db} db";    
            label4.Text = $"Legkisebb érték: {min_ertek_megrend.sorSzam},{min_ertek_megrend.userName},{min_ertek_megrend.ar},{min_ertek_megrend.kedv},{min_ertek_megrend.fizetendo}";//4. Feladat  
            label5.Text = $"G találat: {g_db} db, {g_user}";
            label7.Text = "Összes bevétel: " + sum_fiz; //8. Feladat
        }

        //1. Feladat
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in order_list)
                if (numericUpDown1.Value == item.sorSzam)
                    label1.Text = $"{item.sorSzam}, {item.userName}, {item.ar}, {item.kedv}, {item.fizetendo}";
        }

        //5. Feladat
        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            foreach (var item in user_list)
                if(textBox1.Text.ToLower()==item.nev)
                    foreach (var item2 in item.megrend_list)
                        dataGridView1.Rows.Add(item2.sorSzam, item2.userName, item2.ar, item2.kedv, item2.fizetendo);
        }
    }
}
