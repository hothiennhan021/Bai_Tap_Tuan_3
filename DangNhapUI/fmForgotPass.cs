using LoginLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DangNhapUI
{
    public partial class fmForgotPass : Form
    {
        public fmForgotPass()
        {
            InitializeComponent();
        }

        private void bt_layMk_Click(object sender, EventArgs e)
        {
            string mail= tb_mailStd.Text.Trim();
            string pass = "";
            AccountRepository accountRepo = new AccountRepository();// Tạo một đối tượng từ lớp AccountRepository
            UserAccount account = accountRepo.GetAccountByEmailOrPhone(mail);
            
            string user = account.Username;
            if (account != null)
            {
                if (account.EmailOrPhone != null)
                {
                    pass=account.Password;
                }
                else
                {
                    MessageBox.Show("Tài khoản không có email hoặc số điện thoại.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản!");
            }
            {
                tb_mk.Text = $"Username: {user}\r\nPassword: {pass}";
            }
        }
    }
}
