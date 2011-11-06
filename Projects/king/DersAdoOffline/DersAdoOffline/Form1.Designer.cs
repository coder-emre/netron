namespace DersAdoOffline
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kULLANICIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kULLANICIADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIFREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLKULLANICILARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nETRON08DataSet = new DersAdoOffline.NETRON08DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tBL_KULLANICILARTableAdapter = new DersAdoOffline.NETRON08DataSetTableAdapters.TBL_KULLANICILARTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKULLANICILARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nETRON08DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kULLANICIIDDataGridViewTextBoxColumn,
            this.kULLANICIADIDataGridViewTextBoxColumn,
            this.sIFREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLKULLANICILARBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 127);
            this.dataGridView1.TabIndex = 0;
            // 
            // kULLANICIIDDataGridViewTextBoxColumn
            // 
            this.kULLANICIIDDataGridViewTextBoxColumn.DataPropertyName = "KULLANICIID";
            this.kULLANICIIDDataGridViewTextBoxColumn.HeaderText = "KULLANICIID";
            this.kULLANICIIDDataGridViewTextBoxColumn.Name = "kULLANICIIDDataGridViewTextBoxColumn";
            this.kULLANICIIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kULLANICIADIDataGridViewTextBoxColumn
            // 
            this.kULLANICIADIDataGridViewTextBoxColumn.DataPropertyName = "KULLANICIADI";
            this.kULLANICIADIDataGridViewTextBoxColumn.HeaderText = "KULLANICIADI";
            this.kULLANICIADIDataGridViewTextBoxColumn.Name = "kULLANICIADIDataGridViewTextBoxColumn";
            // 
            // sIFREDataGridViewTextBoxColumn
            // 
            this.sIFREDataGridViewTextBoxColumn.DataPropertyName = "SIFRE";
            this.sIFREDataGridViewTextBoxColumn.HeaderText = "SIFRE";
            this.sIFREDataGridViewTextBoxColumn.Name = "sIFREDataGridViewTextBoxColumn";
            // 
            // tBLKULLANICILARBindingSource
            // 
            this.tBLKULLANICILARBindingSource.DataMember = "TBL_KULLANICILAR";
            this.tBLKULLANICILARBindingSource.DataSource = this.nETRON08DataSet;
            // 
            // nETRON08DataSet
            // 
            this.nETRON08DataSet.DataSetName = "NETRON08DataSet";
            this.nETRON08DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOPLAM KAYIT SAYISI";
            // 
            // tBL_KULLANICILARTableAdapter
            // 
            this.tBL_KULLANICILARTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Ado.net Offline Uygulamaları";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKULLANICILARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nETRON08DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private NETRON08DataSet nETRON08DataSet;
        private System.Windows.Forms.BindingSource tBLKULLANICILARBindingSource;
        private DersAdoOffline.NETRON08DataSetTableAdapters.TBL_KULLANICILARTableAdapter tBL_KULLANICILARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kULLANICIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kULLANICIADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIFREDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

