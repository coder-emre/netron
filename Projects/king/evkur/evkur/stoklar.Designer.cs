namespace evkur
{
    partial class stoklar
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
            this.lbl_stokac = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btb_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_stokac
            // 
            this.lbl_stokac.AutoSize = true;
            this.lbl_stokac.Location = new System.Drawing.Point(29, 9);
            this.lbl_stokac.Name = "lbl_stokac";
            this.lbl_stokac.Size = new System.Drawing.Size(94, 13);
            this.lbl_stokac.TabIndex = 0;
            this.lbl_stokac.Text = "Stok Açıklama;";
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(128, 2);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(116, 21);
            this.txt_stok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birim Fiyat;";
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(127, 27);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(116, 21);
            this.txt_money.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 192);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btb_kaydet
            // 
            this.btb_kaydet.Location = new System.Drawing.Point(304, 4);
            this.btb_kaydet.Name = "btb_kaydet";
            this.btb_kaydet.Size = new System.Drawing.Size(87, 23);
            this.btb_kaydet.TabIndex = 5;
            this.btb_kaydet.Text = "Kaydet";
            this.btb_kaydet.UseVisualStyleBackColor = true;
            this.btb_kaydet.Click += new System.EventHandler(this.btb_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(304, 33);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(87, 23);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // stoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 380);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btb_kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.lbl_stokac);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "stoklar";
            this.Text = "stoklar";
            this.Load += new System.EventHandler(this.stoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stokac;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btb_kaydet;
        private System.Windows.Forms.Button btn_sil;
    }
}