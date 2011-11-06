namespace Ders_AbstractUye
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kitapkaydet = new System.Windows.Forms.Button();
            this.txt_kitap = new System.Windows.Forms.TextBox();
            this.txt_kitapyazari = new System.Windows.Forms.TextBox();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.btn_yazarkaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(312, 147);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_kitapyazari);
            this.tabPage1.Controls.Add(this.txt_kitap);
            this.tabPage1.Controls.Add(this.btn_kitapkaydet);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_yazar);
            this.tabPage2.Controls.Add(this.btn_yazarkaydet);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(304, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yazarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "YAZAR";
            // 
            // btn_kitapkaydet
            // 
            this.btn_kitapkaydet.Location = new System.Drawing.Point(176, 66);
            this.btn_kitapkaydet.Name = "btn_kitapkaydet";
            this.btn_kitapkaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kitapkaydet.TabIndex = 4;
            this.btn_kitapkaydet.Text = "KAYDET";
            this.btn_kitapkaydet.UseVisualStyleBackColor = true;
            // 
            // txt_kitap
            // 
            this.txt_kitap.Location = new System.Drawing.Point(87, 18);
            this.txt_kitap.Name = "txt_kitap";
            this.txt_kitap.Size = new System.Drawing.Size(164, 21);
            this.txt_kitap.TabIndex = 5;
            // 
            // txt_kitapyazari
            // 
            this.txt_kitapyazari.Location = new System.Drawing.Point(87, 39);
            this.txt_kitapyazari.Name = "txt_kitapyazari";
            this.txt_kitapyazari.Size = new System.Drawing.Size(164, 21);
            this.txt_kitapyazari.TabIndex = 6;
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(82, 21);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(164, 21);
            this.txt_yazar.TabIndex = 10;
            // 
            // btn_yazarkaydet
            // 
            this.btn_yazarkaydet.Location = new System.Drawing.Point(171, 48);
            this.btn_yazarkaydet.Name = "btn_yazarkaydet";
            this.btn_yazarkaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_yazarkaydet.TabIndex = 9;
            this.btn_yazarkaydet.Text = "KAYDET";
            this.btn_yazarkaydet.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "YAZAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 147);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = ".: KIRTASIYE :.";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_kitapyazari;
        private System.Windows.Forms.TextBox txt_kitap;
        private System.Windows.Forms.Button btn_kitapkaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Button btn_yazarkaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

