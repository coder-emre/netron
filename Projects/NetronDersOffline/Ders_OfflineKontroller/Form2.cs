using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ders_OfflineKontroller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAHMUTDBDataSet.OYUNCULAR' table. You can move, or remove it, as needed.
            this.oYUNCULARTableAdapter.Fill(this.mAHMUTDBDataSet.OYUNCULAR);
            // TODO: This line of code loads data into the 'mAHMUTDBDataSet.FILMLER' table. You can move, or remove it, as needed.
            this.fILMLERTableAdapter.Fill(this.mAHMUTDBDataSet.FILMLER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fILMLERBindingSource.EndEdit();
            fILMLERTableAdapter.Update(this.mAHMUTDBDataSet.FILMLER);
            MessageBox.Show("Eşleştirme işlemi başarıyla sonlanmıştır");











        }
    }
}
