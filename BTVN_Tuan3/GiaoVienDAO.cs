using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan3
{
    public class GiaoVienDAO
    {
        DBConnection dbcn = new DBConnection();

        public DataTable Lay()
        {
            return dbcn.Lay("Select * from Giao_Vien");
        }
        public void Them(GiaoVien Gv)
        {
            try
            {
                if (Gv.MaGV == "" || Gv.HoTen == "" || Gv.QueQuan == "" || Gv.Cmnd == "" || Gv.Email == "" || Gv.SDT == "")
                    throw new ExceptionNotNull();
                if (!(Gv.Email.Contains('.') && Gv.Email.Contains('@')))
                    throw new ExceptionEmail();
                if (Gv.SDT.Length != 10)
                    throw new FormatException();
                int.Parse(Gv.SDT);

                string SQL = string.Format("Insert into Giao_Vien(MaGv, HoTen, QueQuan, NgaySinh, CMND, Email, SDT) " +
                    " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                    , Gv.MaGV, Gv.HoTen, Gv.QueQuan, Gv.Ngaysinh.ToString("yyyy/MM/dd"), Gv.Cmnd, Gv.Email, Gv.SDT);
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


        public void Xoa(GiaoVien Gv)
        {
            string sqlStr = string.Format("DELETE FROM Giao_Vien WHERE MaGv='{0}'", Gv.MaGV);
            dbcn.ThucThi(sqlStr);
        }

        public void Sua(GiaoVien Gv, string MaGv_Sua)
        {
            try
            {
                if (Gv.MaGV == "" || Gv.HoTen == "" || Gv.QueQuan == "" || Gv.Cmnd == "" || Gv.Email == "" || Gv.SDT == "")
                    throw new ExceptionNotNull();
                if (!(Gv.Email.EndsWith("@gmail.com") || Gv.Email.EndsWith("@student.hcmute.edu.vn")))
                    throw new ExceptionEmail();
                if (Gv.SDT.Length != 10)
                    throw new FormatException();
                int.Parse(Gv.SDT);

                string sqlStr =
                string.Format("UPDATE Giao_Vien SET MaGv='{0}', HoTen='{1}', QueQuan='{2}'" +
                ", NgaySinh='{3}', CMND='{4}', Email='{5}', SDT='{6}' WHERE MaGv='{7}'"
                     , Gv.MaGV, Gv.HoTen, Gv.QueQuan, Gv.Ngaysinh.ToString("yyyy/MM/dd"), Gv.Cmnd, Gv.Email, Gv.SDT, MaGv_Sua);
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
