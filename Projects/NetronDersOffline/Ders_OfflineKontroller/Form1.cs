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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog()==DialogResult.OK)
            {
                txt_MusteriResmi.Text = OFD.FileName.ToString();
                //pictureBox1.Image = Image.FromFile(txt_MusteriResmi.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)//Sol ok tusuna basıldığında
            {
                //Eğer geçerli pozisyon toplam kayıt sayısına eşit veya küçükse
                //if (siparisBaslikBindingSource.Position <= siparisBaslikBindingSource.Count)
                //{
                    siparisBaslikBindingSource.MovePrevious();//Bir önceki kayda git
                //}   
            }
            else if (e.KeyCode==Keys.Right)//Basılan tuş sağ ok ise
            {
                //if (siparisBaslikBindingSource.Position>=0)//geçerli pozisyon 0. kayıt veya üzerinde ise
                //{
                    siparisBaslikBindingSource.MoveNext();//Bir sonra ki kayda git
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frmFilmler = new Form2();
            frmFilmler.Show();
        }
    }
}
