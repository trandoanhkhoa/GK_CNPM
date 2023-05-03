using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_DoAn_Nhom2
{
    public partial class AddCauThuForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        QLBDDataContext db = new QLBDDataContext();
        tbl_Cauthu tbl_Cauthu = null;
        public AddCauThuForm(tbl_Cauthu cauthu=null)
        {
            InitializeComponent();
            tbl_Cauthu= cauthu;
            if(tbl_Cauthu!=null)
            {
                //Cập nhật thông tin
                txtTenCauthu.Text = tbl_Cauthu.TenCauthu;
                nupbanthang.Value = int.Parse(tbl_Cauthu.TongSoBanThang.ToString());
                cbbLoaiCauthu.Text=tbl_Cauthu.LoaiCauthu;
                dtpkNgSinh.Value = DateTime.Parse(tbl_Cauthu.NgaySinh.ToString());
                txtGhichu.Text = tbl_Cauthu.GhiChu.ToString();
                cbbTenDoi.Text = tbl_Cauthu.tbl_Doi_Bong.Ten_Doi_Bong;
                cbbTenDoi.SelectedValue = tbl_Cauthu.Doi;
                //Tùy chỉnh phím bấm
                btnThem.Hide();
                btnSua.Show();
                btnXoa.Show();
            }    
            else
            {
                btnThem.Show();
                btnSua.Hide();
                btnXoa.Hide();
            }    
        }

        private void AddCauThuForm_Load(object sender, EventArgs e)
        {
            cbbTenDoi.DataSource = db.tbl_Doi_Bongs;
            cbbTenDoi.DisplayMember = "Ten_Doi_Bong";
            cbbTenDoi.ValueMember = "ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenCauthu.Text)|| string.IsNullOrEmpty(cbbLoaiCauthu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                // Mặc đinh là 0 bàn thắng 

                //int sbt = 0 ;
                tbl_Cauthu tbl = new tbl_Cauthu();
                tbl.TenCauthu = txtTenCauthu.Text;
                tbl.TongSoBanThang = int.Parse(nupbanthang.Value.ToString());
                tbl.Doi = int.Parse(cbbTenDoi.SelectedValue.ToString());
                tbl.LoaiCauthu = cbbLoaiCauthu.Text;
                tbl.GhiChu = txtGhichu.Text;
                tbl.NgaySinh = dtpkNgSinh.Value;
                tbl.Doi =(int)cbbTenDoi.SelectedValue;
                db.tbl_Cauthus.InsertOnSubmit(tbl);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm thành công cầu thủ này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenCauthu.Text) || string.IsNullOrEmpty(cbbLoaiCauthu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tbl_Cauthu tmp = db.tbl_Cauthus.SingleOrDefault(p=>p.ID==tbl_Cauthu.ID);
                tmp.TenCauthu = txtTenCauthu.Text;
                tmp.GhiChu=txtGhichu.Text;
                tmp.LoaiCauthu = cbbLoaiCauthu.Text;
                tmp.Doi=int.Parse(cbbTenDoi.SelectedValue.ToString());
                tmp.TongSoBanThang = int.Parse(nupbanthang.Value.ToString());
                tmp.NgaySinh=dtpkNgSinh.Value;
                db.SubmitChanges();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbl_Cauthu tmp = db.tbl_Cauthus.SingleOrDefault(p => p.ID == tbl_Cauthu.ID);
            db.tbl_Cauthus.DeleteOnSubmit(tmp);
            db.SubmitChanges();
            MessageBox.Show("Xóa thành công cầu thủ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
