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
    public partial class AddMatchForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        QLBDDataContext db =new QLBDDataContext();
        int IDLichthidau = -1;
        public AddMatchForm(int ID=0,int ID1=0,int ID2=0,string tensan="",DateTimePicker dtpk=null)
        {
            InitializeComponent();
            LoadData();
            if (ID != 0)
            {
                btnSua.Show();
                IDLichthidau = ID;
                //Truyền dữ liệu vào ô
                tbl_Doi_Bong doi1 = db.tbl_Doi_Bongs.SingleOrDefault(p => p.ID == ID1);
                tbl_Doi_Bong doi2 = db.tbl_Doi_Bongs.SingleOrDefault(p => p.ID == ID2);
                cbbDoi1.Text = doi1.Ten_Doi_Bong.ToString();
                cbbDoi1.SelectedValue = doi1.ID;
                cbbDoi2.Text = doi2.Ten_Doi_Bong.ToString();
                cbbDoi2.SelectedValue = doi2.ID;
                txtSan.Text = tensan;
                dtpkNgay.Value = dtpk.Value;
                btnThem.Enabled = false;
            }
            else
            { btnSua.Hide();
                btnThem.Enabled = true;
            }
        }
        void LoadData()
        {
            LoadDoi1();
            LoadDoi2();
            tbl_Doi_Bong tbl = db.tbl_Doi_Bongs.SingleOrDefault(p => p.ID == int.Parse(cbbDoi1.SelectedValue.ToString()));
            txtSan.Text = tbl.Ten_San_nha;
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

        void LoadDoi1()
        {
            cbbDoi1.DataSource = db.tbl_Doi_Bongs.OrderBy(p=>p.ID);
            cbbDoi1.DisplayMember = "Ten_Doi_Bong";
            cbbDoi1.ValueMember = "ID";
        }
        void LoadDoi2()
        {
            cbbDoi2.DataSource = db.tbl_Doi_Bongs.OrderByDescending(p => p.ID);
            cbbDoi2.DisplayMember = "Ten_Doi_Bong";
            cbbDoi2.ValueMember = "ID";
        }

        private void cbbDoi1_SelectedIndexChanged(object sender, EventArgs e)
        {


            
            int id;
            if(int.TryParse( cbbDoi1.SelectedValue.ToString(),out id))
            {
                tbl_Doi_Bong tbl = db.tbl_Doi_Bongs.SingleOrDefault(p => p.ID == id);
                txtSan.Text = tbl.Ten_San_nha;
            }

           
            
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cbbDoi1.Text == cbbDoi2.Text)
            {
                MessageBox.Show("Hai đội phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tbl_Lichthidau tbl = new tbl_Lichthidau();
            tbl.Doi1 = int.Parse(cbbDoi1.SelectedValue.ToString());
            tbl.Doi2 = int.Parse(cbbDoi2.SelectedValue.ToString());
            tbl.NgayGio = dtpkNgay.Value;
            tbl.TenSan = txtSan.Text;
            db.tbl_Lichthidaus.InsertOnSubmit(tbl);
            db.SubmitChanges();
            MessageBox.Show("Thêm lịch thi đấu thành công!","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbl_Lichthidau tbl = db.tbl_Lichthidaus.SingleOrDefault(p => p.ID == IDLichthidau);
            tbl.Doi1 = int.Parse(cbbDoi1.SelectedValue.ToString());
            tbl.Doi2 = int.Parse(cbbDoi2.SelectedValue.ToString());
            tbl.NgayGio = dtpkNgay.Value;
            tbl.TenSan=txtSan.Text;
            db.SubmitChanges();
            MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
