using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_DoAn_Nhom2
{
    public partial class ResultMatchForm : Form
    {
        tbl_Lichthidau tbl_Lichthidau=null;
        public ResultMatchForm(tbl_Lichthidau tbl=null)
        {
            InitializeComponent();
            tbl_Lichthidau=tbl;
        }

        private void ResultMatchForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        void LoadForm()
        {
            if (tbl_Lichthidau != null)
            {
                lblDoi1.Text = tbl_Lichthidau.tbl_Doi_Bong.Ten_Doi_Bong;
                lblDoi2.Text = tbl_Lichthidau.tbl_Doi_Bong1.Ten_Doi_Bong;
                lblSan.Text = tbl_Lichthidau.TenSan;
                lbltyso.Text = "0";
                lblNgay.Text = tbl_Lichthidau.NgayGio.ToString();

            }
        }
    }
}
