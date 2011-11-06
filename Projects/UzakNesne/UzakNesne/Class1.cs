using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace UzakNesne
{
    public class magazalar:System.MarshalByRefObject
    {
        SqlConnection conn = new SqlConnection("Server=.;Database=YazilimWorks;Trusted_connection=yes");
        public string MagazaYetkili(string magazaAdi)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_MagazaYetkilisi", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magazaAdi", magazaAdi);
            string YetkiliAdi = cmd.ExecuteScalar().ToString();
            conn.Close();

            return YetkiliAdi;

        }
    }
}
