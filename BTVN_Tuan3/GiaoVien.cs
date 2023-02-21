using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan3
{
    public class GiaoVien
    {
        public string MaGV;
        public string HoTen;
        public string QueQuan;
        public DateTime Ngaysinh;
        public string Cmnd;
        public string Email;
        public string SDT;
        public GiaoVien(string maGV, string hoTen, string queQuan, DateTime ngaysinh, string cmnd, string email, string sDT)
        {
            MaGV = maGV;
            HoTen = hoTen;
            QueQuan = queQuan;
            Ngaysinh = ngaysinh;
            Cmnd = cmnd;
            Email = email;
            SDT = sDT;
        }
    }
}
