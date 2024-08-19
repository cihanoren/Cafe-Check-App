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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sifretb.UseSystemPasswordChar = false;
            }
            else
            {
                sifretb.UseSystemPasswordChar = true;
            }
        }


        private void listele()
        {
            DataTable dt = Veritabani.Listele("kullanicilar", dataGridView1, "", "");
            dataGridView1.DataSource = dt;


        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;

            Fonksiyon.baglanti.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE kullanicilar SET kullaniciAdi = @pYeniKullaniciAdi, sifre = @pYeniSifre WHERE id = @pid", Fonksiyon.baglanti);
            guncelle.Parameters.AddWithValue("@pYeniKullaniciAdi", aditb.Text);
            guncelle.Parameters.AddWithValue("@pYeniSifre", sifretb.Text);
            guncelle.Parameters.AddWithValue("@pid", seciliID);
            guncelle.ExecuteNonQuery();
            Fonksiyon.baglanti.Close();
            listele();
        }

        private void silbtn_Click_1(object sender, EventArgs e)
        {
            //seçili olan değeri siliyor

            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;
            DataTable dt = Veritabani.Listele("kullanicilar", dataGridView1, "", "");
            dataGridView1.DataSource = dt;


            if (dt.Rows.Count != 1)
            {
                
                VeritabaniIslemleri.Sil("kullanicilar", "id", seciliID);
            }
            else
            {
                MessageBox.Show("Son kayıtlı kullanıcı silinemez..");
            }                  


            //tekrardan verileri listeliyoruz
            DataTable dt1 = Veritabani.Listele("kullanicilar", dataGridView1, "", "");
            dataGridView1.DataSource = dt1;

        }

        private void eklebtn_Click_1(object sender, EventArgs e)
        {
            
                DateTime tarih = DateTime.Now;

                if (string.IsNullOrWhiteSpace(aditb.Text) || string.IsNullOrWhiteSpace(sifretb.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Fonksiyon.baglanti.Open();

                        SqlCommand ekle = new SqlCommand("INSERT INTO kullanicilar(kullaniciAdi, sifre, tarih) VALUES(@pkullaniciAdi, @psifre, @ptarih)", Fonksiyon.baglanti);
                        ekle.Parameters.AddWithValue("@pkullaniciadi", aditb.Text);
                        ekle.Parameters.AddWithValue("@psifre", sifretb.Text);                        
                        ekle.Parameters.AddWithValue("@ptarih", tarih);
                        ekle.ExecuteNonQuery();

                        Fonksiyon.baglanti.Close();

                        aditb.Clear();
                        sifretb.Clear();
                       
                        listele();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                                  





        }

        private void aratb_TextChanged(object sender, EventArgs e)
        {

        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            DataTable sonuclar = VeritabaniIslemleri.VeriGetir("kullanicilar", "kullaniciAdi", "kullaniciAdi", aratb.Text);
            dataGridView1.DataSource = sonuclar;
        }

        private void temizlebtn2_Click(object sender, EventArgs e)
        {
            aratb.Text = "";
        }
    }
}
