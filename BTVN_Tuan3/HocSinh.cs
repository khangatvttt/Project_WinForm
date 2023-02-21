using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan3
{
    public class HocSinh
    {
        public string MaHS;
        public string HoTen;
        public string QueQuan;
        public DateTime Ngaysinh;
        public string Cmnd;
        public string Email;
        public string SDT;
        public HocSinh(string maHS, string hoTen, string queQuan, DateTime ngaysinh, string cmnd, string email, string sDT)
        {
            MaHS = maHS;
            HoTen = hoTen;
            QueQuan = queQuan;
            Ngaysinh = ngaysinh;
            Cmnd = cmnd;
            Email = email;
            SDT = sDT;
        }
    }
}
