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
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace WindowsFormsApp2
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }


        private void musteriler_comboBox()
        {
            Fonksiyon.baglanti.Open();

            SqlCommand goster = new SqlCommand("SELECT id, adi, soyadi FROM musteriler", Fonksiyon.baglanti);
            SqlDataReader reader = goster.ExecuteReader();

            // ComboBox'a veri ekler
            comboBox1.Items.Clear(); // Önce ComboBox'ı temizle
            comboBox1.DisplayMember = "Key"; // Görünen metni belirle
            comboBox1.ValueMember = "Value"; // Value olarak kullanılacak alanı belirle

            while (reader.Read())
            {
                string adi = reader["adi"].ToString();
                string soyadi = reader["soyadi"].ToString();
                string id = reader["id"].ToString();
                string tamIsim = $"{adi} {soyadi}";

                // Her öğeyi eklerken bir KeyValuePair nesnesi olarak ekleyin
                comboBox1.Items.Add(new KeyValuePair<string, int>(tamIsim, int.Parse(id)));
            }

            Fonksiyon.baglanti.Close();

        }
        private void odendi()
        {
            int odendi = 1;
            var seciliID = dataGridView1.CurrentRow.Cells["id"].Value;

            Fonksiyon.baglanti.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE adisyonlar SET odendi_mi = @podendi_mi WHERE id = @pid", Fonksiyon.baglanti);
            guncelle.Parameters.AddWithValue("@podendi_mi", odendi);
            guncelle.Parameters.AddWithValue("@pid", seciliID);
            guncelle.ExecuteNonQuery();
            Fonksiyon.baglanti.Close();
            listele();

        }

        private void ucretgosterlabel()
        {



            DataGridView dataGridView61 = this.dataGridView1;
            int toplam_ucret = 0;

            foreach (DataGridViewRow row in dataGridView61.Rows)
            {
                // Hücre değeri null kontrolü ekleyerek
                object odendi_miObj = row.Cells["odendi_mi"].Value;
                if (odendi_miObj != null)
                {
                    string odendi_mi = odendi_miObj.ToString();

                    // Hücre değeri null kontrolü ekleyerek
                    object ucretObj = row.Cells["ucret"].Value;
                    if (ucretObj != null)
                    {
                        decimal ucret = Convert.ToDecimal(ucretObj.ToString());

                        if (odendi_mi == "0")
                        {
                            toplam_ucret += Convert.ToInt32(ucret);
                        }
                    }
                }
            }

            fiyattb.Text = "Ödenmemiş Tutar " + toplam_ucret.ToString() + " TL";
        }





        private void listele()
        {
            DataTable dt = Veritabani.Listele("adisyonlar", dataGridView1, "", "id,musteri_id,ucret,odendi_mi,tarih");
            dataGridView1.DataSource = dt;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            musteriler_comboBox();
            listele();
            ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fiyattb.Text = "";
            if (comboBox1.SelectedItem != null)
            {

                if (comboBox1.SelectedItem is KeyValuePair<string, int> selectedKeyValue)
                {

                    int musteriId = selectedKeyValue.Value;
                    string query = $"SELECT * FROM adisyonlar WHERE musteri_id = @musteri_id";

                    // SqlCommand ve SqlParameter kullanarak güvenli sorgu oluşturuluyor
                    using (SqlCommand command = new SqlCommand(query, Fonksiyon.baglanti))
                    {
                        // SqlParameter ekleniyor ve değeri atanıyor
                        command.Parameters.AddWithValue("@musteri_id", musteriId);

                        // SqlDataAdapter ile veriler çekiliyor
                        SqlDataAdapter adtr = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adtr.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }


                }





            }
            ucretgosterlabel();



        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {

                ucretgosterlabel();
                odendi();
            }
            else
            {
                MessageBox.Show("Ödeme yapılıcak kullanıcıyı seçiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {// Eğer herhangi bir satıra tıklanmışsa işlemi gerçekleştir
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView1 = this.dataGridView1;

                // Tıklanan satırın ucret hücresini al
                DataGridViewCell ucretCell = dataGridView1.Rows[e.RowIndex].Cells["ucret"];
                DataGridViewCell odendi_miCell = dataGridView1.Rows[e.RowIndex].Cells["odendi_mi"];

                // Hücre değeri null kontrolü ekleyerek
                if (odendi_miCell.Value != null && odendi_miCell.Value.ToString() == "1")
                {
                    fiyattb.Text = "Bu ürün ödendi";
                }
                else if (ucretCell.Value != null)
                {
                    decimal ucret = Convert.ToDecimal(ucretCell.Value.ToString());
                    fiyattb.Text = ucret.ToString() + " TL";
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                // PrintDocument ve PrintPreviewDialog oluştur
                PrintDocument printDocument1 = new PrintDocument();
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

                // PrintPreviewDialog'un PrintDocument özelliğini kullan
                printPreviewDialog.Document = printDocument1;

                // PrintPage olayına PrintDocument_PrintPage metodunu ekle
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);


                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yazdırılacak veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            try
            {
                // Seçili müşterinin adını ve soyadını al

                string tamIsim = comboBox1.Text.ToString();
                DateTime zaman = DateTime.Now;

                // Başlık satırını çiz
                e.Graphics.DrawString($"Müşteri Adı Soyadı: {tamIsim}\n\nTarih  :{zaman}", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(10, 10));

                e.Graphics.DrawString($"\n\n\n{"ID\t"} {"ÖDEME\t"}  {"ÜCRET"}\n", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(10, 50));




                // Verileri çiz
                int y = 70;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string id = row.Cells["id"].Value?.ToString() ?? "";

                    // Ücret değerini decimal olarak al
                    decimal ucretValue = 0;
                    if (decimal.TryParse(row.Cells["ucret"].Value?.ToString(), out ucretValue))
                    {
                        // Decimal değeri string olarak düzenle, virgülden sonra iki basamak göster
                        string ucret = ucretValue.ToString("0.00");

                        string odendiMi = row.Cells["odendi_mi"].Value?.ToString() ?? "";
                        if (odendiMi == "1")
                        {
                            odendiMi = "ÖDENDİ  ";
                        }
                        else
                        {
                            odendiMi = "ÖDENMEDİ";
                        }


                        e.Graphics.DrawString($"\n\n\n{id + "\t"} {odendiMi + "\t"} {ucret}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(10, y));
                        y += 20; // Sonraki satır için Y koordinatını artır
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fiyattb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
       