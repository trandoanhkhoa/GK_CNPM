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
    public partial class ChangeDoiBongForm : Form
    {



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        tbl_Doi_Bong tbldoibong = null;
        QLBDDataContext db = new QLBDDataContext();
        public ChangeDoiBongForm(tbl_Doi_Bong tbl=null)
        {
            tbldoibong = tbl;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            if(tbldoibong!=null)
            {
                txtTenDoi.Text = tbldoibong.Ten_Doi_Bong;
                txtSannha.Text = tbldoibong.Ten_San_nha;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbl_Doi_Bong tmp_tbl = db.tbl_Doi_Bongs.SingleOrDefault(p=>p.ID==tbldoibong.ID);
            tmp_tbl.Ten_San_nha=txtSannha.Text;
            tmp_tbl.Ten_Doi_Bong = txtTenDoi.Text;
            db.SubmitChanges();
            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
    }
}
