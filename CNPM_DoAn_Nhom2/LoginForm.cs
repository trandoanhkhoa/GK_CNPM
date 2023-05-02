using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace CNPM_DoAn_Nhom2
{
    public partial class LoginForm : Form
    {
        QLBDDataContext db = new QLBDDataContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked) 
            {
                txtPassword.UseSystemPasswordChar= false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.ResetText();
            txtUserName.ResetText();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            if(user=="" || password=="")
            {
                MessageBox.Show("Vui lòng điền thông tin tài khoản!");
                return;
            }
            Account account = db.Accounts.SingleOrDefault(p => p.UserName == user && p.Password == password);
            if(account == null)
            {
                lblCheck.Visible = true;
                lblCheck.Text = "Account not correct !";
            }
            else
            {
                txtPassword.ResetText();
                txtUserName.ResetText();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }
        string Hashpassword(string pass)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(pass));
                return Convert.ToBase64String(data);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblCheck.Visible =false;
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword f = new ForgetPassword();
            f.ShowDialog();
        }

        private void HaiDepZai(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
