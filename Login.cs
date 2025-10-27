using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AccountUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Text;
            string matkhau_SHA256 = textBox2.Text;
            string matkhau = SHA256Helper.Encode(matkhau_SHA256);
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Chú Ý");
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Chú Ý");
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu mainmenu = new MainMenu();
                    mainmenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Chú Ý");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword rspass = new ForgetPassword();
            rspass.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tên Đăng Nhập")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.DarkSlateBlue;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Tên Đăng Nhập";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mật Khẩu")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.DarkSlateBlue;
                textBox2.PasswordChar = '*';
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Mật Khẩu";
                textBox2.ForeColor = Color.Gray;
                textBox2.PasswordChar = '\0';
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_passwordhide_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button_passwordshow.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void button_passwordshow_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button_passwordhide.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }
    }
}
