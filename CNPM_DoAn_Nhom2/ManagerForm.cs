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
    public partial class ManagerForm : Form
    {
        QLBDDataContext db = new QLBDDataContext();
        public ManagerForm()
        {
            InitializeComponent();
            Loaddgv();
            
        }
        void LoadCBBDoiBong()
        {
            tbl_Doi_Bong tmp = null;
            if (cbbDoibong.SelectedValue!=null)
            {
                tmp = db.tbl_Doi_Bongs.SingleOrDefault(p => p.ID == int.Parse(cbbDoibong.SelectedValue.ToString()));
            }    
            
            
            if(tmp!=null) txtSannha.Text = tmp.Ten_San_nha;
        }    
        void Loaddgv()
        {
           
            cbbDoibong.DataSource = db.tbl_Doi_Bongs;
            cbbDoibong.DisplayMember = "Ten_Doi_Bong";
            cbbDoibong.ValueMember = "ID";
            //var query = db.tbl_Doi_Bongs.Where(x=>x.ID == (int) cbbDoibong.SelectedValue).Select(x=>x.Ten_Doi_Bong);
            //txtSannha.Text= query.ToString();
            if(cbbDoibong.SelectedValue !=null)
            dgvDoibong.DataSource = db.tbl_Cauthus.ToList().Select((p,i) => new {rownumber=i+1, p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu,p.Doi }).Where(p => p.Doi==(int)cbbDoibong.SelectedValue).ToList();

            dgvCauthu.DataSource = db.tbl_Cauthus.ToList().Select((p, i) => new { index = i + 1, p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu, p.ID }).ToList();
             
            LoadCBBDoiBong();
        }

        private void cbbDoibong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loaddgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            if(txtSearch.Text.Length > 0)
            {
                dgvDoibong.DataSource = db.tbl_Cauthus.ToList().Select((p,i) => new {rownumber=i+1, p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu, p.Doi}).Where(p => p.Doi == (int)cbbDoibong.SelectedValue).Where(p=> p.TenCauthu.Contains(txtSearch.Text)|| p.GhiChu.Contains(txtSearch.Text)||p.LoaiCauthu.Contains(txtSearch.Text));
            }   
            else
            {
                Loaddgv();
            }    
        }


        private void ptcAdd_Click(object sender, EventArgs e)
        {
            AddDoiBongForm addDoiBongForm = new AddDoiBongForm();
            addDoiBongForm.ShowDialog();
            Loaddgv();
        }

        private void ptcAddCauthu_Click(object sender, EventArgs e)
        {
            AddCauThuForm add = new AddCauThuForm();
            add.ShowDialog();
            Loaddgv();
        }

        private void txtSearchCauthu_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSearchCauthu.Text.Length > 0)
            {
                dgvCauthu.DataSource = db.tbl_Cauthus.ToList().Select((p,i) => new {index=i+1, p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu,p.ID }).Where(p => p.TenCauthu.Contains(txtSearchCauthu.Text) || p.GhiChu.Contains(txtSearchCauthu.Text) || p.LoaiCauthu.Contains(txtSearchCauthu.Text));
            }
            else
            {
                dgvCauthu.DataSource = db.tbl_Cauthus.ToList().Select((p,i) => new {index=i+1, p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu, p.ID });
            }
        }

       

        private void ptcDelete_Click(object sender, EventArgs e)
        {
            var tmp = db.tbl_Cauthus.Where(p => p.Doi == int.Parse(cbbDoibong.SelectedValue.ToString())).ToList();
            if (tmp != null) { db.tbl_Cauthus.DeleteAllOnSubmit(tmp); db.SubmitChanges(); }
            var tmpLichthidau = db.tbl_Lichthidaus.Where(p => p.Doi1 == int.Parse(cbbDoibong.SelectedValue.ToString()) || p.Doi2 == int.Parse(cbbDoibong.SelectedValue.ToString()));
            if(tmpLichthidau != null)
            {
                db.tbl_Lichthidaus.DeleteAllOnSubmit(tmpLichthidau);
                db.SubmitChanges();
            }    
            tbl_Doi_Bong tbl = db.tbl_Doi_Bongs.SingleOrDefault(p => p.ID == int.Parse(cbbDoibong.SelectedValue.ToString()));
            
            if (tbl != null)
            {
                db.tbl_Doi_Bongs.DeleteOnSubmit(tbl);
            }
            db.SubmitChanges();
            MessageBox.Show("Xóa đội bóng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Loaddgv();
        }

        private void ptcChange_Click(object sender, EventArgs e)
        {
            tbl_Doi_Bong tbl = db.tbl_Doi_Bongs.SingleOrDefault(p=>p.ID==int.Parse(cbbDoibong.SelectedValue.ToString()));
            ChangeDoiBongForm frm = new ChangeDoiBongForm(tbl);
            frm.ShowDialog();
            Loaddgv();
        }

        private void dgvCauthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int IDcauthu = int.Parse(dgvCauthu["ID",e.RowIndex].Value.ToString());
                tbl_Cauthu tbl = db.tbl_Cauthus.SingleOrDefault(p=>p.ID==IDcauthu);
                if(tbl != null)
                {
                    AddCauThuForm frm = new AddCauThuForm(tbl);
                    frm.ShowDialog();
                    Loaddgv();
                }
                
            }
        }
    }
}
