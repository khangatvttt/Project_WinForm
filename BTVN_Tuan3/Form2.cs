using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Tuan3
{
    public partial class F_GiaoVien : Form
    {
        public string MaGV_Sua;
        public F_GiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien Gv = new GiaoVien(txtMaGV.Text, txtHoTen.Text, txtQue.Text,
                                                dtpNgaySinh.Value.Date, txtCmnd.Text, txtEmail.Text, txtSDT.Text);
            GiaoVienDAO GvDAO = new GiaoVienDAO();
            GvDAO.Them(Gv);
            foreach (Control txt in this.Controls)
                if (txt.GetType() == typeof(TextBox))
                    txt.Text = "";
            Form2_Load(sender, e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GiaoVienDAO GvDAO = new GiaoVienDAO();
            dtgvGv.DataSource = GvDAO.Lay();
        }

        private void dtgvGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaGV.Text = dtgvGv.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dtgvGv.Rows[row].Cells[1].Value.ToString();
            txtQue.Text = dtgvGv.Rows[row].Cells[2].Value.ToString();
            txtCmnd.Text = dtgvGv.Rows[row].Cells[4].Value.ToString();
            txtEmail.Text = dtgvGv.Rows[row].Cells[5].Value.ToString();
            txtSDT.Text = dtgvGv.Rows[row].Cells[6].Value.ToString();
            MaGV_Sua = txtMaGV.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien Gv = new GiaoVien(txtMaGV.Text, txtHoTen.Text, txtQue.Text,
                                                dtpNgaySinh.Value.Date, txtCmnd.Text, txtEmail.Text, txtSDT.Text);
            GiaoVienDAO GvDAO = new GiaoVienDAO();
            GvDAO.Xoa(Gv);
            foreach (Control txt in this.Controls)
                if (txt.GetType() == typeof(TextBox))
                    txt.Text = "";
            Form2_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien Gv = new GiaoVien(txtMaGV.Text, txtHoTen.Text, txtQue.Text,
                                                dtpNgaySinh.Value.Date, txtCmnd.Text, txtEmail.Text, txtSDT.Text);
            GiaoVienDAO GvDAO = new GiaoVienDAO();
            GvDAO.Sua(Gv, MaGV_Sua);
            foreach (Control txt in this.Controls)
                if (txt.GetType() == typeof(TextBox))
                    txt.Text = "";
            Form2_Load(sender, e);
        }
    }
}
