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
    public partial class MatchForm : Form
    {

       

        QLBDDataContext db = new QLBDDataContext();
        public MatchForm()
        {
            InitializeComponent();
            Loaddgv();
        }

        private void ptcAdd_Click(object sender, EventArgs e)
        {
            AddMatchForm frm = new AddMatchForm();
            frm.ShowDialog();
            Loaddgv();
        }
        void Loaddgv()
        {
            dgvMatch.DataSource = db.tbl_Lichthidaus.ToList().Select((p,i) => new { index=i+1, p.ID,TenDoi1 = p.tbl_Doi_Bong.Ten_Doi_Bong, TenDoi2 = p.tbl_Doi_Bong1.Ten_Doi_Bong, p.TenSan, p.NgayGio,p.Doi1,p.Doi2 }).ToList();
        }

        private void dgvMatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && dgvMatch.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int IDlichthidau = int.Parse(dgvMatch["ID",e.RowIndex].Value.ToString());
                tbl_Lichthidau tbl = db.tbl_Lichthidaus.SingleOrDefault(p => p.ID == IDlichthidau);

                ResultMatchForm frm =new ResultMatchForm(tbl);
                frm.ShowDialog();
            }
            else
            {
                int ID, ID1, ID2;
                DateTimePicker tmp = new DateTimePicker();
                string san = "";
                ID = int.Parse(dgvMatch["ID", e.RowIndex].Value.ToString());
                ID1 = int.Parse(dgvMatch["IDDoi1", e.RowIndex].Value.ToString());
                ID2 = int.Parse(dgvMatch["IDDoi2", e.RowIndex].Value.ToString());
                tmp.Value = DateTime.Parse(dgvMatch["NgayGio", e.RowIndex].Value.ToString());
                san = dgvMatch["TenSan", e.RowIndex].Value.ToString();
                AddMatchForm frm = new AddMatchForm(ID, ID1, ID2, san, tmp);
                frm.ShowDialog();
                Loaddgv();
            }    
        }
    }
}
