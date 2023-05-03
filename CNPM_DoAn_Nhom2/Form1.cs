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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Kiểu tra active form
        public Form activeForm = null;
        public void OpenChildForm(Form frm)
        {
            if(activeForm !=null)
            {
                activeForm.Close();
            }
            activeForm = frm;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
            pnlMain.Controls.Add(frm);
        }
        private void optTracuu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagerForm());
        }

<<<<<<< HEAD
        private void optTrandau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MatchForm());
=======
        private void optDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
>>>>>>> 0bd34f02936730b19d9423316669095fe41b9174
        }
    }
}
