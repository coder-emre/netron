namespace AdoOrnek_KullaniciGiris
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_kontrol_ad = new System.Windows.Forms.TextBox();
            this.txt_kontrol_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_kullaniciislemleri = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lst_kullaniciListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_kodu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grp_kullaniciislemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(268, 74);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_kontrol_ad
            // 
            this.txt_kontrol_ad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kontrol_ad.Location = new System.Drawing.Point(187, 20);
            this.txt_kontrol_ad.Name = "txt_kontrol_ad";
            this.txt_kontrol_ad.Size = new System.Drawing.Size(156, 21);
            this.txt_kontrol_ad.TabIndex = 1;
            // 
            // txt_kontrol_sifre
            // 
            this.txt_kontrol_sifre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kontrol_sifre.Location = new System.Drawing.Point(187, 47);
            this.txt_kontrol_sifre.Name = "txt_kontrol_sifre";
            this.txt_kontrol_sifre.PasswordChar = '*';
            this.txt_kontrol_sifre.Size = new System.Drawing.Size(156, 21);
            this.txt_kontrol_sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EKRANLARI AKTİF YAPMAK İÇİN KULLANICI BİLGİLERİNİ GİRİNİZ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_kontrol_ad);
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kontrol_sifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GÜVENLİK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(138, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // grp_kullaniciislemleri
            // 
            this.grp_kullaniciislemleri.Controls.Add(this.label11);
            this.grp_kullaniciislemleri.Controls.Add(this.txt_kodu);
            this.grp_kullaniciislemleri.Controls.Add(this.label12);
            this.grp_kullaniciislemleri.Controls.Add(this.button1);
            this.grp_kullaniciislemleri.Controls.Add(this.btn_kaydet);
            this.grp_kullaniciislemleri.Controls.Add(this.lst_kullaniciListe);
            this.grp_kullaniciislemleri.Controls.Add(this.txt_arama);
            this.grp_kullaniciislemleri.Controls.Add(this.label10);
            this.grp_kullaniciislemleri.Controls.Add(this.label6);
            this.grp_kullaniciislemleri.Controls.Add(this.label7);
            this.grp_kullaniciislemleri.Controls.Add(this.txt_adi);
            this.grp_kullaniciislemleri.Controls.Add(this.btn_sil);
            this.grp_kullaniciislemleri.Controls.Add(this.label8);
            this.grp_kullaniciislemleri.Controls.Add(this.txt_sifre);
            this.grp_kullaniciislemleri.Controls.Add(this.label9);
            this.grp_kullaniciislemleri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_kullaniciislemleri.Location = new System.Drawing.Point(7, 157);
            this.grp_kullaniciislemleri.Name = "grp_kullaniciislemleri";
            this.grp_kullaniciislemleri.Size = new System.Drawing.Size(432, 350);
            this.grp_kullaniciislemleri.TabIndex = 7;
            this.grp_kullaniciislemleri.TabStop = false;
            this.grp_kullaniciislemleri.Text = "KULLANICI İŞLEMLERİ";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(267, 108);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lst_kullaniciListe
            // 
            this.lst_kullaniciListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lst_kullaniciListe.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kullaniciListe.FullRowSelect = true;
            this.lst_kullaniciListe.GridLines = true;
            this.lst_kullaniciListe.Location = new System.Drawing.Point(14, 180);
            this.lst_kullaniciListe.Name = "lst_kullaniciListe";
            this.lst_kullaniciListe.Size = new System.Drawing.Size(411, 159);
            this.lst_kullaniciListe.TabIndex = 10;
            this.lst_kullaniciListe.UseCompatibleStateImageBehavior = false;
            this.lst_kullaniciListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KULLANICI ADI";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ŞİFRE";
            this.columnHeader2.Width = 170;
            // 
            // txt_arama
            // 
            this.txt_arama.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_arama.Location = new System.Drawing.Point(186, 144);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(235, 21);
            this.txt_arama.TabIndex = 8;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "ARANACAK KELİMEYİ GİRİNİZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(138, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(138, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = ":";
            // 
            // txt_adi
            // 
            this.txt_adi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Location = new System.Drawing.Point(187, 54);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(156, 21);
            this.txt_adi.TabIndex = 1;
            // 
            // btn_sil
            // 
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(348, 108);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ŞİFRE";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(187, 81);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(156, 21);
            this.txt_sifre.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(35, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "KULLANICI ADI";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KODU";
            this.columnHeader3.Width = 72;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(186, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "YENİ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(137, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = ":";
            // 
            // txt_kodu
            // 
            this.txt_kodu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kodu.Location = new System.Drawing.Point(186, 27);
            this.txt_kodu.Name = "txt_kodu";
            this.txt_kodu.Size = new System.Drawing.Size(156, 21);
            this.txt_kodu.TabIndex = 13;
            this.txt_kodu.Text = "-1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(34, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "KULLANICI KODU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 514);
            this.Controls.Add(this.grp_kullaniciislemleri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: KULLANICI İŞLEMLERİ :.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_kullaniciislemleri.ResumeLayout(false);
            this.grp_kullaniciislemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_kontrol_ad;
        private System.Windows.Forms.TextBox txt_kontrol_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grp_kullaniciislemleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ListView lst_kullaniciListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_kodu;
        private System.Windows.Forms.Label label12;
    }
}

