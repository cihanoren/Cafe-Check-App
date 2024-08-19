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
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp2
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            
            InitializeComponent();
            

        }

        //FONKSİYONLAR

        private void ekle()
        {
            DateTime tarih = DateTime.Now;

            if (string.IsNullOrWhiteSpace(aditb.Text) || string.IsNullOrWhiteSpace(Soyaditb.Text) || string.IsNullOrWhiteSpace(unvantb.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Fonksiyon.baglanti.Open();

                    SqlCommand ekle = new SqlCommand("INSERT INTO musteriler(adi, soyadi, tanimlama, tarih) VALUES(@padi, @psoyadi, @ptanimlama, @ptarih)", Fonksiyon.baglanti);
                    ekle.Parameters.AddWithValue("@padi", aditb.Text);
                    ekle.Parameters.AddWithValue("@psoyadi", Soyaditb.Text);
                    ekle.Parameters.AddWithValue("@ptanimlama", unvantb.Text);
                    ekle.Parameters.AddWithValue("@ptarih", tarih);
                    ekle.ExecuteNonQuery();

                    Fonksiyon.baglanti.Close();

                    aditb.Clear();
                    Soyaditb.Clear();
                    unvantb.Clear();
                    listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
        private void Form1_Button1Clicked(object sender, EventArgs e)
        {
            // Form1'deki butona tıklanınca burada yapılacak işlemler
            // Örneğin Form2'deki başka bir butonu tıkla
            button4.PerformClick();
        }

        private void listele()
        {
            DataTable dt = Veritabani.Listele("musteriler", dataGridView1, "", "id, adi, soyadi, tanimlama, tarih");
            dataGridView1.DataSource = dt;

        }

        
         
        private void guncelle()
        {
            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;

            Fonksiyon.baglanti.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE musteriler SET adi = @pYeniAdi, soyadi = @pYeniSoyadi, tanimlama = @pYeniUnvan WHERE id = @pid", Fonksiyon.baglanti);
            guncelle.Parameters.AddWithValue("@pYeniAdi", aditb.Text);
            guncelle.Parameters.AddWithValue("@pYeniSoyadi", Soyaditb.Text);
            guncelle.Parameters.AddWithValue("@pYeniUnvan", unvantb.Text);
            guncelle.Parameters.AddWithValue("@pid", seciliID);
            guncelle.ExecuteNonQuery();
            Fonksiyon.baglanti.Close();
            listele();

        }
        
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void aditb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Soyaditb_TextChanged(object sender, EventArgs e)
        {

        }

        private void unvantb_TextChanged(object sender, EventArgs e)
        {

        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            ekle();
           



        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            //seçili olan değeri siliyor
            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;
            VeritabaniIslemleri.Sil("musteriler", "id", seciliID);


            //tekrardan verileri listeliyoruz
            DataTable dt = Veritabani.Listele("musteriler", dataGridView1, "", "");
            dataGridView1.DataSource = dt;

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            guncelle();
        }
        

        private void odemebtn_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();


            formAc(odeme);


            //VeritabaniIslemleri.FormAc(this, new Odeme()); böyle yazınca mdi hatası veriyor çözmedik




        }
        private void formAc(Form gelenForm)
        {
            foreach (Form mdiForm in MdiChildren)
            {
                if (mdiForm.GetType() == gelenForm.GetType())
                {
                    mdiForm.BringToFront();
                    return;
                }
            }

            
            gelenForm.Show();
        }
       


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Seçilen satırın hücrelerini TextBox'lara aktarır
                aditb.Text = dataGridView1.Rows[selectedRowIndex].Cells["adi"].Value.ToString();
                Soyaditb.Text = dataGridView1.Rows[selectedRowIndex].Cells["soyadi"].Value.ToString();
                unvantb.Text = dataGridView1.Rows[selectedRowIndex].Cells["unvan"].Value.ToString();
                seciliID = dataGridView1.Rows[selectedRowIndex].Cells["id"].Value.ToString();
            }
        }
        
        private void Musteriler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void arabtn_Click_1(object sender, EventArgs e)
        {
            DataTable arama = VeritabaniIslemleri.VeriGetir("musteriler", "adi", "adi", aratb.Text);
            dataGridView1.DataSource = arama;
            
        }

        private void temizlebtn2_Click(object sender, EventArgs e)
        {
            aratb.Text = "";
        }

        private void aratb_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void temizlebtn_Click_1(object sender, EventArgs e)
        {
            aditb.Text = "";
            Soyaditb.Text = "";
            unvantb.Text = "";
        }

        private void Soyaditb_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
