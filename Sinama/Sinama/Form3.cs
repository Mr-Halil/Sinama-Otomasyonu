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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OleDbConnection bagla = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Application.StartupPath + "\\Sinama.accdb");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            this.Close();
            anasayfa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bagla.Open();
                OleDbCommand ekle = new OleDbCommand("insert into Seanslar(Ad,Tarih,Saat) values('" + textBox1.Text + "','"+dateTimePicker1.Text+"','"+textBox3.Text+"')", bagla);
                ekle.ExecuteNonQuery();

                bagla.Close();

                MessageBox.Show("Seans Eklendi");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
