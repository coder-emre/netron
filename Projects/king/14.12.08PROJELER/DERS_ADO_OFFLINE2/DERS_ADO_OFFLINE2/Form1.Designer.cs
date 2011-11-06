namespace DERS_ADO_OFFLINE2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sehirler = new System.Windows.Forms.ComboBox();
            this.cmb_ilceler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Gideceğiniz Yeri Seçiniz :";
            // 
            // cmb_sehirler
            // 
            this.cmb_sehirler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sehirler.FormattingEnabled = true;
            this.cmb_sehirler.Location = new System.Drawing.Point(208, 11);
            this.cmb_sehirler.Name = "cmb_sehirler";
            this.cmb_sehirler.Size = new System.Drawing.Size(215, 21);
            this.cmb_sehirler.TabIndex = 1;
            this.cmb_sehirler.SelectedIndexChanged += new System.EventHandler(this.cmb_sehirler_SelectedIndexChanged);
            // 
            // cmb_ilceler
            // 
            this.cmb_ilceler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ilceler.FormattingEnabled = true;
            this.cmb_ilceler.Location = new System.Drawing.Point(208, 38);
            this.cmb_ilceler.Name = "cmb_ilceler";
            this.cmb_ilceler.Size = new System.Drawing.Size(215, 21);
            this.cmb_ilceler.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen Gideceğiniz ilçeyi Seçiniz :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 235);
            this.Controls.Add(this.cmb_ilceler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_sehirler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = ".: Bilet Rezervasyon :.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_sehirler;
        private System.Windows.Forms.ComboBox cmb_ilceler;
        private System.Windows.Forms.Label label2;
    }
}

