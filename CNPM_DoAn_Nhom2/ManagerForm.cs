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
            LoadCBBDoiBong();
            Loaddgv();
        }
        void LoadCBBDoiBong()
        {
     
        }    
        void Loaddgv()
        {
           
            cbbDoibong.DataSource = db.tbl_Doi_Bongs;
            cbbDoibong.DisplayMember = "Ten_Doi_Bong";
            cbbDoibong.ValueMember = "ID";
            //var query = db.tbl_Doi_Bongs.Where(x=>x.ID == (int) cbbDoibong.SelectedValue).Select(x=>x.Ten_Doi_Bong);
            //txtSannha.Text= query.ToString();
            dgvDoibong.DataSource = db.tbl_Cauthus.Select(p => new { p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu,p.Doi }).Where(p => p.Doi==(int)cbbDoibong.SelectedValue);

            dgvCauthu.DataSource = db.tbl_Cauthus.Select(p => new { p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu, p.Doi }).Where(p => p.Doi == (int)cbbDoibong.SelectedValue);
        }

        private void cbbDoibong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loaddgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            if(txtSearch.Text.Length > 0)
            {
                dgvDoibong.DataSource = db.tbl_Cauthus.Select(p => new { p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu, p.Doi }).Where(p => p.Doi == (int)cbbDoibong.SelectedValue).Where(p=> p.TenCauthu.Contains(txtSearch.Text)|| p.GhiChu.Contains(txtSearch.Text)||p.LoaiCauthu.Contains(txtSearch.Text));
            }   
            else
            {
                Loaddgv();
            }    
        }

        private void txtSearchCauthu_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                dgvCauthu.DataSource = db.tbl_Cauthus.Select(p => new { p.TenCauthu, p.NgaySinh, p.LoaiCauthu, p.GhiChu, p.Doi }).Where(p => p.Doi == (int)cbbDoibong.SelectedValue).Where(p => p.TenCauthu.Contains(txtSearch.Text) || p.GhiChu.Contains(txtSearch.Text) || p.LoaiCauthu.Contains(txtSearch.Text));
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
           
        }

        private void ptcAddCauthu_Click(object sender, EventArgs e)
        {
            AddCauThuForm add = new AddCauThuForm();
            add.ShowDialog();
        }
    }
}
/Hải test
