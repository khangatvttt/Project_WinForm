using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTVN_Tuan3
{
    public class HocSinhDAO
    {
        DBConnection dbcn = new DBConnection();

        public DataTable Lay()
        {
            return dbcn.Lay("Select * from Hoc_Sinh");
        }
        public void Them(HocSinh Hs)
        {
            try
            {
                if (Hs.MaHS == "" || Hs.HoTen == "" || Hs.QueQuan == "" || Hs.Cmnd == "" || Hs.Email == "" || Hs.SDT == "")
                    throw new ExceptionNotNull();
                if (!(Hs.Email.Contains('.') && Hs.Email.Contains('@')))
                    throw new ExceptionEmail();
                if (Hs.SDT.Length != 10)
                    throw new FormatException();
                int.Parse(Hs.SDT);

                string SQL = string.Format("Insert into Hoc_Sinh(MaHS, HoTen, QueQuan, NgaySinh, CMND, Email, SDT) " +
                    " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                    , Hs.MaHS, Hs.HoTen, Hs.QueQuan, Hs.Ngaysinh.ToString("yyyy/MM/dd"), Hs.Cmnd, Hs.Email, Hs.SDT);
                dbcn.ThucThi(SQL);
            }
            catch (ExceptionNotNull e)
            {
                MessageBox.Show(e.message);
            }
            catch (ExceptionEmail e)
            {
                MessageBox.Show(e.message);
            }
            catch (FormatException)
            {
                MessageBox.Show("SDT không hợp lệ!");
            }
        }
        
        
        public void Xoa(HocSinh Hs)
        {
            string sqlStr = string.Format("DELETE FROM Hoc_Sinh WHERE MaHS='{0}'",Hs.MaHS);
            dbcn.ThucThi(sqlStr);
        }
        
        public void Sua(HocSinh Hs, string MaHS_Sua)
        {
            try
            {
                if (Hs.MaHS == "" || Hs.HoTen == "" || Hs.QueQuan == "" || Hs.Cmnd == "" || Hs.Email == "" || Hs.SDT == "")
                    throw new ExceptionNotNull();
                if (!(Hs.Email.EndsWith("@gmail.com") || Hs.Email.EndsWith("@student.hcmute.edu.vn")))
                    throw new ExceptionEmail();
                if (Hs.SDT.Length != 10)
                    throw new FormatException();
                int.Parse(Hs.SDT);

                string sqlStr =
                string.Format("UPDATE Hoc_Sinh SET MaHS='{0}', HoTen='{1}', QueQuan='{2}'" +
                ", NgaySinh='{3}', CMND='{4}', Email='{5}', SDT='{6}' WHERE MaHS='{7}'"
                     , Hs.MaHS, Hs.HoTen, Hs.QueQuan, Hs.Ngaysinh.ToString("yyyy/MM/dd"), Hs.Cmnd, Hs.Email, Hs.SDT, MaHS_Sua);
                dbcn.ThucThi(sqlStr);
            }
            catch (ExceptionNotNull e)
            {
                MessageBox.Show(e.message);
            }
            catch (ExceptionEmail e)
            {
                MessageBox.Show(e.message);
            }
            catch (FormatException)
            {
                MessageBox.Show("SDT không hợp lệ!");
            }
        }
    }
}
