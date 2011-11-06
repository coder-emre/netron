namespace KelepirEmlakOfisi.Kontroller
{
    partial class UC_Musteriler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_eksiksiz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.grp_kisisel = new System.Windows.Forms.GroupBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.cmd_semt = new System.Windows.Forms.ComboBox();
            this.lbl_semt = new System.Windows.Forms.Label();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.lbl_sehir = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.lbl_aranacak = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.lsw_musteriler = new System.Windows.Forms.ListView();
            this.Referans = new System.Windows.Forms.ColumnHeader();
            this.AdSoyad = new System.Windows.Forms.ColumnHeader();
            this.Sehir = new System.Windows.Forms.ColumnHeader();
            this.Semt = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_kisisel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lbl_eksiksiz);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 104);
            this.panel1.TabIndex = 0;
            // 
            // lbl_eksiksiz
            // 
            this.lbl_eksiksiz.AutoSize = true;
            this.lbl_eksiksiz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eksiksiz.Location = new System.Drawing.Point(273, 44);
            this.lbl_eksiksiz.Name = "lbl_eksiksiz";
            this.lbl_eksiksiz.Size = new System.Drawing.Size(274, 16);
            this.lbl_eksiksiz.TabIndex = 1;
            this.lbl_eksiksiz.Text = "LÜTFEN BİLGİLERİ EKSİKSİZ GİRİNİZ!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KelepirEmlakOfisi.Properties.Resources.connected_multiple_big;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_yeni
            // 
            this.btn_yeni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni.Location = new System.Drawing.Point(3, 110);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(87, 23);
            this.btn_yeni.TabIndex = 1;
            this.btn_yeni.Text = "Yeni";
            this.btn_yeni.UseVisualStyleBackColor = true;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(98, 110);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(87, 23);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // grp_kisisel
            // 
            this.grp_kisisel.Controls.Add(this.lbl_adres);
            this.grp_kisisel.Controls.Add(this.txt_adres);
            this.grp_kisisel.Controls.Add(this.cmd_semt);
            this.grp_kisisel.Controls.Add(this.lbl_semt);
            this.grp_kisisel.Controls.Add(this.cmb_sehir);
            this.grp_kisisel.Controls.Add(this.txt_telefon);
            this.grp_kisisel.Controls.Add(this.txt_adsoyad);
            this.grp_kisisel.Controls.Add(this.lbl_sehir);
            this.grp_kisisel.Controls.Add(this.lbl_telefon);
            this.grp_kisisel.Controls.Add(this.lbl_adsoyad);
            this.grp_kisisel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_kisisel.Location = new System.Drawing.Point(5, 138);
            this.grp_kisisel.Name = "grp_kisisel";
            this.grp_kisisel.Size = new System.Drawing.Size(715, 246);
            this.grp_kisisel.TabIndex = 3;
            this.grp_kisisel.TabStop = false;
            this.grp_kisisel.Text = "Kişisel Bilgiler";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(58, 158);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(40, 13);
            this.lbl_adres.TabIndex = 9;
            this.lbl_adres.Text = "Adres";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(142, 155);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(567, 85);
            this.txt_adres.TabIndex = 8;
            // 
            // cmd_semt
            // 
            this.cmd_semt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_semt.FormattingEnabled = true;
            this.cmd_semt.Location = new System.Drawing.Point(142, 127);
            this.cmd_semt.Name = "cmd_semt";
            this.cmd_semt.Size = new System.Drawing.Size(265, 21);
            this.cmd_semt.TabIndex = 7;
            // 
            // lbl_semt
            // 
            this.lbl_semt.AutoSize = true;
            this.lbl_semt.Location = new System.Drawing.Point(58, 130);
            this.lbl_semt.Name = "lbl_semt";
            this.lbl_semt.Size = new System.Drawing.Size(37, 13);
            this.lbl_semt.TabIndex = 6;
            this.lbl_semt.Text = "Semt";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Location = new System.Drawing.Point(142, 100);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(265, 21);
            this.cmb_sehir.TabIndex = 5;
            this.cmb_sehir.SelectedIndexChanged += new System.EventHandler(this.cmb_sehir_SelectedIndexChanged);
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(142, 69);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(265, 21);
            this.txt_telefon.TabIndex = 4;
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Location = new System.Drawing.Point(142, 41);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(265, 21);
            this.txt_adsoyad.TabIndex = 3;
            // 
            // lbl_sehir
            // 
            this.lbl_sehir.AutoSize = true;
            this.lbl_sehir.Location = new System.Drawing.Point(58, 103);
            this.lbl_sehir.Name = "lbl_sehir";
            this.lbl_sehir.Size = new System.Drawing.Size(37, 13);
            this.lbl_sehir.TabIndex = 2;
            this.lbl_sehir.Text = "Şehir";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(58, 72);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 1;
            this.lbl_telefon.Text = "Telefon";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(58, 44);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(62, 13);
            this.lbl_adsoyad.TabIndex = 0;
            this.lbl_adsoyad.Text = "Ad Soyad";
            // 
            // lbl_aranacak
            // 
            this.lbl_aranacak.AutoSize = true;
            this.lbl_aranacak.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aranacak.Location = new System.Drawing.Point(26, 413);
            this.lbl_aranacak.Name = "lbl_aranacak";
            this.lbl_aranacak.Size = new System.Drawing.Size(120, 13);
            this.lbl_aranacak.TabIndex = 4;
            this.lbl_aranacak.Text = "Aranacak Ad Soyad";
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(147, 410);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(567, 21);
            this.txt_ara.TabIndex = 5;
            // 
            // lsw_musteriler
            // 
            this.lsw_musteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Referans,
            this.AdSoyad,
            this.Sehir,
            this.Semt});
            this.lsw_musteriler.GridLines = true;
            this.lsw_musteriler.Location = new System.Drawing.Point(147, 437);
            this.lsw_musteriler.Name = "lsw_musteriler";
            this.lsw_musteriler.Size = new System.Drawing.Size(567, 144);
            this.lsw_musteriler.TabIndex = 6;
            this.lsw_musteriler.UseCompatibleStateImageBehavior = false;
            this.lsw_musteriler.View = System.Windows.Forms.View.Details;
            // 
            // Referans
            // 
            this.Referans.Text = "Referans";
            this.Referans.Width = 74;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Text = "Ad Soyad";
            this.AdSoyad.Width = 146;
            // 
            // Sehir
            // 
            this.Sehir.Text = "Sehir";
            this.Sehir.Width = 139;
            // 
            // Semt
            // 
            this.Semt.Text = "Semt";
            this.Semt.Width = 203;
            // 
            // UC_Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lsw_musteriler);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.lbl_aranacak);
            this.Controls.Add(this.grp_kisisel);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_yeni);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UC_Musteriler";
            this.Size = new System.Drawing.Size(720, 591);
            this.Load += new System.EventHandler(this.UC_Musteriler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_kisisel.ResumeLayout(false);
            this.grp_kisisel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_eksiksiz;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.GroupBox grp_kisisel;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.ComboBox cmd_semt;
        private System.Windows.Forms.Label lbl_semt;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.Label lbl_sehir;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label lbl_aranacak;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.ListView lsw_musteriler;
        private System.Windows.Forms.ColumnHeader Referans;
        private System.Windows.Forms.ColumnHeader AdSoyad;
        private System.Windows.Forms.ColumnHeader Sehir;
        private System.Windows.Forms.ColumnHeader Semt;
    }
}
