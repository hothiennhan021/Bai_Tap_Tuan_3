namespace Dang_Nhap_Dang_Ky
{
    partial class DangKy
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox_TenTaiKhoan = new TextBox();
            textBox_Email = new TextBox();
            textBox_MatKhau = new TextBox();
            textBox_XNMatKhau = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(117, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(15, 183);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Tài Khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(15, 222);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(15, 259);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 5;
            label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(15, 295);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(117, 331);
            button1.Name = "button1";
            button1.Size = new Size(121, 40);
            button1.TabIndex = 9;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_TenTaiKhoan.Location = new Point(187, 175);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(154, 28);
            textBox_TenTaiKhoan.TabIndex = 10;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_Email.Location = new Point(187, 287);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(154, 28);
            textBox_Email.TabIndex = 11;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_MatKhau.Location = new Point(187, 214);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(154, 28);
            textBox_MatKhau.TabIndex = 12;
            // 
            // textBox_XNMatKhau
            // 
            textBox_XNMatKhau.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_XNMatKhau.Location = new Point(187, 251);
            textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            textBox_XNMatKhau.Size = new Size(154, 28);
            textBox_XNMatKhau.TabIndex = 13;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 386);
            Controls.Add(textBox_XNMatKhau);
            Controls.Add(textBox_MatKhau);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_TenTaiKhoan);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DangKy";
            Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox_TenTaiKhoan;
        private TextBox textBox_Email;
        private TextBox textBox_MatKhau;
        private TextBox textBox_XNMatKhau;
    }
}