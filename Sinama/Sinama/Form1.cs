using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sinama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection bagla = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source="+Application.StartupPath+ "\\Sinama.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 film = new Form2();

            this.Hide();
            film.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Seans = new Form3();

            this.Hide();
            Seans.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Salonlar = new Form4();

            this.Hide();
            Salonlar.Show();
        }
    }
}
