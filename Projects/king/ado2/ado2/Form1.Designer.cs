namespace ado2
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
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.nETRON08DataSet = new ado2.NETRON08DataSet();
            this.tBLSEHIRLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SEHIRLERTableAdapter = new ado2.NETRON08DataSetTableAdapters.TBL_SEHIRLERTableAdapter();
            this.cmb_Ilceler = new System.Windows.Forms.ComboBox();
            this.nETRON08DataSet1 = new ado2.NETRON08DataSet1();
            this.tBLILCELERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_ILCELERTableAdapter = new ado2.NETRON08DataSet1TableAdapters.TBL_ILCELERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nETRON08DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSEHIRLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nETRON08DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLILCELERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.DataSource = this.tBLSEHIRLERBindingSource;
            this.cmbSehirler.DisplayMember = "SEHIRADI";
            this.cmbSehirler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Location = new System.Drawing.Point(12, 26);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(137, 21);
            this.cmbSehirler.TabIndex = 0;
            this.cmbSehirler.ValueMember = "SEHIRID";
            this.cmbSehirler.SelectedIndexChanged += new System.EventHandler(this.cmbSehirler_SelectedIndexChanged);
            // 
            // nETRON08DataSet
            // 
            this.nETRON08DataSet.DataSetName = "NETRON08DataSet";
            this.nETRON08DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSEHIRLERBindingSource
            // 
            this.tBLSEHIRLERBindingSource.DataMember = "TBL_SEHIRLER";
            this.tBLSEHIRLERBindingSource.DataSource = this.nETRON08DataSet;
            // 
            // tBL_SEHIRLERTableAdapter
            // 
            this.tBL_SEHIRLERTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_Ilceler
            // 
            this.cmb_Ilceler.DataSource = this.tBLILCELERBindingSource;
            this.cmb_Ilceler.DisplayMember = "ILCEADI";
            this.cmb_Ilceler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ilceler.FormattingEnabled = true;
            this.cmb_Ilceler.Location = new System.Drawing.Point(96, 67);
            this.cmb_Ilceler.Name = "cmb_Ilceler";
            this.cmb_Ilceler.Size = new System.Drawing.Size(137, 21);
            this.cmb_Ilceler.TabIndex = 1;
            this.cmb_Ilceler.ValueMember = "ILCEID";
            // 
            // nETRON08DataSet1
            // 
            this.nETRON08DataSet1.DataSetName = "NETRON08DataSet1";
            this.nETRON08DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLILCELERBindingSource
            // 
            this.tBLILCELERBindingSource.DataMember = "TBL_ILCELER";
            this.tBLILCELERBindingSource.DataSource = this.nETRON08DataSet1;
            // 
            // tBL_ILCELERTableAdapter
            // 
            this.tBL_ILCELERTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 117);
            this.Controls.Add(this.cmb_Ilceler);
            this.Controls.Add(this.cmbSehirler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nETRON08DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSEHIRLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nETRON08DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLILCELERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSehirler;
        private NETRON08DataSet nETRON08DataSet;
        private System.Windows.Forms.BindingSource tBLSEHIRLERBindingSource;
        private ado2.NETRON08DataSetTableAdapters.TBL_SEHIRLERTableAdapter tBL_SEHIRLERTableAdapter;
        private System.Windows.Forms.ComboBox cmb_Ilceler;
        private NETRON08DataSet1 nETRON08DataSet1;
        private System.Windows.Forms.BindingSource tBLILCELERBindingSource;
        private ado2.NETRON08DataSet1TableAdapters.TBL_ILCELERTableAdapter tBL_ILCELERTableAdapter;
    }
}

