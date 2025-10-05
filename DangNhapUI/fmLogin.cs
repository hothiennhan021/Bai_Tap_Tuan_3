using System;
using System.Windows.Forms;
using LoginLogic;
namespace DangNhapUI
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();

            string pass = tb_pass.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))

            {

                MessageBox.Show("Vui lòng nhập tên đăng nhập.");

                return;

            }

            if (string.IsNullOrWhiteSpace(pass))

            {

                MessageBox.Show("Vui lòng nhập mật khẩu.");

                return;

            }

            AccountRepository accountRepo = new AccountRepository();// Tạo một đối tượng từ lớp AccountRepository

            UserAccount account = accountRepo.GetAccountByUsername(username);//gọi phương thức 'GetAccountByUsername' từ đối tượng vừa tạo

            if (account != null)

            {

                if (account.Password == pass)

                {

                    MessageBox.Show("Đăng nhập thành công.");

                }

                else MessageBox.Show("Sai mật khẩu.");

            }

            else MessageBox.Show("Tên đăng nhập không tồn tại.");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmForgotPass forgot = new fmForgotPass();
            forgot.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
