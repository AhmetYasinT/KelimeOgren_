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

namespace KelimeOgren_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ahmet\Desktop\Çalışmalar\KelimeOgren_\dbSozluk.mdb");

        Random rand = new Random();
        int sure = 90;
        int kelime = 0;

        void Getir() {
            int sayi = rand.Next(1, 2490);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txting.Text = dr[1].ToString();
                LblYanit.Text = dr[2].ToString();
                LblYanit.Text = LblYanit.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
            TxtTürkçe.Focus();
            timer1.Start();
        }

        private void TxtTürkçe_TextChanged(object sender, EventArgs e)
        {
            if (TxtTürkçe.Text==LblYanit.Text)
            {
                kelime++;
                LblKelime.Text = kelime.ToString();
                Getir();
                TxtTürkçe.Clear();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSüre.Text = sure.ToString();
            if (sure==0)
            {
                TxtTürkçe.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Tebrikler 90 Saniye Kelime Skorunuz : " + kelime.ToString(),"Bilgi");
            }
        }
    }
}
