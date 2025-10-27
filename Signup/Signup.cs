using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace AccountUI
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)
        {
            if (string.IsNullOrWhiteSpace(ac)) return false;
            ac = ac.Trim();
            // chỉ cho phép chữ A-Z a-z và số, 6-24 ký tự
            return Regex.IsMatch(ac, @"^[A-Za-z0-9]{6,24}$");
        }


        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Text;
            bool isTenTkHopLe = System.Text.RegularExpressions.Regex.IsMatch(tentk, @"^[A-Za-z0-9]{6,24}$");

            if (!isTenTkHopLe)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ", "Chú Ý");
                return;
            }
            string matkhau = textBox3.Text;
            string xnmatkhau = textBox4.Text;
            string email = textBox2.Text;
            bool isMatKhauHopLe = System.Text.RegularExpressions.Regex.IsMatch(matkhau, @"^[A-Za-z0-9]{6,24}$");
            if (!isMatKhauHopLe)
            {
                MessageBox.Show("Vui lòng nhập MẬT KHẨU dài 6-24 ký tự, với các ký tự chữ và số...", "Lỗi");
                return;
            }
            bool isEmailHopLe = System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
            if (!isEmailHopLe)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email @gmail.com!");
                return;
            }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0)
            { MessageBox.Show("Email này đã được được đăng ký, vui lòng đăng ký email khác!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng kí tên tài khoản khác!");
                return; // Dừng lại nếu tên tài khoản đã tồn tại
            }

            try
            {
                string matkhau_SHA256 = SHA256Helper.Encode(matkhau);
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau_SHA256 + "','" + email + "')";
                modify.Command(query);
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Email")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.DarkSlateBlue;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Email";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Mật Khẩu")
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
                textBox3.Text = "Mật Khẩu";
                textBox3.ForeColor = Color.Gray;
                textBox3.PasswordChar = '\0';
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Xác Nhận Mật Khẩu")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.DarkSlateBlue;
                textBox4.PasswordChar = '*';
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Xác Nhận Mật Khẩu";
                textBox4.ForeColor = Color.Gray;
                textBox4.PasswordChar = '\0';
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

        private void button_passwordhide2_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '\0')
            {
                button_passwordshow2.BringToFront();
                textBox4.PasswordChar = '*';
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

        private void button_passwordshow2_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '*')
            {
                button_passwordhide2.BringToFront();
                textBox4.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quay Lại ?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
