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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp2
{
    public partial class Adisyon : Form
    {
        public Adisyon()
        {
            InitializeComponent();
        }

        string secili_id, adisyon_id;



        private void Adisyon_Load(object sender, EventArgs e)
        {
            listele();

            musteriler_comboBox();
            urunler_comboBox();
            listele2();
            groupBox1.Visible = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aditb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void listele()
        {
            Fonksiyon.baglanti.Open();
            SqlCommand listeleKomut = new SqlCommand("SELECT id,urunAdi,fiyati FROM urunler", Fonksiyon.baglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listeleKomut);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            listeleKomut.ExecuteNonQuery();
            Fonksiyon.baglanti.Close();
        }






        private void listele2()
        {
            try
            {
                Fonksiyon.baglanti.Open();
                SqlCommand listeleKomut = new SqlCommand("SELECT id,urun_id, fiyati, adet, toplam,adisyon_id,tarih FROM adisyonUrunleri", Fonksiyon.baglanti);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listeleKomut);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (Fonksiyon.baglanti.State == ConnectionState.Open)
                {
                    Fonksiyon.baglanti.Close();
                }
            }
        }




        private void eklebtn_Click(object sender, EventArgs e)
        {
            if (adettb.Text.Length >= 1)
            {
              
                ekle();
                listele2();
            }
            else
            {
                MessageBox.Show("Adet boş olmaz...");
            }


           
        }


        private void fiyat_text()
        {
            try
            {
                Fonksiyon.baglanti.Open();
                string secilenUrunAdi = aditb.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(secilenUrunAdi))
                {
                    SqlCommand goster = new SqlCommand("SELECT urunAdi, fiyati FROM urunler WHERE urunAdi = @secilenUrunAdi", Fonksiyon.baglanti);
                    goster.Parameters.AddWithValue("@secilenUrunAdi", secilenUrunAdi);

                    SqlDataReader reader = goster.ExecuteReader();

                    // ComboBox'a veri ekler
                    while (reader.Read())
                    {
                        string adi = reader["urunAdi"].ToString();
                        string fiyati = reader["fiyati"].ToString();

                        if (adi == secilenUrunAdi)
                        {
                            fiyattb.Text = fiyati;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Fonksiyon.baglanti.Close();
            }
        }





        private void urunler_comboBox()
        {
            Fonksiyon.baglanti.Open();
            

            SqlCommand goster = new SqlCommand("SELECT urunAdi, fiyati FROM urunler", Fonksiyon.baglanti);
            SqlDataReader reader = goster.ExecuteReader();

            // ComboBox'a veri ekler
            while (reader.Read())
            {
                string adi = reader["urunAdi"].ToString();
                
                

                aditb.Items.Add(adi);

            }
            
            
           
            Fonksiyon.baglanti.Close();
        }



        private void musteriler_comboBox()
        {
            Fonksiyon.baglanti.Open();

            SqlCommand goster = new SqlCommand("SELECT id,adi, soyadi FROM musteriler", Fonksiyon.baglanti);
            SqlDataReader reader = goster.ExecuteReader();

            // ComboBox'a veri ekler
            while (reader.Read())
            {
                string adi = reader["adi"].ToString();
                string soyadi = reader["soyadi"].ToString();

                string tamIsim = $"{adi} {soyadi}";

                comboBox1.Items.Add(tamIsim);

            }
            Fonksiyon.baglanti.Close();
        }
        decimal toplam;
        private void ekle()
        {

            DateTime kayitTarihi = DateTime.Now;
            var secili_id = dataGridView2.CurrentRow.Cells["id"].Value;

            Fonksiyon.baglanti.Open();
            int adet = int.Parse(adettb.Text);



            SqlCommand ekle = new SqlCommand("INSERT INTO adisyonUrunleri(urun_id, fiyati, adet,adisyon_id,tarih,toplam) VALUES (@purun_id,@pfiyati,@padet,@padisyon_id,@ptarih,@ptoplam)", Fonksiyon.baglanti);
            ekle.Parameters.AddWithValue("@purun_id", secili_id);
            ekle.Parameters.AddWithValue("@pfiyati", fiyattb.Text);
            ekle.Parameters.AddWithValue("@padet", adet);
            ekle.Parameters.AddWithValue("@padisyon_id", adisyon_id);
            decimal fiyat = Convert.ToDecimal(fiyattb.Text);
            decimal adet1 = Convert.ToDecimal(adettb.Text);
            decimal toplam = ((fiyat) * (adet1));

            ekle.Parameters.AddWithValue("@ptoplam", toplam);
            ekle.Parameters.AddWithValue("@ptarih", kayitTarihi);
            ekle.ExecuteNonQuery();


            Fonksiyon.baglanti.Close();
            ekle_musteriler();


        }
        private void ekle_musteriler()
        {
            DateTime kayitTarihi = DateTime.Now;


            Fonksiyon.baglanti.Open();




            SqlCommand ekle = new SqlCommand("INSERT INTO adisyonlar(musteri_id, ucret, odendi_mi,tarih) VALUES (@pmusteri_id,@pucret,@odendi_mi,@ptarih)", Fonksiyon.baglanti);
           // ekle.Parameters.AddWithValue("@purun_id", secili_id);

            ekle.Parameters.AddWithValue("@odendi_mi", 0);
            ekle.Parameters.AddWithValue("@pmusteri_id", adisyon_id);
            decimal fiyat = Convert.ToDecimal(fiyattb.Text);
            decimal adet1 = Convert.ToDecimal(adettb.Text);
            decimal ucret = ((fiyat) * (adet1));

            ekle.Parameters.AddWithValue("@pucret", ucret);

            //ekle.Parameters.AddWithValue("@ptoplam", toplam);
            ekle.Parameters.AddWithValue("@ptarih", kayitTarihi);
            ekle.ExecuteNonQuery();

            Fonksiyon.baglanti.Close();


        }

        private void sil()
        {

            var seciliID = dataGridView2.CurrentRow.Cells["id"].Value;

            Fonksiyon.baglanti.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM adisyonUrunleri WHERE id=@pid", Fonksiyon.baglanti);
            sil.Parameters.AddWithValue("@pid", seciliID);
            sil.ExecuteNonQuery();
            Fonksiyon.baglanti.Close();

            listele2();


        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            sil();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fonksiyon.baglanti.Open();
            string ad = comboBox1.SelectedItem.ToString();

            SqlCommand goster = new SqlCommand("SELECT id,adi, soyadi FROM musteriler", Fonksiyon.baglanti);
            SqlDataReader reader = goster.ExecuteReader();


            while (reader.Read())
            {
                string adi = reader["adi"].ToString();
                string soyadi = reader["soyadi"].ToString();

                string tamIsim = $"{adi} {soyadi}";


                if (ad == tamIsim)
                {
                    adisyon_id = reader["id"].ToString();
                }

            }
            Fonksiyon.baglanti.Close();

            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void aditb_TextChanged(object sender, EventArgs e)
        {
        }

        private void fiyattb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adettb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adettb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // sadece rakamlara izin veriyor
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void fiyattb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void aditb_TabIndexChanged(object sender, EventArgs e)
        {
            fiyat_text();
        }

        private void fiyattb_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void aditb_SelectedIndexChanged(object sender, EventArgs e)
        {
                        fiyat_text();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Seçilen satırın hücrelerini TextBox'lara aktarır
                aditb.Text = dataGridView1.Rows[selectedRowIndex].Cells["urunAdi"].Value.ToString();
                fiyattb.Text = dataGridView1.Rows[selectedRowIndex].Cells["fiyati"].Value.ToString();
                secili_id = dataGridView1.Rows[selectedRowIndex].Cells["id"].Value.ToString();

            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }







}

