using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=employee.db;Version=3;New=False;Compress=True;");
        }

        //set execute query
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set load DB
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from employees";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        //Add
        private void button1_Click(object sender, EventArgs e)
        {
            string txtQuery = $"INSERT INTO employees (ID, Name) VALUES ('{textBox1.Text}', '{textBox2.Text}');";
            ExecuteQuery(txtQuery);
            LoadData();
        }
        //Edit
        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = $"UPDATE employees SET Name='{textBox2.Text}' WHERE ID='{textBox1.Text}';";
            ExecuteQuery(txtQuery);
            LoadData();
        }
        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = $"DELETE FROM employees WHERE ID='{textBox1.Text}';";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
