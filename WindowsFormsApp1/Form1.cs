using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQLiteConnection sqlite_conn;
            //SQLiteCommand sqlite_cmd;
            //SQLiteDataReader sqlite_datareader;
            //sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            string cs = "Data Source=database.db;Version=3;New=True;Compress=True;";
            string stm = "SELECT SQLITE_VERSION()";
            //string stm = "INSERT INTO test (id, text) VALUES (1, 'coba coba')";

            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
          
            string version = cmd.ExecuteScalar().ToString();
            //string result = cmd.ExecuteScalar().ToString();

            //Console.WriteLine($"SQLite version: {version}");
            //Console.WriteLine($"{result}");


            //MessageBox.Show($"SQLite version: {version}");
            MessageBox.Show(version);

        }
    }
}
