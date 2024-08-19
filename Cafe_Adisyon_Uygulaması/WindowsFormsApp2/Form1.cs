using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void kullanicilarbtn_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri.FormAc(this, new Kullanıcılar());
        }

        private void urunlerbtn_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri.FormAc(this, new Urunler());
        }

        private void musterilerbtn_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri.FormAc(this, new Musteriler());
        }

        private void odemebtn_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri.FormAc(this, new Odeme());
        }

        private void adisyonbtn_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri.FormAc(this, new Adisyon());
        }

        private void cikisbtn_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Adisyon adisyon = new Adisyon();
            Odeme odeme = new Odeme();
            Urunler urunler = new Urunler();


            if (!adisyon.IsDisposed)
            {
                VeritabaniIslemleri.FormAcKapat(adisyon);
                VeritabaniIslemleri.FormAc(this, new Adisyon());
                VeritabaniIslemleri.FormAcKapat(adisyon);
            }

            if (!odeme.IsDisposed)
            {
                VeritabaniIslemleri.FormAcKapat(odeme);

                VeritabaniIslemleri.FormAc(this, new Odeme());
                VeritabaniIslemleri.FormAcKapat(odeme);

            }

            if (!urunler.IsDisposed)
            {
                VeritabaniIslemleri.FormAcKapat(urunler);
                VeritabaniIslemleri.FormAc(this, new Urunler());
                VeritabaniIslemleri.FormAcKapat(urunler);
            }

            Form1 form1 = new Form1();
            form1.Show();


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            Adisyon adisyon = new Adisyon();
            Odeme odeme = new Odeme();
            Urunler urunler = new Urunler();


            if (!adisyon.IsDisposed)
            {
                VeritabaniIslemleri.FormAcKapat(adisyon);
                VeritabaniIslemleri.FormAc(this, new Adisyon());
                VeritabaniIslemleri.FormAcKapat(adisyon);
            }

            if (!odeme.IsDisposed)
            {
                VeritabaniIslemleri.FormAcKapat(odeme);

                VeritabaniIslemleri.FormAc(this, new Odeme());
                VeritabaniIslemleri.FormAcKapat(odeme);

            }

            if (!urunler.IsDisposed)
            {
                VeritabaniIslemleri.FormAcKapat(urunler);
                VeritabaniIslemleri.FormAc(this, new Urunler());
                VeritabaniIslemleri.FormAcKapat(urunler);
            }

            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
