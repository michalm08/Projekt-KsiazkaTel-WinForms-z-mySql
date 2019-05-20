using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ksiazkaTel
{
    public partial class NowyKontakt : Form
    {
        public NowyKontakt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void Dodaj()
        {
            string query = "INSERT INTO note values(NULL,'"+tbImie.Text +"','"+ tbNazwisko.Text+"','"+tbNumer.Text+"')";
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=testing;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            MessageBox.Show("dodano kontakt");

        }

        private void btWroc1_Click(object sender, EventArgs e)
        {
            Form1 o1 = new Form1();
            Visible = false;
            o1.ShowDialog();
        }
    }
}
