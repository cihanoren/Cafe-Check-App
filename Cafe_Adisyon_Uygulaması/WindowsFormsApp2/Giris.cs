using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        
        private void urunler_comboBox()
        {
            Fonksiyon.baglanti.Open();


            SqlCommand goster = new SqlCommand("SELECT kullaniciAdi FROM kullanicilar", Fonksiyon.baglanti);
            SqlDataReader reader = goster.ExecuteReader();

            // ComboBox'a veri ekler
            while (reader.Read())
            {
                string adi = reader["kullaniciAdi"].ToString();

               

                comboBox1.Items.Add(adi);

            }



            Fonksiyon.baglanti.Close();
        }
        private bool GirisKontrol(string kullaniciAdi, string sifre)
        {
            bool dogrulandi = false;

            Fonksiyon.baglanti.Open();

            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM kullanicilar WHERE kullaniciAdi=@KullaniciAdi AND sifre=@Sifre", Fonksiyon.baglanti);
            kontrol.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
            kontrol.Parameters.AddWithValue("@Sifre", sifre);

            int kullaniciSayisi = (int)kontrol.ExecuteScalar();

            if (kullaniciSayisi > 0)
            {
                dogrulandi = true;
            }

            Fonksiyon.baglanti.Close();

            return dogrulandi;
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            urunler_comboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = comboBox1.Text;
            string sifre = textBox1.Text;

            if (GirisKontrol(kullaniciAdi, sifre))
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();

                // Form1 kapatıldıktan sonra Giris formunu oluştur ve aç
                Giris form = new Giris();
                form.Show();

                
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
