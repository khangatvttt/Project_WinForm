using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan3
{
    public class ExceptionNotNull : ApplicationException
    {
        public string message="Dữ liệu không được để trống!";
    }

    public class ExceptionEmail : ApplicationException
    {
        public string message = "Email không hợp lệ!";
    }

}
