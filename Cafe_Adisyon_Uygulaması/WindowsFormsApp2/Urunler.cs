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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }


        private void ekle()
        {
            try
            {
                
                DateTime kayitTarihi = DateTime.Now;

                
                if (string.IsNullOrEmpty(urunaditb.Text) || string.IsNullOrEmpty(katagoriaditb.Text) || string.IsNullOrEmpty(fiyattb.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                Fonksiyon.baglanti.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO urunler(urunAdi,katagoriAdi,fiyati,tarih) VALUES (@purunAdi,@pKategoriAdi,@pfiyati,@ptarih)", Fonksiyon.baglanti);
                ekle.Parameters.AddWithValue("@purunAdi", urunaditb.Text);
                ekle.Parameters.AddWithValue("@pkategoriAdi", katagoriaditb.Text);
                ekle.Parameters.AddWithValue("@pfiyati", Convert.ToDecimal(fiyattb.Text));
                ekle.Parameters.AddWithValue("@ptarih", kayitTarihi);
                ekle.ExecuteNonQuery();
                Fonksiyon.baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Guncelle()
        {
            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;

            if (seciliID != null)
            {
                

                VeritabaniIslemleri.Guncelle("urunler", "pid", seciliID, urunaditb.Text, Convert.ToDecimal(fiyattb.Text), katagoriaditb.Text);
                DataTable dt = Veritabani.Listele("urunler", dataGridView1, "", "");
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        //////////////




        private void urunaditb_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        private void katagoriaditb_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void fiyattb_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void intager(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // sadece rakam girişine izin veriyor
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void eklebtn_Click_1(object sender, EventArgs e)
        {
            ekle();
            DataTable dt = Veritabani.Listele("urunler", dataGridView1, "", "");
            dataGridView1.DataSource = dt;
            urunaditb.Clear();
            katagoriaditb.Clear();
            fiyattb.Clear();
        }

        private void silbtn_Click_1(object sender, EventArgs e)
        {
            //seçili olan değeri siliyor
            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;
            VeritabaniIslemleri.Sil("urunler", "id", seciliID);


            //tekrardan verileri listeliyoruz
            DataTable dt =Veritabani.Listele("urunler",dataGridView1,"","");            
            dataGridView1.DataSource = dt;

        }

        private void guncellebtn_Click_1(object sender, EventArgs e)
        {
            Guncelle();

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            DataTable dt = Veritabani.Listele("urunler", dataGridView1, "", "");
            dataGridView1.DataSource = dt;
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            DataTable sonuclar = VeritabaniIslemleri.VeriGetir("urunler", "urunAdi", "urunAdi", aratb.Text);
            dataGridView1.DataSource = sonuclar;

        }

        private void aratb_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void temizlebtn2_Click(object sender, EventArgs e)
        {
            aratb.Text = "";
        }

        private void temizlebtn_Click_1(object sender, EventArgs e)
        {
            urunaditb.Text = "";
            katagoriaditb.Text = "";
            fiyattb.Text = "";
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}








