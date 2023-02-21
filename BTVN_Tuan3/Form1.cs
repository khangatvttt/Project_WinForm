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
    public partial class F_HocSinh : Form
    {
        public string MaHS_Sua;
        public F_HocSinh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh Hs = new HocSinh(txtMaHS.Text, txtHoTen.Text, txtQue.Text,
                                                dtpNgaySinh.Value.Date, txtCmnd.Text, txtEmail.Text, txtSDT.Text);
            HocSinhDAO HsDAO = new HocSinhDAO();
            HsDAO.Them(Hs);
            foreach (Control txt in this.Controls)
                if (txt.GetType() == typeof(TextBox))
                    txt.Text = "";
            Form1_Load(sender,e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HocSinhDAO HsDAO = new HocSinhDAO();
            dtgvHS.DataSource = HsDAO.Lay();
        }

        private void dtgvHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaHS.Text = dtgvHS.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dtgvHS.Rows[row].Cells[1].Value.ToString();
            txtQue.Text = dtgvHS.Rows[row].Cells[2].Value.ToString();
            txtCmnd.Text = dtgvHS.Rows[row].Cells[4].Value.ToString();
            txtEmail.Text = dtgvHS.Rows[row].Cells[5].Value.ToString();
            txtSDT.Text = dtgvHS.Rows[row].Cells[6].Value.ToString();
            MaHS_Sua = txtMaHS.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh Hs = new HocSinh(txtMaHS.Text, txtHoTen.Text, txtQue.Text,
                                                dtpNgaySinh.Value.Date, txtCmnd.Text, txtEmail.Text, txtSDT.Text);
            HocSinhDAO HsDAO = new HocSinhDAO();
            HsDAO.Xoa(Hs);
            foreach (Control txt in this.Controls)
                if (txt.GetType() == typeof(TextBox))
                    txt.Text = "";
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh Hs = new HocSinh(txtMaHS.Text, txtHoTen.Text, txtQue.Text,
                                                dtpNgaySinh.Value.Date, txtCmnd.Text, txtEmail.Text, txtSDT.Text);
            HocSinhDAO HsDAO = new HocSinhDAO();
            HsDAO.Sua(Hs, MaHS_Sua);
            foreach (Control txt in this.Controls)
                if (txt.GetType() == typeof(TextBox))
                    txt.Text = "";
            Form1_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var F_GiaoVien = new F_GiaoVien();
            F_GiaoVien.Show();
        }
    }
}
