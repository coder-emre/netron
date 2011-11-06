namespace Ders_AdonetOffline
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
            this.dg_Kitaplar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Kitap = new System.Windows.Forms.TextBox();
            this.txt_Yazar = new System.Windows.Forms.TextBox();
            this.txt_Yayinevi = new System.Windows.Forms.TextBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Arama = new System.Windows.Forms.TextBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.lbl_KitapID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Kitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Kitaplar
            // 
            this.dg_Kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Kitaplar.Location = new System.Drawing.Point(14, 30);
            this.dg_Kitaplar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_Kitaplar.Name = "dg_Kitaplar";
            this.dg_Kitaplar.Size = new System.Drawing.Size(674, 131);
            this.dg_Kitaplar.TabIndex = 0;
            this.dg_Kitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Kitaplar_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "VERİTABANI İLE EŞLEŞTİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Kitap
            // 
            this.txt_Kitap.Location = new System.Drawing.Point(84, 171);
            this.txt_Kitap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Kitap.Name = "txt_Kitap";
            this.txt_Kitap.Size = new System.Drawing.Size(163, 21);
            this.txt_Kitap.TabIndex = 2;
            // 
            // txt_Yazar
            // 
            this.txt_Yazar.Location = new System.Drawing.Point(84, 193);
            this.txt_Yazar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Yazar.Name = "txt_Yazar";
            this.txt_Yazar.Size = new System.Drawing.Size(163, 21);
            this.txt_Yazar.TabIndex = 3;
            // 
            // txt_Yayinevi
            // 
            this.txt_Yayinevi.Location = new System.Drawing.Point(84, 216);
            this.txt_Yayinevi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Yayinevi.Name = "txt_Yayinevi";
            this.txt_Yayinevi.Size = new System.Drawing.Size(163, 21);
            this.txt_Yayinevi.TabIndex = 4;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(84, 239);
            this.txt_Fiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(163, 21);
            this.txt_Fiyat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "KITAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "YAZAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "YAYINEVİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FİYAT";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(84, 266);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(88, 23);
            this.btn_Kaydet.TabIndex = 10;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aranacak Kelime";
            // 
            // txt_Arama
            // 
            this.txt_Arama.Location = new System.Drawing.Point(124, 5);
            this.txt_Arama.Name = "txt_Arama";
            this.txt_Arama.Size = new System.Drawing.Size(296, 21);
            this.txt_Arama.TabIndex = 12;
            this.txt_Arama.TextChanged += new System.EventHandler(this.txt_Arama_TextChanged);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(180, 266);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(88, 23);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(276, 266);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(88, 23);
            this.btn_Sil.TabIndex = 14;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Location = new System.Drawing.Point(426, 13);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(41, 13);
            this.lbl_Sonuc.TabIndex = 15;
            this.lbl_Sonuc.Text = "label6";
            // 
            // lbl_KitapID
            // 
            this.lbl_KitapID.AutoSize = true;
            this.lbl_KitapID.Location = new System.Drawing.Point(255, 171);
            this.lbl_KitapID.Name = "lbl_KitapID";
            this.lbl_KitapID.Size = new System.Drawing.Size(19, 13);
            this.lbl_KitapID.TabIndex = 16;
            this.lbl_KitapID.Text = "-1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_KitapID);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.txt_Arama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.txt_Yayinevi);
            this.Controls.Add(this.txt_Yazar);
            this.Controls.Add(this.txt_Kitap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_Kitaplar);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Azim Kitapçılık";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Kitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Kitaplar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Kitap;
        private System.Windows.Forms.TextBox txt_Yazar;
        private System.Windows.Forms.TextBox txt_Yayinevi;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Arama;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label lbl_Sonuc;
        private System.Windows.Forms.Label lbl_KitapID;
        private System.Windows.Forms.Button button2;
    }
}

