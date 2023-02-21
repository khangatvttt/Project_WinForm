using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan3
{
    public class DBConnection
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.cnnStr);
        public void ThucThi(string sql)
        {
            try
            {
                conn.Open();
                string sqlStr = sql;

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại!" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable Lay(string sql)
        {
            try
            {
                conn.Open();
                string sqlStr = sql;

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
