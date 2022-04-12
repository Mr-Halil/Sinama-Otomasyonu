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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection bagla = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Application.StartupPath + "\\Sinama.accdb");

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
        }
        private void listele()
        {
            try
            {
                bagla.Open();
                OleDbCommand listele = new OleDbCommand("Select Ad from Salonlar", bagla);
                OleDbDataReader reader = listele.ExecuteReader();

                while(reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }

                bagla.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void listele2()
        {
            try
            {
                bagla.Open();
                OleDbCommand listele = new OleDbCommand("Select Ad from Seanslar", bagla);
                OleDbDataReader reader = listele.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader[0].ToString());
                }

                bagla.Close();
            }
            catch (Exception)
            {

                throw;
            }
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Dosya tipleri(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bagla.Open();
                OleDbCommand ekle = new OleDbCommand("insert into Filmler(Ad,Tur,Yonetmen,Seans,Salon) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+comboBox1.Text+"','"+comboBox2.Text+"')", bagla);
                ekle.ExecuteNonQuery();

                bagla.Close();

                MessageBox.Show("Film Eklendi");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
