using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Form isActive(Type ftype) //check if the form is show or not.
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }
       
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(frmThongTinHang)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                frmThongTinHang f = new frmThongTinHang(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(frmBanHang)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                frmBanHang f = new frmBanHang(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(frmKhachHang)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                frmKhachHang f = new frmKhachHang(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(frmNhanvien)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                frmNhanvien f = new frmNhanvien(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(frmNhapHang)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                frmNhapHang f = new frmNhapHang(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(frmNhacc)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                frmNhacc f = new frmNhacc(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }
    }
}
