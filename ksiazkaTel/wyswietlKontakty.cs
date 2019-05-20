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
    public partial class wyswietlKontakty : Form
    {
        public wyswietlKontakty()
        {
            InitializeComponent();
        }

        private void btWroc2_Click(object sender, EventArgs e)
        {
            Form1 o1 = new Form1();
            Visible = false;
            o1.ShowDialog();
        }

        private void btWyswietl_Click(object sender, EventArgs e)
        {
            Aktualizuj2();
            
            //aktual4 a1 = new aktual4();
            //a1.Aktualizuj();
        }

        public void Aktualizuj2()
        {

            string query = "SELECT * FROM note";
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=testing;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();

           
            while (myReader.Read())
            {
                Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + " - " + myReader.GetString(2) + " - " + myReader.GetString(3) + "\n");

                
                ListViewItem item = new ListViewItem(myReader.GetString(0));
                item.SubItems.Add(myReader.GetString(1));
                item.SubItems.Add(myReader.GetString(2));
                item.SubItems.Add(myReader.GetString(3));

                listView1.Items.Add(item);

            }
        }



    }
}
