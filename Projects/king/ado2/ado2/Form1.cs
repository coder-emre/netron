using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ado2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server=MIAMI;database=NETRON08;trusted_connection=yes");
        SqlDataAdapter adp; 
        DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nETRON08DataSet1.TBL_ILCELER' table. You can move, or remove it, as needed.
            this.tBL_ILCELERTableAdapter.Fill(this.nETRON08DataSet1.TBL_ILCELER);
// TODO: This line of code loads data into the 'nETRON08DataSet.TBL_SEHIRLER' table. You can move, or remove it, as needed.
this.tBL_SEHIRLERTableAdapter.Fill(this.nETRON08DataSet.TBL_SEHIRLER);
adp = new SqlDataAdapter("select * FROM TBL_SEHIRLER ORDER BY SEHIRADI", conn);
           
            adp.Fill(ds);
            cmbSehirler.DataSource = ds.Tables[0];
            cmbSehirler.DisplayMember = "SEHIRADI";
            cmbSehirler.ValueMember = "SEHIRID";
            DataRow drow = ds.Tables[0].NewRow();
            drow[0] = "-1";
            drow[1]=("SEÇİNİZ");
            ds.Tables[0].Rows.Add(drow);
            cmbSehirler.SelectedValue = "-1";
            
        }

        private void cmbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds.Tables["dt_ILCELER"]!=null)
            {
                ds.Tables["dt_ILCELER"].Clear(); 
            }

            adp = new SqlDataAdapter("select * FROM TBL_ILCELER WHERE SEHIRID=" + cmbSehirler.SelectedValue + "ORDER BY ILCEADI ", conn);
           
            adp.Fill(ds,"dt_ILCELER");
            cmb_Ilceler.DataSource = ds.Tables["dt_ILCELER"];
            cmb_Ilceler.DisplayMember = "ILCEADI";
            cmb_Ilceler.ValueMember = "ILCEID";
         
        }
    }
}
