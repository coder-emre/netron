namespace KelepirEmlakOfisi
{
    partial class frm_anakelepir
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Musteri Tanimlari");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TANIMLAMALAR", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Emlak Alim / Satim");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("İŞLEMLER", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("İslem Raporu");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Musteri Listesi");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Emlak Listesi");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("RAPORLAR", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_toplamemlak = new System.Windows.Forms.Label();
            this.lbl_toplammusteri = new System.Windows.Forms.Label();
            this.lbl_istatistik = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer_yuklebar = new System.Windows.Forms.Timer(this.components);
            this.pnl_icerik = new System.Windows.Forms.Panel();
            this.pnl_acilis = new System.Windows.Forms.Panel();
            this.lbl_yukleniyor = new System.Windows.Forms.Label();
            this.pbar_acilis = new System.Windows.Forms.ProgressBar();
            this.lbl_musterisayisi = new System.Windows.Forms.Label();
            this.lbl_emlaksayisi = new System.Windows.Forms.Label();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_icerik.SuspendLayout();
            this.pnl_acilis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_menu.Controls.Add(this.lbl_emlaksayisi);
            this.pnl_menu.Controls.Add(this.lbl_musterisayisi);
            this.pnl_menu.Controls.Add(this.pictureBox1);
            this.pnl_menu.Controls.Add(this.lbl_toplamemlak);
            this.pnl_menu.Controls.Add(this.lbl_toplammusteri);
            this.pnl_menu.Controls.Add(this.lbl_istatistik);
            this.pnl_menu.Controls.Add(this.treeView1);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(200, 605);
            this.pnl_menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KelepirEmlakOfisi.Properties.Resources.merlin;
            this.pictureBox1.Location = new System.Drawing.Point(58, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 77);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_toplamemlak
            // 
            this.lbl_toplamemlak.AutoSize = true;
            this.lbl_toplamemlak.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamemlak.ForeColor = System.Drawing.Color.White;
            this.lbl_toplamemlak.Location = new System.Drawing.Point(15, 315);
            this.lbl_toplamemlak.Name = "lbl_toplamemlak";
            this.lbl_toplamemlak.Size = new System.Drawing.Size(143, 13);
            this.lbl_toplamemlak.TabIndex = 3;
            this.lbl_toplamemlak.Text = "Toplam Emlak Sayisi  : ";
            // 
            // lbl_toplammusteri
            // 
            this.lbl_toplammusteri.AutoSize = true;
            this.lbl_toplammusteri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplammusteri.ForeColor = System.Drawing.Color.White;
            this.lbl_toplammusteri.Location = new System.Drawing.Point(13, 293);
            this.lbl_toplammusteri.Name = "lbl_toplammusteri";
            this.lbl_toplammusteri.Size = new System.Drawing.Size(145, 13);
            this.lbl_toplammusteri.TabIndex = 2;
            this.lbl_toplammusteri.Text = "Toplam Musteri Sayisi : ";
            // 
            // lbl_istatistik
            // 
            this.lbl_istatistik.AutoSize = true;
            this.lbl_istatistik.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_istatistik.ForeColor = System.Drawing.Color.White;
            this.lbl_istatistik.Location = new System.Drawing.Point(55, 270);
            this.lbl_istatistik.Name = "lbl_istatistik";
            this.lbl_istatistik.Size = new System.Drawing.Size(82, 13);
            this.lbl_istatistik.TabIndex = 1;
            this.lbl_istatistik.Text = "İSTATİSTİK";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nd_kullanicilar";
            treeNode1.Text = "Musteri Tanimlari";
            treeNode2.Name = "nd_tanimlamalar";
            treeNode2.Text = "TANIMLAMALAR";
            treeNode3.Name = "nd_emlakalimsatim";
            treeNode3.Text = "Emlak Alim / Satim";
            treeNode4.Name = "nd_islemler";
            treeNode4.Text = "İŞLEMLER";
            treeNode5.Name = "nd_islemraporu";
            treeNode5.Text = "İslem Raporu";
            treeNode6.Name = "nd_musterilistesi";
            treeNode6.Text = "Musteri Listesi";
            treeNode7.Name = "nd_emlaklistesi";
            treeNode7.Text = "Emlak Listesi";
            treeNode8.Name = "nd_raporlar";
            treeNode8.Text = "RAPORLAR";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(200, 253);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // timer_yuklebar
            // 
            this.timer_yuklebar.Enabled = true;
            this.timer_yuklebar.Interval = 1000;
            this.timer_yuklebar.Tick += new System.EventHandler(this.timer_yuklebar_Tick);
            // 
            // pnl_icerik
            // 
            this.pnl_icerik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_icerik.Controls.Add(this.pnl_acilis);
            this.pnl_icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_icerik.Location = new System.Drawing.Point(200, 0);
            this.pnl_icerik.Name = "pnl_icerik";
            this.pnl_icerik.Size = new System.Drawing.Size(739, 605);
            this.pnl_icerik.TabIndex = 1;
            // 
            // pnl_acilis
            // 
            this.pnl_acilis.Controls.Add(this.lbl_yukleniyor);
            this.pnl_acilis.Controls.Add(this.pbar_acilis);
            this.pnl_acilis.Location = new System.Drawing.Point(232, 153);
            this.pnl_acilis.Name = "pnl_acilis";
            this.pnl_acilis.Size = new System.Drawing.Size(200, 100);
            this.pnl_acilis.TabIndex = 0;
            // 
            // lbl_yukleniyor
            // 
            this.lbl_yukleniyor.AutoSize = true;
            this.lbl_yukleniyor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yukleniyor.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_yukleniyor.Location = new System.Drawing.Point(58, 31);
            this.lbl_yukleniyor.Name = "lbl_yukleniyor";
            this.lbl_yukleniyor.Size = new System.Drawing.Size(89, 13);
            this.lbl_yukleniyor.TabIndex = 1;
            this.lbl_yukleniyor.Text = "Yukleniyor...";
            // 
            // pbar_acilis
            // 
            this.pbar_acilis.BackColor = System.Drawing.Color.AliceBlue;
            this.pbar_acilis.ForeColor = System.Drawing.Color.Gainsboro;
            this.pbar_acilis.Location = new System.Drawing.Point(13, 47);
            this.pbar_acilis.Maximum = 10;
            this.pbar_acilis.Name = "pbar_acilis";
            this.pbar_acilis.Size = new System.Drawing.Size(174, 23);
            this.pbar_acilis.TabIndex = 0;
            // 
            // lbl_musterisayisi
            // 
            this.lbl_musterisayisi.AutoSize = true;
            this.lbl_musterisayisi.ForeColor = System.Drawing.Color.White;
            this.lbl_musterisayisi.Location = new System.Drawing.Point(153, 293);
            this.lbl_musterisayisi.Name = "lbl_musterisayisi";
            this.lbl_musterisayisi.Size = new System.Drawing.Size(14, 13);
            this.lbl_musterisayisi.TabIndex = 5;
            this.lbl_musterisayisi.Text = "0";
            // 
            // lbl_emlaksayisi
            // 
            this.lbl_emlaksayisi.AutoSize = true;
            this.lbl_emlaksayisi.ForeColor = System.Drawing.Color.White;
            this.lbl_emlaksayisi.Location = new System.Drawing.Point(153, 315);
            this.lbl_emlaksayisi.Name = "lbl_emlaksayisi";
            this.lbl_emlaksayisi.Size = new System.Drawing.Size(14, 13);
            this.lbl_emlaksayisi.TabIndex = 6;
            this.lbl_emlaksayisi.Text = "0";
            // 
            // frm_anakelepir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 605);
            this.Controls.Add(this.pnl_icerik);
            this.Controls.Add(this.pnl_menu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_anakelepir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelepir Emlak Ofisi v0.1";
            this.Load += new System.EventHandler(this.frm_anakelepir_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_icerik.ResumeLayout(false);
            this.pnl_acilis.ResumeLayout(false);
            this.pnl_acilis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_icerik;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lbl_istatistik;
        private System.Windows.Forms.Label lbl_toplammusteri;
        private System.Windows.Forms.Label lbl_toplamemlak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_acilis;
        private System.Windows.Forms.Label lbl_yukleniyor;
        private System.Windows.Forms.ProgressBar pbar_acilis;
        private System.Windows.Forms.Timer timer_yuklebar;
        private System.Windows.Forms.Label lbl_emlaksayisi;
        private System.Windows.Forms.Label lbl_musterisayisi;
    }
}

