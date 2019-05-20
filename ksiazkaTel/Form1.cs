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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NowyKontakt o1 = new NowyKontakt();
            Visible = false;
            o1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wyswietlKontakty o1 = new wyswietlKontakty();
            Visible = false;
            o1.ShowDialog();

        }

       
    }
}
