namespace WindowsFormsApplication3
{
    partial class Form3
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
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_birimfiyat = new System.Windows.Forms.TextBox();
            this.stokliste = new System.Windows.Forms.DataGridView();
            this.sTOKREFERANSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRIMFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLSTOKKARTLARIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVKURDataSet1 = new WindowsFormsApplication3.EVKURDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.tBL_STOKKARTLARITableAdapter = new WindowsFormsApplication3.EVKURDataSet1TableAdapters.TBL_STOKKARTLARITableAdapter();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stokliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTOKKARTLARIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVKURDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(161, 13);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(138, 20);
            this.txt_aciklama.TabIndex = 0;
            // 
            // txt_birimfiyat
            // 
            this.txt_birimfiyat.Location = new System.Drawing.Point(161, 46);
            this.txt_birimfiyat.Name = "txt_birimfiyat";
            this.txt_birimfiyat.Size = new System.Drawing.Size(138, 20);
            this.txt_birimfiyat.TabIndex = 1;
            // 
            // stokliste
            // 
            this.stokliste.AutoGenerateColumns = false;
            this.stokliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTOKREFERANSDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn,
            this.bIRIMFIYATDataGridViewTextBoxColumn});
            this.stokliste.DataSource = this.tBLSTOKKARTLARIBindingSource;
            this.stokliste.Location = new System.Drawing.Point(31, 105);
            this.stokliste.Name = "stokliste";
            this.stokliste.Size = new System.Drawing.Size(430, 148);
            this.stokliste.TabIndex = 2;
            this.stokliste.SelectionChanged += new System.EventHandler(this.stokliste_SelectionChanged);
            // 
            // sTOKREFERANSDataGridViewTextBoxColumn
            // 
            this.sTOKREFERANSDataGridViewTextBoxColumn.DataPropertyName = "STOKREFERANS";
            this.sTOKREFERANSDataGridViewTextBoxColumn.HeaderText = "STOKREFERANS";
            this.sTOKREFERANSDataGridViewTextBoxColumn.Name = "sTOKREFERANSDataGridViewTextBoxColumn";
            this.sTOKREFERANSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCIKLAMADataGridViewTextBoxColumn
            // 
            this.aCIKLAMADataGridViewTextBoxColumn.DataPropertyName = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.HeaderText = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.Name = "aCIKLAMADataGridViewTextBoxColumn";
            // 
            // bIRIMFIYATDataGridViewTextBoxColumn
            // 
            this.bIRIMFIYATDataGridViewTextBoxColumn.DataPropertyName = "BIRIMFIYAT";
            this.bIRIMFIYATDataGridViewTextBoxColumn.HeaderText = "BIRIMFIYAT";
            this.bIRIMFIYATDataGridViewTextBoxColumn.Name = "bIRIMFIYATDataGridViewTextBoxColumn";
            // 
            // tBLSTOKKARTLARIBindingSource
            // 
            this.tBLSTOKKARTLARIBindingSource.DataMember = "TBL_STOKKARTLARI";
            this.tBLSTOKKARTLARIBindingSource.DataSource = this.eVKURDataSet1;
            // 
            // eVKURDataSet1
            // 
            this.eVKURDataSet1.DataSetName = "EVKURDataSet1";
            this.eVKURDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "STOK ACIKLAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BIRIM FIYAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(317, 72);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // tBL_STOKKARTLARITableAdapter
            // 
            this.tBL_STOKKARTLARITableAdapter.ClearBeforeFill = true;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(399, 72);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 294);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stokliste);
            this.Controls.Add(this.txt_birimfiyat);
            this.Controls.Add(this.txt_aciklama);
            this.Name = "Form3";
            this.Text = "STOK TAKIP";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTOKKARTLARIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVKURDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_birimfiyat;
        private System.Windows.Forms.DataGridView stokliste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kaydet;
        private EVKURDataSet1 eVKURDataSet1;
        private System.Windows.Forms.BindingSource tBLSTOKKARTLARIBindingSource;
        private WindowsFormsApplication3.EVKURDataSet1TableAdapters.TBL_STOKKARTLARITableAdapter tBL_STOKKARTLARITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOKREFERANSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRIMFIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_sil;
    }
}