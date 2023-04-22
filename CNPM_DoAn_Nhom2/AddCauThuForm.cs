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
        public AddCauThuForm()
        {
            InitializeComponent();
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
            if(string.IsNullOrEmpty(txtTenCauthu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                int sbt = 0 ;
                tbl_Cauthu tbl = new tbl_Cauthu();
                tbl.TenCauthu = txtTenCauthu.Text;
                tbl.Doi =(int)cbbTenDoi.SelectedValue;
            }    
        }
    }
}
