using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_BAL
{
    public class HangHoa_DAL_BAL
    {
        private QL_CHTLDataContext db;
        public HangHoa_DAL_BAL()
        {
            db = new QL_CHTLDataContext();
        }
        public List<HANG> LoadSPTheoTen(string tenSp)
        {
            List<HANG> result = new List<HANG>();
            var link = from hg in db.HANGs
                       join ncc in db.NHACCs on hg.MANCC equals ncc.MANCC
                       where hg.TENHG.Contains(tenSp)
                       select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, hg.MANCC, hg.DONGIA, hg.TINHTRANG, hg.ANH };
            foreach (var sp in link)
            {
                result.Add(new HANG
                {
                    MAHG = sp.MAHG,
                    TENHG = sp.TENHG,
                    DVT = sp.DVT,
                    SOLUONG = sp.SOLUONG,
                    MANCC = sp.MANCC,
                    DONGIA = sp.DONGIA,
                    TINHTRANG = sp.TINHTRANG,
                    ANH = sp.ANH
                });
            }
            return result;
        }
        public List<HANG> loadSPtheoMa(string mahang)
        {
            List<HANG> result = new List<HANG>();
            var link = from hg in db.HANGs
                       join ncc in db.NHACCs on hg.MANCC equals ncc.MANCC
                       where hg.MAHG.ToString().Contains(mahang)
                       select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, hg.MANCC, hg.DONGIA, hg.TINHTRANG, hg.ANH };
            foreach (var sp in link)
            {
                result.Add(new HANG
                {
                    MAHG = sp.MAHG,
                    TENHG = sp.TENHG,
                    DVT = sp.DVT,
                    SOLUONG = sp.SOLUONG,
                    MANCC = sp.MANCC,
                    DONGIA = sp.DONGIA,
                    TINHTRANG = sp.TINHTRANG,
                    ANH = sp.ANH
                });
            }
            return result;
        }
        public bool ThemHang(string tenhang, int mancc, int soluong, double dongia, string dvt, string linkanh)
        {
            HANG a= new HANG();
            a.TENHG=tenhang;
            a.MANCC=mancc;
            a.SOLUONG = soluong;
            a.DONGIA = dongia;
            a.DVT = dvt;
            string[] temp = linkanh.Split('\\');
            foreach (string link in temp)
            {
                a.ANH = link;
            }
            try
            {
                db.HANGs.InsertOnSubmit(a);
                db.SubmitChanges();
                try
                {
                    System.IO.File.Copy(linkanh, System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + a.ANH, true);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            catch {
                return false;
            }
        }
        public bool xoaHang(string mahg)
        {
            HANG hang = db.HANGs.Where(t => t.MAHG.Equals(mahg.Trim())).FirstOrDefault();

            DialogResult kt = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kt == DialogResult.Yes)
            {
                try
                {
                    db.HANGs.DeleteOnSubmit(hang);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        public bool SuaHang(int mahang,string tenhang, int mancc, int soluong, double dongia, string dvt, string linkanh)
        {
            HANG hg = db.HANGs.Where(t => t.MAHG == mahang).FirstOrDefault();
            hg.TENHG = tenhang.Trim();
            hg.MANCC = mancc;
            hg.SOLUONG = soluong;
            hg.DONGIA = dongia;
            hg.DVT = dvt;
            
            string[] temp = linkanh.Split('\\');
            foreach (string hihi in temp)
            {
                hg.ANH = hihi;
            }
            try
            {
                db.SubmitChanges();
                try
                {
                    System.IO.File.Copy(linkanh, System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + hg.ANH, true);
                }
                catch
                {
                    MessageBox.Show("Hình ảnh đã tồn tại sẵn");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
