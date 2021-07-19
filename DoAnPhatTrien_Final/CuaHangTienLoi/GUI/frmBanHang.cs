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
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DAL_BAL;

namespace GUI
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        HangHoa_DAL_BAL hang = new HangHoa_DAL_BAL();
        Khach_DAL_BAL khach = new Khach_DAL_BAL();
        string sdtnv="0123456789";
        int MaHoaDon;
        List<string> lstGioHang;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            lstGioHang = new List<string>();
            FlowLayoutPanel flowLayoutPanelnew = new FlowLayoutPanel();
            flowLayoutPanelnew.Tag = "1";
            flowLayoutPanelnew.Size = new System.Drawing.Size(479, 92);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelnew);
            //hinh
            PictureBox hinh = new PictureBox();
            hinh.Size = new System.Drawing.Size(107, 89);
            hinh.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanelnew.Controls.Add(hinh);
            hinh.SizeMode = PictureBoxSizeMode.StretchImage;
            hinh.Tag = "2";
            //soluong
            Label sl = new Label();
            Panel pnSL = new Panel();
            pnSL.Size = new System.Drawing.Size(59, 89);
            pnSL.Controls.Add(sl);
            sl.Location = new System.Drawing.Point(14, 33);
            sl.Size = new System.Drawing.Size(25, 17);
            flowLayoutPanelnew.Controls.Add(pnSL);
            sl.Text = "SL";
            sl.Tag = "3";
            //dongia
            Label lbDonGia = new Label();
            Panel pnDG = new Panel();
            pnDG.Location = new System.Drawing.Point(181, 3);
            pnDG.Size = new System.Drawing.Size(147, 89);
            pnDG.Controls.Add(lbDonGia);
            lbDonGia.Location = new System.Drawing.Point(42, 33);
            lbDonGia.Size = new System.Drawing.Size(57, 17);
            flowLayoutPanelnew.Controls.Add(pnDG);
            lbDonGia.Text = "Đơn giá";
            lbDonGia.Tag = "3";
            pnDG.Tag = "5";
            //thanhtien
            Label lbThanhTien = new Label();
            lbThanhTien.Tag = "LBTT";
            Panel pnTT = new Panel();
            pnTT.Tag = "2";
            pnTT.Location = new System.Drawing.Point(334, 3);
            pnTT.Size = new System.Drawing.Size(136, 86);
            pnTT.Controls.Add(lbThanhTien);
            flowLayoutPanelnew.Controls.Add(pnTT);
            lbThanhTien.Location = new System.Drawing.Point(31, 33);
            lbThanhTien.Size = new System.Drawing.Size(81, 17);
            lbThanhTien.Text = "Thành tiền";
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                txtMaSP.Enabled = true;
            }
            else
                txtMaSP.Enabled = false;
            dgv_sanpham.DataSource = hang.LoadSPTheoTen(txtTenSP.Text);
            dgv_sanpham.Columns[7].Visible = false;
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
                txtTenSP.Enabled = true;
            else
                txtTenSP.Enabled = false;
            dgv_sanpham.DataSource = hang.loadSPtheoMa(txtMaSP.Text);
            dgv_sanpham.Columns[7].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (FlowLayoutPanel pn in flowLayoutPanel1.Controls)
            {
                if (pn.Tag.ToString() == dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Đã có sản phẩm này rồi");
                    return;
                }
                if (dgv_sanpham.SelectedRows[0].Cells[3].Value.ToString() == "0")
                {
                    MessageBox.Show("Đã hết hàng");
                    return;
                }
            }
            FlowLayoutPanel flowLayoutPanelnew = new FlowLayoutPanel();
            flowLayoutPanelnew.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString();
            flowLayoutPanelnew.Size = new System.Drawing.Size(600, 100);
            
            flowLayoutPanel1.Controls.Add(flowLayoutPanelnew);

            //hinh
            PictureBox hinh = new PictureBox();
            hinh.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString();
            hinh.Size = new System.Drawing.Size(107, 89);
            hinh.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanelnew.Controls.Add(hinh);
            hinh.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\" + dgv_sanpham.SelectedRows[0].Cells[6].Value.ToString());
            hinh.SizeMode = PictureBoxSizeMode.StretchImage;

            //soluong
            TextBox sl = new TextBox();
            sl.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString();
            Panel pnSL = new Panel();
            pnSL.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString() + "PNSL";
            pnSL.Size = new System.Drawing.Size(59, 89);
            pnSL.Controls.Add(sl);
            sl.Location = new System.Drawing.Point(14, 33);
            sl.Size = new System.Drawing.Size(25, 17);
            flowLayoutPanelnew.Controls.Add(pnSL);
            sl.Text = "1";
            sl.TextChanged += new System.EventHandler(sl_TextChanged);
            sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(sl_KeyPress);
            sl.Leave += new System.EventHandler(this.sl_Leave);

            //dongia
            Label lbDonGia = new Label();
            lbDonGia.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString() + "DG";
            Panel pnDG = new Panel();
            pnDG.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString() + "PNDG";
            pnDG.Location = new System.Drawing.Point(181, 3);
            pnDG.Size = new System.Drawing.Size(147, 89);
            pnDG.Controls.Add(lbDonGia);
            lbDonGia.Location = new System.Drawing.Point(42, 33);
            lbDonGia.Size = new System.Drawing.Size(57, 17);
            flowLayoutPanelnew.Controls.Add(pnDG);
            lbDonGia.Text = dgv_sanpham.SelectedRows[0].Cells[5].Value.ToString();

            //thanhtien
            Label lbThanhTien = new Label();
            lbThanhTien.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString() + "TT";
            Panel pnTT = new Panel();
            pnTT.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString() + "PNTT";
            pnTT.Location = new System.Drawing.Point(334, 3);
            pnTT.Size = new System.Drawing.Size(136, 86);
            pnTT.Controls.Add(lbThanhTien);
            flowLayoutPanelnew.Controls.Add(pnTT);
            lbThanhTien.Location = new System.Drawing.Point(31, 33);
            lbThanhTien.Size = new System.Drawing.Size(81, 17);
            lbThanhTien.Text = dgv_sanpham.SelectedRows[0].Cells[5].Value.ToString();
            lbThanhTien.TextChanged += new System.EventHandler(lbThanhTien_TextChanged);

            //Xoa
            Button btnXoa = new Button();
            //btnXoa.Image = global::GUI.Properties.Resources;
            btnXoa.Size = new System.Drawing.Size(88, 67);
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnXoa.UseVisualStyleBackColor = true;
            flowLayoutPanelnew.Controls.Add(btnXoa);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            btnXoa.Tag = dgv_sanpham.SelectedRows[0].Cells[0].Value.ToString();
            //update tamtinh
            tinhTamTinh();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Button btnXoa = (Button)sender;
            foreach (Control pn in btnXoa.Parent.Parent.Controls)
            {
                if (pn.Tag.ToString() == btnXoa.Tag.ToString())
                {
                    btnXoa.Parent.Parent.Controls.Remove(pn);
                }
            }
            tinhTamTinh();
        }
        private void tinhTamTinh()
        {
            double tt = 0;
            foreach (Control pn in flowLayoutPanel1.Controls)
            {
                foreach (Control pn1 in pn.Controls)
                {
                    if (pn1.Tag == null) { pn1.Tag = ""; }
                    if (pn1.Tag.ToString().Contains("PNTT"))
                    {
                        foreach (Control lb in pn1.Controls)
                        {
                            if (lb.Text != "Thành tiền")
                            {
                                tt += double.Parse(lb.Text);
                            }
                        }
                    }
                }
            }
            txtTamTinh.Text = tt.ToString();
        }
        private void lbThanhTien_TextChanged(object sender, EventArgs e)
        {
            tinhTamTinh();
        }
        private void sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sl_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "1";
            }
            int soluong = int.Parse(tb.Text);
            double dongia = 0;
            double thanhtien = 0;
            foreach (Control pn in tb.Parent.Parent.Controls)
            {


                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNDG")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "DG")
                            dongia = double.Parse(lb.Text);
                    }
                }
                thanhtien = soluong * dongia;
                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNTT")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "TT")
                            lb.Text = thanhtien.ToString();
                    }
                }
            }
        }

        private void sl_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != "")
            {
                if (int.Parse(tb.Text) <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                    tb.Text = "1";
                }
                using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                {
                    int? slton = db.HANGs.Where(t => t.MAHG == int.Parse(tb.Tag.ToString())).Select(sl => sl.SOLUONG).FirstOrDefault();
                    if (slton == null)
                    {
                        MessageBox.Show("Mặt hàng chưa được nhập");
                        tb.Text = "";
                        return;
                    }
                    else
                    {
                        if (slton < int.Parse(tb.Text))
                        {
                            MessageBox.Show("Mặt hàn chỉ còn " + slton);
                            tb.Text = slton.ToString();
                        }
                    }
                }
            }
            int soluong = 1;
            try
            {
                soluong = int.Parse(tb.Text);
            }
            catch
            {

            }
            double dongia = 1;
            double thanhtien = 1;
            foreach (Control pn in tb.Parent.Parent.Controls)
            {


                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNDG")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "DG")
                            dongia = double.Parse(lb.Text);
                    }
                }
                thanhtien = soluong * dongia;
                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNTT")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "TT")
                            lb.Text = thanhtien.ToString();
                    }
                }
            }
        }
        private void txtThanhVien_Leave(object sender, EventArgs e)
        {
            txtGiamGia.Text = khach.timkhach(txtThanhTien.Text);
        }
        private void cbGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGiamGia.Checked == true)
            {
                txtThanhTien.Text = (double.Parse(txtTamTinh.Text) - double.Parse(txtGiamGia.Text)).ToString();
            }
            else
            {
                txtThanhTien.Text = (double.Parse(txtTamTinh.Text)).ToString();
            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(txtThanhTien.Text) < 0)
            {
                txtThanhTien.Text = "0";
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            
        }
    }
}