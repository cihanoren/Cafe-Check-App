namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.adisyonbtn = new System.Windows.Forms.Button();
            this.odemebtn = new System.Windows.Forms.Button();
            this.musterilerbtn = new System.Windows.Forms.Button();
            this.urunlerbtn = new System.Windows.Forms.Button();
            this.kullanicilarbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 106);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.cikisbtn);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.adisyonbtn);
            this.panel1.Controls.Add(this.odemebtn);
            this.panel1.Controls.Add(this.musterilerbtn);
            this.panel1.Controls.Add(this.urunlerbtn);
            this.panel1.Controls.Add(this.kullanicilarbtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(43)))), ((int)(((byte)(31)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 602);
            this.panel1.TabIndex = 0;
            // 
            // cikisbtn
            // 
            this.cikisbtn.AutoSize = true;
            this.cikisbtn.BackColor = System.Drawing.SystemColors.Window;
            this.cikisbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cikisbtn.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cikisbtn.Location = new System.Drawing.Point(0, 426);
            this.cikisbtn.Margin = new System.Windows.Forms.Padding(4);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(242, 64);
            this.cikisbtn.TabIndex = 6;
            this.cikisbtn.Text = "Çıkış           ";
            this.cikisbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cikisbtn.UseVisualStyleBackColor = false;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click_1);
            // 
            // adisyonbtn
            // 
            this.adisyonbtn.AutoSize = true;
            this.adisyonbtn.BackColor = System.Drawing.SystemColors.Window;
            this.adisyonbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adisyonbtn.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adisyonbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.adisyonbtn.Location = new System.Drawing.Point(0, 362);
            this.adisyonbtn.Margin = new System.Windows.Forms.Padding(4);
            this.adisyonbtn.Name = "adisyonbtn";
            this.adisyonbtn.Size = new System.Drawing.Size(242, 64);
            this.adisyonbtn.TabIndex = 5;
            this.adisyonbtn.Text = "Adisyon        ";
            this.adisyonbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adisyonbtn.UseVisualStyleBackColor = false;
            this.adisyonbtn.Click += new System.EventHandler(this.adisyonbtn_Click);
            // 
            // odemebtn
            // 
            this.odemebtn.AutoSize = true;
            this.odemebtn.BackColor = System.Drawing.SystemColors.Window;
            this.odemebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.odemebtn.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.odemebtn.Location = new System.Drawing.Point(0, 298);
            this.odemebtn.Margin = new System.Windows.Forms.Padding(4);
            this.odemebtn.Name = "odemebtn";
            this.odemebtn.Size = new System.Drawing.Size(242, 64);
            this.odemebtn.TabIndex = 4;
            this.odemebtn.Text = "Ödeme        ";
            this.odemebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odemebtn.UseVisualStyleBackColor = false;
            this.odemebtn.Click += new System.EventHandler(this.odemebtn_Click);
            // 
            // musterilerbtn
            // 
            this.musterilerbtn.AutoSize = true;
            this.musterilerbtn.BackColor = System.Drawing.SystemColors.Window;
            this.musterilerbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.musterilerbtn.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musterilerbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.musterilerbtn.Location = new System.Drawing.Point(0, 234);
            this.musterilerbtn.Margin = new System.Windows.Forms.Padding(4);
            this.musterilerbtn.Name = "musterilerbtn";
            this.musterilerbtn.Size = new System.Drawing.Size(242, 64);
            this.musterilerbtn.TabIndex = 3;
            this.musterilerbtn.Text = "Müşteriler      ";
            this.musterilerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musterilerbtn.UseVisualStyleBackColor = false;
            this.musterilerbtn.Click += new System.EventHandler(this.musterilerbtn_Click);
            // 
            // urunlerbtn
            // 
            this.urunlerbtn.AutoSize = true;
            this.urunlerbtn.BackColor = System.Drawing.SystemColors.Window;
            this.urunlerbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.urunlerbtn.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlerbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.urunlerbtn.Location = new System.Drawing.Point(0, 170);
            this.urunlerbtn.Margin = new System.Windows.Forms.Padding(4);
            this.urunlerbtn.Name = "urunlerbtn";
            this.urunlerbtn.Size = new System.Drawing.Size(242, 64);
            this.urunlerbtn.TabIndex = 2;
            this.urunlerbtn.Text = "Ürünler        ";
            this.urunlerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.urunlerbtn.UseVisualStyleBackColor = false;
            this.urunlerbtn.Click += new System.EventHandler(this.urunlerbtn_Click);
            // 
            // kullanicilarbtn
            // 
            this.kullanicilarbtn.AutoSize = true;
            this.kullanicilarbtn.BackColor = System.Drawing.SystemColors.Window;
            this.kullanicilarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kullanicilarbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullanicilarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanicilarbtn.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicilarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.kullanicilarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanicilarbtn.Location = new System.Drawing.Point(0, 106);
            this.kullanicilarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.kullanicilarbtn.Name = "kullanicilarbtn";
            this.kullanicilarbtn.Size = new System.Drawing.Size(242, 64);
            this.kullanicilarbtn.TabIndex = 1;
            this.kullanicilarbtn.Text = "Kullanıcılar    ";
            this.kullanicilarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kullanicilarbtn.UseVisualStyleBackColor = false;
            this.kullanicilarbtn.Click += new System.EventHandler(this.kullanicilarbtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 106);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAFE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(242, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 106);
            this.panel2.TabIndex = 1;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox8.Image = global::CAFE_UYGULAMASI.Properties.Resources.qwe_PhotoRoom_png_PhotoRoom;
            this.pictureBox8.Location = new System.Drawing.Point(848, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(99, 106);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = global::CAFE_UYGULAMASI.Properties.Resources.exit;
            this.pictureBox7.Location = new System.Drawing.Point(0, 428);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(80, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = global::CAFE_UYGULAMASI.Properties.Resources.Background__2_;
            this.pictureBox6.Location = new System.Drawing.Point(0, 364);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = global::CAFE_UYGULAMASI.Properties.Resources.Coffee_shop_logo_on_transparent_background_PNG;
            this.pictureBox2.Location = new System.Drawing.Point(0, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = global::CAFE_UYGULAMASI.Properties.Resources.images;
            this.pictureBox3.Location = new System.Drawing.Point(0, 300);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = global::CAFE_UYGULAMASI.Properties.Resources.Background__5_;
            this.pictureBox4.Location = new System.Drawing.Point(0, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = global::CAFE_UYGULAMASI.Properties.Resources.Background__3_;
            this.pictureBox5.Location = new System.Drawing.Point(0, 172);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CAFE_UYGULAMASI.Properties.Resources.Background__7__PhotoRoom1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button cikisbtn;
        private System.Windows.Forms.Button adisyonbtn;
        private System.Windows.Forms.Button odemebtn;
        private System.Windows.Forms.Button musterilerbtn;
        private System.Windows.Forms.Button urunlerbtn;
        private System.Windows.Forms.Button kullanicilarbtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

