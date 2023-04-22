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
    public partial class AddDoiBongForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        QLBDDataContext db = new QLBDDataContext();
        public AddDoiBongForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if(string.IsNullOrEmpty(txtSannha.Text)||string.IsNullOrEmpty(txtTenDoi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ dữ liệu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }    
            else
            {
                tbl_Doi_Bong tbl_Doi_Bong = new tbl_Doi_Bong();
                tbl_Doi_Bong.Ten_San_nha= txtSannha.Text;
                tbl_Doi_Bong.Ten_Doi_Bong= txtTenDoi.Text;
                db.tbl_Doi_Bongs.InsertOnSubmit(tbl_Doi_Bong);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();   
            }    
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
