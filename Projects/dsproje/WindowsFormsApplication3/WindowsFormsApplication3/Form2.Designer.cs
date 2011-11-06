namespace WindowsFormsApplication3
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.oDEMESEKILLERIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIPARISSATIRLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIPARISBASLIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIPARISKARTLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.oDEMESEKILLERIToolStripMenuItem,
            this.sIPARISSATIRLARIToolStripMenuItem,
            this.sIPARISBASLIKToolStripMenuItem,
            this.sIPARISKARTLARIToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "SECINIZ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem2.Text = "CARILER";
            // 
            // oDEMESEKILLERIToolStripMenuItem
            // 
            this.oDEMESEKILLERIToolStripMenuItem.Name = "oDEMESEKILLERIToolStripMenuItem";
            this.oDEMESEKILLERIToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.oDEMESEKILLERIToolStripMenuItem.Text = "ODEMESEKILLERI";
            // 
            // sIPARISSATIRLARIToolStripMenuItem
            // 
            this.sIPARISSATIRLARIToolStripMenuItem.Name = "sIPARISSATIRLARIToolStripMenuItem";
            this.sIPARISSATIRLARIToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sIPARISSATIRLARIToolStripMenuItem.Text = "SIPARISSATIRLARI";
            // 
            // sIPARISBASLIKToolStripMenuItem
            // 
            this.sIPARISBASLIKToolStripMenuItem.Name = "sIPARISBASLIKToolStripMenuItem";
            this.sIPARISBASLIKToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sIPARISBASLIKToolStripMenuItem.Text = "SIPARISBASLIK";
            // 
            // sIPARISKARTLARIToolStripMenuItem
            // 
            this.sIPARISKARTLARIToolStripMenuItem.DoubleClickEnabled = true;
            this.sIPARISKARTLARIToolStripMenuItem.Name = "sIPARISKARTLARIToolStripMenuItem";
            this.sIPARISKARTLARIToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sIPARISKARTLARIToolStripMenuItem.Text = "SIPARISKARTLARI";
            this.sIPARISKARTLARIToolStripMenuItem.Click += new System.EventHandler(this.sIPARISKARTLARIToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(463, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 256);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oDEMESEKILLERIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIPARISSATIRLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIPARISBASLIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIPARISKARTLARIToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}