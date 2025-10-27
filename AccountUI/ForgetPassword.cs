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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountUI
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.DarkSlateBlue;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Email";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void button3_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (textBox1.Text == "Email")
            {
                MessageBox.Show("Vui Lòng Nhập Email","Chú Ý !");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    string matkhau = textBox3.Text;
                    bool isMatKhauHopLe = System.Text.RegularExpressions.Regex.IsMatch(matkhau, @"^[A-Za-z0-9]{6,24}$");
                    if (!isMatKhauHopLe)
                    {
                        MessageBox.Show("Vui lòng nhập MẬT KHẨU dài 6-24 ký tự, với các ký tự chữ và số...", "Lỗi");
                        return;
                    }
                    else
                    {
                        string matkhauSHA256 = SHA256Helper.Encode(matkhau);
                        string query2 = "UPDATE TaiKhoan SET MatKhau = '" + matkhauSHA256 + "' WHERE Email = '" + email + "'";
                        modify.Command(query2);
                        MessageBox.Show("Thay đổi mật khẩu thành công !","Thông Báo !");
                    }

                }
                else
                {
                    MessageBox.Show("Email vừa nhập không chính xác!","Chú Ý !");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resetpassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Mật Khẩu Mới")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.DarkSlateBlue;
                textBox3.PasswordChar = '*';
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Mật Khẩu Mới";
                textBox3.ForeColor = Color.Gray;
                textBox3.PasswordChar = '\0';
            }
        }

        private void button_passwordhide_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                button_passwordshow.BringToFront();
                textBox3.PasswordChar = '*';
            }
        }

        private void button_passwordshow_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                button_passwordhide.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }
    }
}
