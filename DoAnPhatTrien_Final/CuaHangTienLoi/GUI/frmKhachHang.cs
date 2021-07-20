using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BAL;

namespace GUI
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        Khach_DAL_BAL khach = new Khach_DAL_BAL();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtsdt.Text.Trim().Length == 10 && txtten.Text != "" && txtdiachi.Text != "")
            {

                if (khach.themKH(txtten.Text, txtsdt.Text, txtdiachi.Text))
                {
                    MessageBox.Show("Đã thêm khách hàng mới");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khach.xoaKH(txtsdt.Text))
            {
                MessageBox.Show("Đã Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtsdt.Text.Trim().Length == 10 && txtten.Text != "" && txtdiachi.Text != "")
            {

                if (khach.suaKH(txtsdt.Text,txtdiachi.Text))
                {
                    MessageBox.Show("Đã sửa thông tin khách hàng");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgv_khach.DataSource = khach.loadKhach();
            dgv_khach.Columns[3].Visible = false;
        }
    }
}