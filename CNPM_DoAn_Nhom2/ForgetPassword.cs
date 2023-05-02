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
using System.Net.Mime;
using System.Security.Cryptography;

namespace CNPM_DoAn_Nhom2
{
    public partial class ForgetPassword : Form
    {
        Random random = new Random();
        int otp;
        QLBDDataContext db = new QLBDDataContext();
        public ForgetPassword()
        {
            InitializeComponent();
        }

        void hide()
        {
            lblNewPassword.Visible = false;
            lblOTP.Visible = false;
            txtNewPassword.Visible=false;
            txtOTP.Visible=false;
            chkShowPassword.Visible=false;
        }

        void show()
        {
            lblNewPassword.Visible = true;
            lblOTP.Visible = true;
            txtNewPassword.Visible = true;
            txtOTP.Visible = true;
            chkShowPassword.Visible = true;
        }
       

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            hide();
            txtNewPassword.UseSystemPasswordChar = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(otp.ToString()==txtOTP.Text.Trim()) 
            {
                if(txtNewPassword.Text.Length>=6)
                {
                    Account account = db.Accounts.SingleOrDefault(u=>u.UserName==txtUser.Text.Trim());
                    account.Password = txtNewPassword.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật mật khẩu mới thành công !");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải chứa ít nhất 6 kí tự !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
            }
            else
            {
                MessageBox.Show("OTP chưa chính xác !");
                return;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Vui lòng điền thông tin tài khoản", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Account account = db.Accounts.SingleOrDefault(a => a.UserName == txtUser.Text.Trim());
                if(account == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }
                try
                {
                    otp = random.Next(100000, 999999);

                    var from = new MailAddress("tranlechihai128@gmail.com");
                    var to = new MailAddress(account.Email);

                    const string frompass = "arvuzajbvlfmlvtm"; //mật khẩu ứng dụng Gmail của Hải
                    const string subject = "[FIT LEAGUE] - OTP CODE";
                    string body = "Mã OTP để đặt lại mật khẩu FIT LEAGUE của bạn là: " + otp.ToString();

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(from.Address, frompass),
                        Timeout = 200000
                    };
                    using (var message = new MailMessage(from, to)
                    {
                        Subject = subject,
                        Body = body,

                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Gửi mã OTP thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    hide();
                    return;
                }
                show();
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked) 
            {
                txtNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar= true;
            }    
        }

        private void ctbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
