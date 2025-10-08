namespace Dang_Nhap_Dang_Ky
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_DangNhap = new Button();
            linkLabel_DangKy = new LinkLabel();
            linkLabel_QuenMatKhau = new LinkLabel();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox_TenTaiKhoan = new TextBox();
            textBox_MatKhau = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_DangNhap
            // 
            button_DangNhap.AutoSize = true;
            button_DangNhap.BackColor = Color.Red;
            button_DangNhap.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_DangNhap.ForeColor = Color.White;
            button_DangNhap.Location = new Point(108, 382);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(113, 43);
            button_DangNhap.TabIndex = 15;
            button_DangNhap.Text = "Đăng Nhập";
            button_DangNhap.UseVisualStyleBackColor = false;
            // 
            // linkLabel_DangKy
            // 
            linkLabel_DangKy.AutoSize = true;
            linkLabel_DangKy.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            linkLabel_DangKy.Location = new Point(196, 342);
            linkLabel_DangKy.Name = "linkLabel_DangKy";
            linkLabel_DangKy.Size = new Size(74, 20);
            linkLabel_DangKy.TabIndex = 14;
            linkLabel_DangKy.TabStop = true;
            linkLabel_DangKy.Text = "Đăng Ký";
            linkLabel_DangKy.LinkClicked += linkLabel_DangKy_LinkClicked;
            // 
            // linkLabel_QuenMatKhau
            // 
            linkLabel_QuenMatKhau.AutoSize = true;
            linkLabel_QuenMatKhau.Font = new Font("Times New Roman", 10.8F);
            linkLabel_QuenMatKhau.Location = new Point(50, 342);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(126, 20);
            linkLabel_QuenMatKhau.TabIndex = 13;
            linkLabel_QuenMatKhau.TabStop = true;
            linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu";
            linkLabel_QuenMatKhau.LinkClicked += linkLabel_QuenMatKhau_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.images1;
            pictureBox5.Location = new Point(50, 294);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.istockphoto_1200064810_170667a;
            pictureBox2.Location = new Point(50, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(75, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;

            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_TenTaiKhoan.Location = new Point(108, 243);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(175, 28);
            textBox_TenTaiKhoan.TabIndex = 16;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_MatKhau.Location = new Point(108, 294);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(175, 28);
            textBox_MatKhau.TabIndex = 17;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(textBox_MatKhau);
            Controls.Add(textBox_TenTaiKhoan);
            Controls.Add(button_DangNhap);
            Controls.Add(linkLabel_DangKy);
            Controls.Add(linkLabel_QuenMatKhau);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_DangNhap;
        private LinkLabel linkLabel_DangKy;
        private LinkLabel linkLabel_QuenMatKhau;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox_TenTaiKhoan;
        private TextBox textBox_MatKhau;
    }
}